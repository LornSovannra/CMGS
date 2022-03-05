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
using System.IO;
using Computer_MGS.Properties;

namespace Computer_MGS.Forms
{
    public partial class ComputerForm : Form
    {
        OracleConnection conn;

        public ComputerForm()
        {
            InitializeComponent();
        }

        private void ComputerForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = Classes.DBConnection.Connect();
                LoadData();
                CategoryIDDropDown();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadData()
        {
            string sql = "SELECT com.ComputerID, com.ComputerName, com.Description, cat.CategoryName, com.Qty, com.UnitPriceIn, com.UnitPriceOut, com.Photo FROM tblComputers com, tblCategories cat WHERE cat.CategoryID = com.CategoryID ORDER BY com.ComputerID ASC";
            OracleCommand select_cmd = new OracleCommand(sql, conn);
            OracleDataAdapter adapter = new OracleDataAdapter(select_cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvComputer.DataSource = dt;

            DataGridViewImageColumn imgcolumn = new DataGridViewImageColumn();
            dgvComputer.RowTemplate.Height = 80;
            imgcolumn = (DataGridViewImageColumn)dgvComputer.Columns[7];
            imgcolumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgvComputer.ClearSelection();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        void ClearField()
        {
            txtComputerID.Text = string.Empty;
            txtComputerName.Text = string.Empty;
            rtbDescription.Text = string.Empty;
            cbCategoryID.Text = string.Empty;
            txtQty.Text = string.Empty;
            txtUnitPriceIn.Text = string.Empty;
            txtUnitPriceOut.Text = string.Empty;
            pbPhoto.Image = Resources.computer_default_photo;
            txtComputerID.Focus();
        }

        void CategoryIDDropDown()
        {
            string select_sql = "SELECT CategoryID, CategoryName FROM tblCategories";
            OracleCommand cmd = new OracleCommand(select_sql, conn);
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                cbCategoryID.Items.Add(dr["CategoryName"].ToString());
                cbCategoryID.DisplayMember = (dr["CategoryName"].ToString());
                cbCategoryID.ValueMember = (dr["CategoryID"].ToString());
            }
        }

        string CategoryID;

        private void cbCategoryID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string search_cmd = "SELECT CategoryID FROM tblCategories WHERE CategoryName = '" + cbCategoryID.SelectedItem + "'";
                OracleCommand cmd = new OracleCommand(search_cmd, conn);
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    CategoryID = dr[0].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            ofdPhoto.FilterIndex = 4;
            ofdPhoto.Filter = ("Images | *.png; *.jpg; *.jpeg; *.bmp;");
            ofdPhoto.FileName = string.Empty;

            //get image and show back in openFileDialog
            if (ofdPhoto.ShowDialog() == DialogResult.OK)
            {
                pbPhoto.Image = Image.FromFile(ofdPhoto.FileName);
            }
        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            ofdPhoto.FilterIndex = 4;
            ofdPhoto.Filter = ("Images | *.png; *.jpg; *.jpeg; *.bmp;");
            ofdPhoto.FileName = string.Empty;

            //get image and show back in openFileDialog
            if (ofdPhoto.ShowDialog() == DialogResult.OK)
            {
                pbPhoto.Image = Image.FromFile(ofdPhoto.FileName);
            }
        }

        private void btnRemovePhoto_Click(object sender, EventArgs e)
        {
            pbPhoto.Image = Resources.computer_default_photo;
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
                    dgvComputer.Enabled = false;
                    ClearField();
                }
                else if (btnCreate.Text == "Save")
                {
                    if (string.IsNullOrEmpty(txtComputerName.Text))
                    {
                        MessageBox.Show("Computer Name can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbCategoryID.Text))
                    {
                        MessageBox.Show("Category ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtQty.Text))
                    {
                        MessageBox.Show("Quantity can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtUnitPriceIn.Text))
                    {
                        MessageBox.Show("Unit Price In can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtUnitPriceOut.Text))
                    {
                        MessageBox.Show("Unit Price Out can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "INSERT INTO tblComputers(ComputerName, Description, CategoryID, Qty, UnitPriceIn, UnitPriceOut, Photo) VALUES(:2, :3, :4, :5, :6, :7, :8)";
                        OracleCommand insert_command = new OracleCommand(sql, conn);
                        insert_command.Parameters.Add(new OracleParameter("2", txtComputerName.Text));
                        insert_command.Parameters.Add(new OracleParameter("3", rtbDescription.Text));
                        insert_command.Parameters.Add(new OracleParameter("4", Int32.Parse(CategoryID)));
                        insert_command.Parameters.Add(new OracleParameter("5", txtQty.Text));
                        insert_command.Parameters.Add(new OracleParameter("6", txtUnitPriceIn.Text));
                        insert_command.Parameters.Add(new OracleParameter("7", txtUnitPriceOut.Text));

                        MemoryStream ms = new MemoryStream();
                        pbPhoto.Image.Save(ms, pbPhoto.Image.RawFormat);
                        insert_command.Parameters.Add(new OracleParameter("8", OracleDbType.Blob)).Value = ms.ToArray();

                        if (insert_command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("One record has added to Database!", "CREATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnCreate.Text = "Create";
                            btnUpdate.Enabled = true;
                            btnDelete.Text = "Delete";
                            dgvComputer.Enabled = true;
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
                if (MessageBox.Show("Are you sure to update, " + txtComputerName.Text + "?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtComputerID.Text))
                    {
                        MessageBox.Show("Computer ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtComputerName.Text))
                    {
                        MessageBox.Show("Computer Name can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbCategoryID.Text))
                    {
                        MessageBox.Show("Category ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtQty.Text))
                    {
                        MessageBox.Show("Quantity can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtUnitPriceIn.Text))
                    {
                        MessageBox.Show("Unit Price In can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtUnitPriceOut.Text))
                    {
                        MessageBox.Show("Unit Price Out can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "UPDATE tblComputers SET ComputerName = :2, Description = :3, CategoryID = :4, Qty = :5, UnitPriceIn = :6, UnitPriceOut = :7, Photo = :8 WHERE ComputerID = :1";
                        OracleCommand update_command = new OracleCommand(sql, conn);
                        update_command.Parameters.Add(new OracleParameter("2", txtComputerName.Text));
                        update_command.Parameters.Add(new OracleParameter("3", rtbDescription.Text));
                        update_command.Parameters.Add(new OracleParameter("4", Int32.Parse(CategoryID)));
                        update_command.Parameters.Add(new OracleParameter("5", txtQty.Text));
                        update_command.Parameters.Add(new OracleParameter("6", txtUnitPriceIn.Text));
                        update_command.Parameters.Add(new OracleParameter("7", txtUnitPriceOut.Text));

                        MemoryStream ms = new MemoryStream();
                        pbPhoto.Image.Save(ms, pbPhoto.Image.RawFormat);
                        update_command.Parameters.Add(new OracleParameter("8", OracleDbType.Blob)).Value = ms.ToArray();

                        update_command.Parameters.Add(new OracleParameter("1", txtComputerID.Text));

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
                    dgvComputer.Enabled = true;
                }
                else if (btnDelete.Text == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete, " + txtComputerName.Text + "?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "DELETE tblComputers WHERE ComputerID = :1";
                        OracleCommand delete_cmd = new OracleCommand(sql, conn);
                        delete_cmd.Parameters.Add(new OracleParameter("1", txtComputerID.Text));

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
            ReportForms.ComputerReportForm f = new ReportForms.ComputerReportForm();
            f.ShowDialog();
        }

        private void dgvComputer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            txtComputerID.Text = dgvComputer.CurrentRow.Cells[0].Value.ToString();
            txtComputerName.Text = dgvComputer.CurrentRow.Cells[1].Value.ToString();
            rtbDescription.Text = dgvComputer.CurrentRow.Cells[2].Value.ToString();
            cbCategoryID.Text = dgvComputer.CurrentRow.Cells[3].Value.ToString();
            txtQty.Text = dgvComputer.CurrentRow.Cells[4].Value.ToString();
            txtUnitPriceIn.Text = dgvComputer.CurrentRow.Cells[5].Value.ToString();
            txtUnitPriceOut.Text = dgvComputer.CurrentRow.Cells[6].Value.ToString();

            //get and show image
            byte[] img = (byte[])dgvComputer.CurrentRow.Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pbPhoto.Image = Image.FromStream(ms);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OracleCommand sql_search = new OracleCommand("SELECT com.ComputerID, com.ComputerName, com.Description, cat.CategoryName, com.Qty, com.UnitPriceIn, com.UnitPriceOut, com.Photo FROM tblComputers com, tblCategories cat WHERE cat.CategoryID = com.CategoryID AND" + " UPPER (com.ComputerID || com.ComputerName || com.Description || cat.CategoryName || com.Qty || com.UnitPriceIn || com.UnitPriceOut)" + " LIKE UPPER ('%" + txtSearch.Text + "%') ORDER BY ComputerID ASC", conn);
                OracleDataAdapter adapt = new OracleDataAdapter(sql_search);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                dgvComputer.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtUnitPriceIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void txtUnitPriceOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
