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
    public partial class PurchaseDetailForm : Form
    {
        OracleConnection conn;

        public PurchaseDetailForm()
        {
            InitializeComponent();
        }

        private void PurchaseDetailForm_Load(object sender, EventArgs e)
        {
            conn = Classes.DBConnection.Connect();
            LoadData();
            PurchaseIDDropDown();
            ComputerIDDropDown();
        }

        void LoadData()
        {
            string sql = "SELECT pur.PurchaseID, com.ComputerName, pur.PurchaseQty FROM tblPurchaseDetails pur, tblComputers com WHERE com.ComputerID = pur.ComputerID ORDER BY pur.PurchaseID ASC";
            OracleCommand select_cmd = new OracleCommand(sql, conn);
            OracleDataAdapter adapter = new OracleDataAdapter(select_cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvPurchaseDetail.DataSource = dt;

            dgvPurchaseDetail.ClearSelection();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        void ClearField()
        {
            cbPurchaseID.Text = string.Empty;
            cbComputerID.Text = string.Empty;
            txtPurchaseQty.Text = string.Empty;
            cbComputerID.Focus();
        }

        void PurchaseIDDropDown()
        {
            string select_sql = "SELECT PurchaseID FROM tblPurchases";
            OracleCommand cmd = new OracleCommand(select_sql, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbPurchaseID.Items.Add(dr["PurchaseID"].ToString());
                cbPurchaseID.DisplayMember = (dr["PurchaseID"].ToString());
                cbPurchaseID.ValueMember = (dr["PurchaseID"].ToString());
            }
        }

        string PurchaseID;

        private void cbPurchaseID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string search_cmd = "SELECT PurchaseID FROM tblPurchases WHERE PurchaseID = '" + cbPurchaseID.SelectedItem + "'";
                OracleCommand cmd = new OracleCommand(search_cmd, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    PurchaseID = dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void ComputerIDDropDown()
        {
            string select_sql = "SELECT ComputerID, ComputerName FROM tblComputers";
            OracleCommand cmd = new OracleCommand(select_sql, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbComputerID.Items.Add(dr["ComputerName"].ToString());
                cbComputerID.DisplayMember = (dr["ComputerName"].ToString());
                cbComputerID.ValueMember = (dr["ComputerID"].ToString());
            }
        }

        string ComputerID;

        private void cbComputerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string search_cmd = "SELECT ComputerID FROM tblComputers WHERE ComputerName = '" + cbComputerID.SelectedItem + "'";
                OracleCommand cmd = new OracleCommand(search_cmd, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ComputerID = dr[0].ToString();
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
                    dgvPurchaseDetail.Enabled = false;
                    ClearField();
                }
                else if (btnCreate.Text == "Save")
                {
                    if (string.IsNullOrEmpty(cbPurchaseID.Text))
                    {
                        MessageBox.Show("Purchase ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbComputerID.Text))
                    {
                        MessageBox.Show("Computer ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtPurchaseQty.Text))
                    {
                        MessageBox.Show("Purchase Qty can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "INSERT INTO tblPurchaseDetails(PurchaseID, ComputerID, PurchaseQty) VALUES(:2, :3, :4)";
                        OracleCommand insert_command = new OracleCommand(sql, conn);
                        insert_command.Parameters.Add(new OracleParameter("2", Int32.Parse(PurchaseID)));
                        insert_command.Parameters.Add(new OracleParameter("3", Int32.Parse(ComputerID)));
                        insert_command.Parameters.Add(new OracleParameter("4", Int32.Parse(txtPurchaseQty.Text)));

                        if (insert_command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("One record has added to Database!", "CREATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnCreate.Text = "Create";
                            btnUpdate.Enabled = true;
                            btnDelete.Text = "Delete";
                            dgvPurchaseDetail.Enabled = true;
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
                if (MessageBox.Show("Are you sure to update, " + cbPurchaseID.Text + "?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(cbPurchaseID.Text))
                    {
                        MessageBox.Show("Purchase ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbComputerID.Text))
                    {
                        MessageBox.Show("Computer ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtPurchaseQty.Text))
                    {
                        MessageBox.Show("Purchase Qty can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "UPDATE tblPurchaseDetails SET PurchaseID = :2, ComputerID = :3, PurchaseQty = :4 WHERE PurchaseDetailID = :1";
                        OracleCommand update_command = new OracleCommand(sql, conn);
                        update_command.Parameters.Add(new OracleParameter("2", cbPurchaseID.Text));
                        update_command.Parameters.Add(new OracleParameter("3", ComputerID));
                        update_command.Parameters.Add(new OracleParameter("4", txtPurchaseQty.Text));
                        update_command.Parameters.Add(new OracleParameter("1", Int32.Parse(cbPurchaseID.Text)));

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
                    dgvPurchaseDetail.Enabled = true;
                }
                else if (btnDelete.Text == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete, " + cbPurchaseID.Text + "?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "DELETE tblPurchaseDetails WHERE PurchaseDetailID = :1";
                        OracleCommand delete_cmd = new OracleCommand(sql, conn);
                        delete_cmd.Parameters.Add(new OracleParameter("1", Int32.Parse(cbPurchaseID.Text)));

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

        private void dgvPurchaseDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnUpdate.Enabled = true;
            //btnDelete.Enabled = true;

            //PurchaseID = dgvPurchaseDetail.CurrentRow.Cells[1].Value.ToString();
            //txtPurchaseID.Text = dgvPurchaseDetail.CurrentRow.Cells[1].Value.ToString();

            //ComputerID = dgvPurchaseDetail.CurrentRow.Cells[2].Value.ToString();
            //cbComputerID.Text = dgvPurchaseDetail.CurrentRow.Cells[2].Value.ToString();

            //txtPurchaseQty.Text = dgvPurchaseDetail.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OracleCommand sql_search = new OracleCommand("SELECT pur.PurchaseID, com.ComputerName, pur.PurchaseQty FROM tblPurchaseDetails pur, tblComputers com WHERE com.ComputerID = pur.ComputerID AND" + " UPPER (pur.PurchaseID || com.ComputerName || pur.PurchaseQty)" + " LIKE UPPER ('%" + txtSearch.Text + "%') ORDER BY pur.PurchaseID ASC", conn);
                OracleDataAdapter adapt = new OracleDataAdapter(sql_search);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                dgvPurchaseDetail.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtPurchaseQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
