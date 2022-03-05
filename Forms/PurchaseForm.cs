using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Computer_MGS.Forms
{
    public partial class PurchaseForm : Form
    {
        OracleConnection conn;

        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = Classes.DBConnection.Connect();
                LoadData();
                SupplierIDDropDown();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadData()
        {
            string sql = "SELECT pur.PurchaseID, sta.StaffName, sup.SupplierName, pur.PurchaseDate FROM tblPurchases pur, tblStaff sta, tblSuppliers sup WHERE sta.StaffID = pur.StaffID AND sup.SupplierID = pur.SupplierID ORDER BY pur.PurchaseID ASC";
            OracleCommand select_cmd = new OracleCommand(sql, conn);
            OracleDataAdapter adapter = new OracleDataAdapter(select_cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvPurchase.DataSource = dt;

            dgvPurchase.ClearSelection();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        void ClearField()
        {
            txtPurchaseID.Text = string.Empty;
            txtStaffID.Text = string.Empty;
            cbSupplierID.Text = string.Empty;
            dtpPurchaseDate.Text = string.Empty;
            txtPurchaseID.Focus();
        }

        void SupplierIDDropDown()
        {
            string select_sql = "SELECT SupplierID, SupplierName FROM tblSuppliers";
            OracleCommand cmd = new OracleCommand(select_sql, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbSupplierID.Items.Add(dr["SupplierName"].ToString());
                cbSupplierID.DisplayMember = (dr["SupplierName"].ToString());
                cbSupplierID.ValueMember = (dr["SupplierID"].ToString());
            }
        }

        string SupplierID;

        private void cbSupplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string search_cmd = "SELECT SupplierID FROM tblSuppliers WHERE SupplierName = '" + cbSupplierID.SelectedItem + "'";
                OracleCommand cmd = new OracleCommand(search_cmd, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    SupplierID = dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnCreate.Text == "Create")
                {
                    btnCreate.Text = "Save";
                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = true;
                    btnDelete.Text = "Cancel";
                    dgvPurchase.Enabled = false;
                    ClearField();
                }
                else if (btnCreate.Text == "Save")
                {
                    if (string.IsNullOrEmpty(cbSupplierID.Text))
                    {
                        MessageBox.Show("Supplier ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(dtpPurchaseDate.Text))
                    {
                        MessageBox.Show("Purchase Date can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "INSERT INTO tblPurchases(StaffID, SupplierID, PurchaseDate) VALUES(:2, :3, :4)";
                        OracleCommand insert_command = new OracleCommand(sql, conn);
                        insert_command.Parameters.Add(new OracleParameter("2", /*Classes.UserLogin.getStaffID()*/"Admin"));
                        insert_command.Parameters.Add(new OracleParameter("3", Int32.Parse(SupplierID)));
                        insert_command.Parameters.Add(new OracleParameter("4", dtpPurchaseDate.Text));

                        if (insert_command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("One record has added to Database!", "CREATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnCreate.Text = "Create";
                            btnUpdate.Enabled = true;
                            btnDelete.Text = "Delete";
                            dgvPurchase.Enabled = true;
                            ClearField();
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Fail to add!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to update, " + txtPurchaseID.Text + "?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtPurchaseID.Text))
                    {
                        MessageBox.Show("Purchase ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbSupplierID.Text))
                    {
                        MessageBox.Show("Supplier ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(dtpPurchaseDate.Text))
                    {
                        MessageBox.Show("Purchase Date can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "UPDATE tblPurchases SET StaffID = :2, SupplierID = :3, PurchaseDate = :4 WHERE PurchaseID = :1";
                        OracleCommand update_command = new OracleCommand(sql, conn);
                        update_command.Parameters.Add(new OracleParameter("2", /*Classes.UserLogin.getStaffID()*/"Admin"));
                        update_command.Parameters.Add(new OracleParameter("3", SupplierID));
                        update_command.Parameters.Add(new OracleParameter("4", dtpPurchaseDate.Text));
                        update_command.Parameters.Add(new OracleParameter("1", Int32.Parse(txtPurchaseID.Text)));

                        if (update_command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("One record has updated to Database!", "UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                            ClearField();
                        }
                        else
                        {
                            MessageBox.Show("Fail to update!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnDelete.Text == "Cancel")
                {
                    btnCreate.Text = "Create";
                    btnDelete.Enabled = false;
                    btnDelete.Text = "Delete";
                    dgvPurchase.Enabled = true;
                }
                else if (btnDelete.Text == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete, " + txtPurchaseID.Text + "?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "DELETE tblPurchases WHERE PurchaseID = :1";
                        OracleCommand delete_cmd = new OracleCommand(sql, conn);
                        delete_cmd.Parameters.Add(new OracleParameter("1", Int32.Parse(txtPurchaseID.Text)));

                        if (delete_cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("One record has deleted from Database!", "DELETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        else
                        {
                            MessageBox.Show("Fail to delete!", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnMakeReport_Click(object sender, EventArgs e)
        {

        }

        private void dgvPurchase_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            txtPurchaseID.Text = dgvPurchase.CurrentRow.Cells[0].Value.ToString();

            //StaffID = dgvPurchase.CurrentRow.Cells[1].Value.ToString();
            txtStaffID.Text = dgvPurchase.CurrentRow.Cells[1].Value.ToString();

            SupplierID = dgvPurchase.CurrentRow.Cells[2].Value.ToString();
            cbSupplierID.Text = dgvPurchase.CurrentRow.Cells[2].Value.ToString();

            dtpPurchaseDate.Text = dgvPurchase.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OracleCommand sql_search = new OracleCommand("SELECT pur.PurchaseID, sta.StaffName, sup.SupplierName, pur.PurchaseDate FROM tblPurchases pur, tblStaff sta, tblSuppliers sup WHERE sta.StaffID = pur.StaffID AND sup.SupplierID = pur.SupplierID AND" + " UPPER (pur.PurchaseID || sta.StaffName || sup.SupplierName || pur.PurchaseDate)" + " LIKE UPPER ('%" + txtSearch.Text + "%') ORDER BY pur.PurchaseID ASC", conn);
                OracleDataAdapter adapt = new OracleDataAdapter(sql_search);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                dgvPurchase.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
