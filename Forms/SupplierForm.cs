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
    public partial class SupplierForm : Form
    {
        OracleConnection conn;

        public SupplierForm()
        {
            InitializeComponent();
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = Classes.DBConnection.Connect();
                GenderDropDown();
                JobTitleDropDown();
                AddressDropDown();
                PlaceOfBirthDropDown();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadData()
        {
            string sql = "SELECT * FROM tblSuppliers ORDER BY SupplierID ASC";
            OracleCommand select_cmd = new OracleCommand(sql, conn);
            OracleDataAdapter adapter = new OracleDataAdapter(select_cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvSupplier.DataSource = dt;

            DataGridViewImageColumn imgcolumn = new DataGridViewImageColumn();
            dgvSupplier.RowTemplate.Height = 80;
            imgcolumn = (DataGridViewImageColumn)dgvSupplier.Columns[10];
            imgcolumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgvSupplier.ClearSelection();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        void ClearField()
        {
            txtSupplierID.Text = string.Empty;
            txtSupplierName.Text = string.Empty;
            cbSex.Text = string.Empty;
            dtpDOB.Text = string.Empty;
            cbPOB.Text = string.Empty;
            cbJobTitle.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            cbAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            pbPhoto.Image = Resources.Avatar;
            txtSupplierID.Focus();
        }

        void GenderDropDown()
        {
            List<string> gender = new List<string>();
            gender.Add("Male");
            gender.Add("Female");
            gender.Add("Other");

            foreach (string genderList in gender)
            {
                cbSex.Items.Add(genderList);
            }
        }

        void PlaceOfBirthDropDown()
        {
            List<string> placeOfBirth = new List<string>();
            placeOfBirth.Add("Banteay Meanchey");
            placeOfBirth.Add("Battambang");
            placeOfBirth.Add("Kampong Chan");
            placeOfBirth.Add("Kampong Chnang");
            placeOfBirth.Add("Kampong Speu");
            placeOfBirth.Add("Kampong Thom");
            placeOfBirth.Add("Kampot");
            placeOfBirth.Add("Kandal");
            placeOfBirth.Add("Koh Kong");
            placeOfBirth.Add("Kratie");
            placeOfBirth.Add("Mondulkiri");
            placeOfBirth.Add("Phnom Penh");
            placeOfBirth.Add("Preah Vihear");
            placeOfBirth.Add("Prey Veng");
            placeOfBirth.Add("Pursat");
            placeOfBirth.Add("Ratanak Kiri");
            placeOfBirth.Add("Siem Reap");
            placeOfBirth.Add("Preah Sihanouk");
            placeOfBirth.Add("Steung Treng");
            placeOfBirth.Add("Svay Rieng");
            placeOfBirth.Add("Takeo");
            placeOfBirth.Add("Oddar Meanchey");
            placeOfBirth.Add("Kep");
            placeOfBirth.Add("Pailin");
            placeOfBirth.Add("Tboung Khmumn");

            foreach (string placeOfBirthList in placeOfBirth)
            {
                cbPOB.Items.Add(placeOfBirthList);
            }
        }

        void JobTitleDropDown()
        {
            List<string> jobTitle = new List<string>();
            jobTitle.Add("Admin");
            jobTitle.Add("Accountant");
            jobTitle.Add("Software Developer");
            jobTitle.Add("Web Developer");
            jobTitle.Add("Mobile Developer");

            foreach (string jobTitleList in jobTitle)
            {
                cbJobTitle.Items.Add(jobTitleList);
            }
        }

        void AddressDropDown()
        {
            List<string> Address = new List<string>();
            Address.Add("Banteay Meanchey");
            Address.Add("Battambang");
            Address.Add("Kampong Chan");
            Address.Add("Kampong Chnang");
            Address.Add("Kampong Speu");
            Address.Add("Kampong Thom");
            Address.Add("Kampot");
            Address.Add("Kandal");
            Address.Add("Koh Kong");
            Address.Add("Kratie");
            Address.Add("Mondulkiri");
            Address.Add("Phnom Penh");
            Address.Add("Preah Vihear");
            Address.Add("Prey Veng");
            Address.Add("Pursat");
            Address.Add("Ratanak Kiri");
            Address.Add("Siem Reap");
            Address.Add("Preah Sihanouk");
            Address.Add("Steung Treng");
            Address.Add("Svay Rieng");
            Address.Add("Takeo");
            Address.Add("Oddar Meanchey");
            Address.Add("Kep");
            Address.Add("Pailin");
            Address.Add("Tboung Khmumn");

            foreach (string addressList in Address)
            {
                cbAddress.Items.Add(addressList);
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
            pbPhoto.Image = Resources.Avatar;
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
                    dgvSupplier.Enabled = false;
                    ClearField();
                }
                else if (btnCreate.Text == "Save")
                {
                    if (string.IsNullOrEmpty(txtSupplierName.Text))
                    {
                        MessageBox.Show("Supplier Name can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbSex.Text))
                    {
                        MessageBox.Show("Gender can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(dtpDOB.Text))
                    {
                        MessageBox.Show("Date of Birth can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbPOB.Text))
                    {
                        MessageBox.Show("Place of Birth can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbJobTitle.Text))
                    {
                        MessageBox.Show("Job Title can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtCompanyName.Text))
                    {
                        MessageBox.Show("Company Name can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbAddress.Text))
                    {
                        MessageBox.Show("Address can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtPhone.Text))
                    {
                        MessageBox.Show("Phone can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtEmail.Text))
                    {
                        MessageBox.Show("Email can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "INSERT INTO tblSuppliers(SupplierName, Sex, DOB, POB, JobTitle, CompanyName, Address, Phone, Email, Photo) VALUES(:2, :3, :4, :5, :6, :7, :8, :9, :10, :11)";
                        OracleCommand insert_command = new OracleCommand(sql, conn);
                        insert_command.Parameters.Add(new OracleParameter("2", txtSupplierName.Text));
                        insert_command.Parameters.Add(new OracleParameter("3", cbSex.Text));
                        insert_command.Parameters.Add(new OracleParameter("4", dtpDOB.Text));
                        insert_command.Parameters.Add(new OracleParameter("5", cbPOB.Text));
                        insert_command.Parameters.Add(new OracleParameter("6", cbJobTitle.Text));
                        insert_command.Parameters.Add(new OracleParameter("7", txtCompanyName.Text));
                        insert_command.Parameters.Add(new OracleParameter("8", cbAddress.Text));
                        insert_command.Parameters.Add(new OracleParameter("9", txtPhone.Text));
                        insert_command.Parameters.Add(new OracleParameter("10", txtEmail.Text));

                        MemoryStream ms = new MemoryStream();
                        pbPhoto.Image.Save(ms, pbPhoto.Image.RawFormat);
                        insert_command.Parameters.Add(new OracleParameter("11", OracleDbType.Blob)).Value = ms.ToArray();

                        if (insert_command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("One record has added to Database!", "CREATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnCreate.Text = "Create";
                            btnUpdate.Enabled = true;
                            btnDelete.Text = "Delete";
                            dgvSupplier.Enabled = true;
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
                if (MessageBox.Show("Are you sure to update, " + txtSupplierName.Text + "?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtSupplierID.Text))
                    {
                        MessageBox.Show("Student ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtSupplierName.Text))
                    {
                        MessageBox.Show("Student Name can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbSex.Text))
                    {
                        MessageBox.Show("Gender can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(dtpDOB.Text))
                    {
                        MessageBox.Show("Date of Birth can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbPOB.Text))
                    {
                        MessageBox.Show("Place of Birth can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbJobTitle.Text))
                    {
                        MessageBox.Show("Address can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtCompanyName.Text))
                    {
                        MessageBox.Show("Company Name can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbAddress.Text))
                    {
                        MessageBox.Show("Address can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtPhone.Text))
                    {
                        MessageBox.Show("Phone can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtEmail.Text))
                    {
                        MessageBox.Show("Email can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "UPDATE tblSuppliers SET SupplierName = :2, Sex = :3, DOB = :4, POB = :5, JobTitle = :6, CompanyName = :7, Address = :8, Phone = :9, Email = :10, Photo = :11 WHERE SupplierID = :1";
                        OracleCommand update_command = new OracleCommand(sql, conn);
                        update_command.Parameters.Add(new OracleParameter("2", txtSupplierName.Text));
                        update_command.Parameters.Add(new OracleParameter("3", cbSex.Text));
                        update_command.Parameters.Add(new OracleParameter("4", dtpDOB.Text));
                        update_command.Parameters.Add(new OracleParameter("5", cbPOB.Text));
                        update_command.Parameters.Add(new OracleParameter("6", cbJobTitle.Text));
                        update_command.Parameters.Add(new OracleParameter("7", txtCompanyName.Text));
                        update_command.Parameters.Add(new OracleParameter("8", cbAddress.Text));
                        update_command.Parameters.Add(new OracleParameter("9", txtPhone.Text));
                        update_command.Parameters.Add(new OracleParameter("10", txtEmail.Text));

                        MemoryStream ms = new MemoryStream();
                        pbPhoto.Image.Save(ms, pbPhoto.Image.RawFormat);
                        update_command.Parameters.Add(new OracleParameter("11", OracleDbType.Blob)).Value = ms.ToArray();

                        update_command.Parameters.Add(new OracleParameter("1", txtSupplierID.Text));

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
                    dgvSupplier.Enabled = true;
                }
                else if (btnDelete.Text == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete, " + txtSupplierName.Text + "?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "DELETE tblSuppliers WHERE SupplierID = :1";
                        OracleCommand delete_cmd = new OracleCommand(sql, conn);
                        delete_cmd.Parameters.Add(new OracleParameter("1", txtSupplierID.Text));

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

        private void dgvSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            txtSupplierID.Text = dgvSupplier.CurrentRow.Cells[0].Value.ToString();
            txtSupplierName.Text = dgvSupplier.CurrentRow.Cells[1].Value.ToString();
            cbSex.Text = dgvSupplier.CurrentRow.Cells[2].Value.ToString();
            dtpDOB.Text = dgvSupplier.CurrentRow.Cells[3].Value.ToString();
            cbPOB.Text = dgvSupplier.CurrentRow.Cells[4].Value.ToString();
            cbJobTitle.Text = dgvSupplier.CurrentRow.Cells[5].Value.ToString();
            txtCompanyName.Text = dgvSupplier.CurrentRow.Cells[6].Value.ToString();
            cbAddress.Text = dgvSupplier.CurrentRow.Cells[7].Value.ToString();
            txtPhone.Text = dgvSupplier.CurrentRow.Cells[8].Value.ToString();
            txtEmail.Text = dgvSupplier.CurrentRow.Cells[9].Value.ToString();

            //get and show image
            byte[] img = (byte[])dgvSupplier.CurrentRow.Cells[10].Value;
            MemoryStream ms = new MemoryStream(img);
            pbPhoto.Image = Image.FromStream(ms);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OracleCommand sql_search = new OracleCommand("SELECT * FROM tblSuppliers WHERE" + " UPPER (SupplierID || SupplierName || Sex || DOB || POB || JobTitle || CompanyName || Address || Phone || Email)" + " LIKE UPPER ('%" + txtSearch.Text + "%') ORDER BY SupplierID ASC", conn);
                OracleDataAdapter adapt = new OracleDataAdapter(sql_search);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                dgvSupplier.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
