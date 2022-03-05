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
    public partial class SaleForm : Form
    {
        OracleConnection conn;

        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = Classes.DBConnection.Connect();
                LoadData();
                CustomerIDDropDown();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadData()
        {
            string sql = "SELECT sa.SaleID, st.StaffName, cu.CustomerName, sa.SalesDate FROM tblSales sa, tblStaff st, tblCustomers cu WHERE st.StaffID = sa.StaffID AND cu.CustomerID = sa.CustomerID ORDER BY SaleID ASC";
            OracleCommand select_cmd = new OracleCommand(sql, conn);
            OracleDataAdapter adapter = new OracleDataAdapter(select_cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvSale.DataSource = dt;

            dgvSale.ClearSelection();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        void ClearField()
        {
            txtSaleID.Text = string.Empty;
            txtStaffID.Text = string.Empty;
            cbCustomerID.Text = string.Empty;
            dtpSaleDate.Text = string.Empty;
            txtSaleID.Focus();
        }

        void CustomerIDDropDown()
        {
            string select_sql = "SELECT CustomerID, CustomerName FROM tblCustomers";
            OracleCommand cmd = new OracleCommand(select_sql, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbCustomerID.Items.Add(dr["CustomerName"].ToString());
                cbCustomerID.DisplayMember = (dr["CustomerName"].ToString());
                cbCustomerID.ValueMember = (dr["CustomerID"].ToString());
            }
        }

        string CustomerID;

        private void cbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string search_cmd = "SELECT CustomerID FROM tblCustomers WHERE CustomerName = '" + cbCustomerID.SelectedItem + "'";
                OracleCommand cmd = new OracleCommand(search_cmd, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CustomerID = dr[0].ToString();
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
                    dgvSale.Enabled = false;
                    ClearField();
                }
                else if (btnCreate.Text == "Save")
                {
                    if (string.IsNullOrEmpty(cbCustomerID.Text))
                    {
                        MessageBox.Show("Customer ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(dtpSaleDate.Text))
                    {
                        MessageBox.Show("Sales Date can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "INSERT INTO tblSales(StaffID, CustomerID, SalesDate) VALUES(:2, :3, :4)";
                        OracleCommand insert_command = new OracleCommand(sql, conn);
                        insert_command.Parameters.Add(new OracleParameter("2", /*Classes.UserLogin.getStaffID()*/"Admin"));
                        insert_command.Parameters.Add(new OracleParameter("3", Int32.Parse(CustomerID)));
                        insert_command.Parameters.Add(new OracleParameter("4", dtpSaleDate.Text));

                        if (insert_command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("One record has added to Database!", "CREATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnCreate.Text = "Create";
                            btnUpdate.Enabled = true;
                            btnDelete.Text = "Delete";
                            dgvSale.Enabled = true;
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
                if (MessageBox.Show("Are you sure to update, " + txtSaleID.Text + "?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtSaleID.Text))
                    {
                        MessageBox.Show("Sale ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbCustomerID.Text))
                    {
                        MessageBox.Show("Customer ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(dtpSaleDate.Text))
                    {
                        MessageBox.Show("Sales Date can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "UPDATE tblSales SET StaffID = :2, CustomerID = :3, SalesDate = :4 WHERE SaleID = :1";
                        OracleCommand update_command = new OracleCommand(sql, conn);
                        update_command.Parameters.Add(new OracleParameter("2", /*Classes.UserLogin.getStaffID()*/"Admin"));
                        update_command.Parameters.Add(new OracleParameter("3", Int32.Parse(CustomerID)));
                        update_command.Parameters.Add(new OracleParameter("4", dtpSaleDate.Text));
                        update_command.Parameters.Add(new OracleParameter("1", Int32.Parse(txtSaleID.Text)));

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
                    dgvSale.Enabled = true;
                }
                else if (btnDelete.Text == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete, " + txtSaleID.Text + "?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "DELETE tblSales WHERE SaleID = :1";
                        OracleCommand delete_cmd = new OracleCommand(sql, conn);
                        delete_cmd.Parameters.Add(new OracleParameter("1", Int32.Parse(txtSaleID.Text)));

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
            ReportForms.SaleReportForm f = new ReportForms.SaleReportForm();
            f.ShowDialog();
        }

        private void dgvSale_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            txtSaleID.Text = dgvSale.CurrentRow.Cells[0].Value.ToString();
            txtStaffID.Text = dgvSale.CurrentRow.Cells[1].Value.ToString();
            cbCustomerID.Text = dgvSale.CurrentRow.Cells[2].Value.ToString();
            dtpSaleDate.Text = dgvSale.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OracleCommand sql_search = new OracleCommand("SELECT sa.SaleID, st.StaffName, cu.CustomerName, sa.SalesDate FROM tblSales sa, tblStaff st, tblCustomers cu WHERE st.StaffID = sa.StaffID AND cu.CustomerID = sa.CustomerID AND" + " UPPER (sa.SaleID || st.StaffName || cu.CustomerName || sa.SalesDate)" + " LIKE UPPER ('%" + txtSearch.Text + "%') ORDER BY SaleID ASC", conn);
                OracleDataAdapter adapt = new OracleDataAdapter(sql_search);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                dgvSale.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
