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
    public partial class SaleDetailForm : Form
    {
        OracleConnection conn;

        public SaleDetailForm()
        {
            InitializeComponent();
        }

        private void SaleDetailForm_Load(object sender, EventArgs e)
        {
            conn = Classes.DBConnection.Connect();
            SaleIDDropDown();
            ComputerIDDropDown();
            LoadData();
        }

        void LoadData()
        {
            string sql = "SELECT sd.SaleID, com.ComputerName, sd.QtySales, sd.Discount, sd.Remark FROM tblSaleDetails sd, tblComputers com WHERE com.ComputerID = sd.ComputerID ORDER BY sd.SaleID ASC";
            OracleCommand select_cmd = new OracleCommand(sql, conn);
            OracleDataAdapter adapter = new OracleDataAdapter(select_cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvSaleDetail.DataSource = dt;

            dgvSaleDetail.ClearSelection();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        void ClearField()
        {
            cbSaleID.Text = string.Empty;
            cbComputerID.Text = string.Empty;
            txtQtySales.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            rtbRemark.Text = string.Empty;
            cbSaleID.Focus();
        }

        void SaleIDDropDown()
        {
            string select_sql = "SELECT SaleID FROM tblSales";
            OracleCommand cmd = new OracleCommand(select_sql, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbSaleID.Items.Add(dr["SaleID"].ToString());
                cbSaleID.DisplayMember = (dr["SaleID"].ToString());
                cbSaleID.ValueMember = (dr["SaleID"].ToString());
            }
        }

        string SaleID;

        private void cbSaleID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string search_cmd = "SELECT SaleID FROM tblSales WHERE SaleID = '" + cbSaleID.SelectedItem + "'";
                OracleCommand cmd = new OracleCommand(search_cmd, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    SaleID = dr[0].ToString();
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
                    dgvSaleDetail.Enabled = false;
                    ClearField();
                }
                else if (btnCreate.Text == "Save")
                {
                    if (string.IsNullOrEmpty(cbSaleID.Text))
                    {
                        MessageBox.Show("Sale ID Name can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbComputerID.Text))
                    {
                        MessageBox.Show("Computer ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtQtySales.Text))
                    {
                        MessageBox.Show("Qty Sales can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtDiscount.Text))
                    {
                        MessageBox.Show("Discount can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "INSERT INTO tblSaleDetails(SaleID, ComputerID, QtySales, Discount, Remark) VALUES(:2, :3, :4, :5, :6)";
                        OracleCommand insert_command = new OracleCommand(sql, conn);
                        insert_command.Parameters.Add(new OracleParameter("2", SaleID));
                        insert_command.Parameters.Add(new OracleParameter("3", ComputerID));
                        insert_command.Parameters.Add(new OracleParameter("4", Int32.Parse(txtQtySales.Text)));
                        insert_command.Parameters.Add(new OracleParameter("5", txtDiscount.Text));
                        insert_command.Parameters.Add(new OracleParameter("6", rtbRemark.Text));

                        if (insert_command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("One record has added to Database!", "CREATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnCreate.Text = "Create";
                            btnUpdate.Enabled = true;
                            btnDelete.Text = "Delete";
                            dgvSaleDetail.Enabled = true;
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

        string CurrentSaleID;
        string CurrentComputerID;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure to update Sale Detail with SaleID: " + cbSaleID.Text + " and ComputerName: " + cbComputerID.Text + "?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(cbSaleID.Text))
                    {
                        MessageBox.Show("Sale ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbComputerID.Text))
                    {
                        MessageBox.Show("Computer ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtQtySales.Text))
                    {
                        MessageBox.Show("Qty Sales can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtDiscount.Text))
                    {
                        MessageBox.Show("Discount can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "UPDATE tblSaleDetails SET SaleID = :3, ComputerID = :4, QtySales = :5, Discount = :6, Remark = :7 WHERE SaleID = :1 AND ComputerID = :2";
                        OracleCommand update_command = new OracleCommand(sql, conn);
                        update_command.Parameters.Add(new OracleParameter("3", Int32.Parse(SaleID)));
                        update_command.Parameters.Add(new OracleParameter("4", Int32.Parse(ComputerID)));
                        update_command.Parameters.Add(new OracleParameter("5", Int32.Parse(txtQtySales.Text)));
                        update_command.Parameters.Add(new OracleParameter("6", Decimal.Parse(txtDiscount.Text)));
                        update_command.Parameters.Add(new OracleParameter("7", rtbRemark.Text));
                        update_command.Parameters.Add(new OracleParameter("1", Int32.Parse(CurrentSaleID)));
                        update_command.Parameters.Add(new OracleParameter("2", Int32.Parse(CurrentComputerID)));

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
                    dgvSaleDetail.Enabled = true;
                }
                else if (btnDelete.Text == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete Sale Detail with SaleID: " + cbSaleID.Text + " and ComputerName: " + cbComputerID.Text + "?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "DELETE tblSaleDetails WHERE SaleID = :1 AND ComputerID = :2";
                        OracleCommand delete_cmd = new OracleCommand(sql, conn);
                        delete_cmd.Parameters.Add(new OracleParameter("1", Int32.Parse(SaleID)));
                        delete_cmd.Parameters.Add(new OracleParameter("2", Int32.Parse(ComputerID)));

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

        private void dgvSaleDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            SaleID = dgvSaleDetail.CurrentRow.Cells[0].Value.ToString();
            cbSaleID.Text = SaleID;
            //cbSaleID.Text = dgvSaleDetail.CurrentRow.Cells[0].Value.ToString();

            ComputerID = dgvSaleDetail.CurrentRow.Cells[1].Value.ToString();
            cbComputerID.Text = ComputerID;
            //cbComputerID.Text = dgvSaleDetail.CurrentRow.Cells[1].Value.ToString();

            txtQtySales.Text = dgvSaleDetail.CurrentRow.Cells[2].Value.ToString();
            txtDiscount.Text = dgvSaleDetail.CurrentRow.Cells[3].Value.ToString();
            rtbRemark.Text = dgvSaleDetail.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OracleCommand sql_search = new OracleCommand("SELECT sd.SaleID, com.ComputerName, sd.QtySales, sd.Discount, sd.Remark FROM tblSaleDetails sd, tblComputers com WHERE com.ComputerID = sd.ComputerID AND" + " UPPER (sd.SaleID || com.ComputerName || sd.QtySales || sd.Discount || sd.Remark)" + " LIKE UPPER ('%" + txtSearch.Text + "%') ORDER BY SaleID ASC", conn);
                OracleDataAdapter adapt = new OracleDataAdapter(sql_search);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                dgvSaleDetail.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtQtySales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
