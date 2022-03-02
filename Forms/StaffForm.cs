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
    public partial class StaffForm : Form
    {
        OracleConnection conn;

        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = Classes.DBConnection.Connect();
                GenderDropDown();
                JobTitleDropDown();
                AddressDropDown();
                PlaceOfBirthDropDown();
                UserTypeDropDown();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void LoadData()
        {
            string sql = "SELECT * FROM tblStaff ORDER BY StaffID ASC";
            OracleCommand select_cmd = new OracleCommand(sql, conn);
            OracleDataAdapter adapter = new OracleDataAdapter(select_cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvStaff.DataSource = dt;

            DataGridViewImageColumn imgcolumn = new DataGridViewImageColumn();
            dgvStaff.RowTemplate.Height = 80;
            imgcolumn = (DataGridViewImageColumn)dgvStaff.Columns[9];
            imgcolumn.ImageLayout = DataGridViewImageCellLayout.Zoom;

            dgvStaff.ClearSelection();
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        void ClearField()
        {
            txtStaffID.Text = string.Empty;
            txtStaffName.Text = string.Empty;
            cbSex.Text = string.Empty;
            dtpDOB.Text = string.Empty;
            cbPOB.Text = string.Empty;
            cbJobTitle.Text = string.Empty;
            cbAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
            pbPhoto.Image = Resources.Avatar;
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtStaffID.Focus();
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

        void UserTypeDropDown()
        {
            List<string> UserType = new List<string>();
            UserType.Add("Admin");
            UserType.Add("User");

            foreach (string UserTypeList in UserType)
            {
                cbUserType.Items.Add(UserTypeList);
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
                    dgvStaff.Enabled = false;
                    ClearField();
                }
                else if (btnCreate.Text == "Save")
                {
                    if (string.IsNullOrEmpty(txtStaffID.Text))
                    {
                        MessageBox.Show("Student ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtStaffName.Text))
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
                        MessageBox.Show("Job Title can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    else if (string.IsNullOrEmpty(txtUsername.Text))
                    {
                        MessageBox.Show("Username can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("Password can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbUserType.Text))
                    {
                        MessageBox.Show("User Type can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "INSERT INTO tblStaff(StaffID, StaffName, Sex, DOB, POB, JobTitle, Address, Phone, Email, Photo, UserName, UserPassword, UserType) VALUES(:1, :2, :3, :4, :5, :6, :7, :8, :9, :10, :11, :12, :13)";
                        OracleCommand insert_command = new OracleCommand(sql, conn);
                        insert_command.Parameters.Add(new OracleParameter("1", txtStaffID.Text));
                        insert_command.Parameters.Add(new OracleParameter("2", txtStaffName.Text));
                        insert_command.Parameters.Add(new OracleParameter("3", cbSex.Text));
                        insert_command.Parameters.Add(new OracleParameter("4", dtpDOB.Text));
                        insert_command.Parameters.Add(new OracleParameter("5", cbPOB.Text));
                        insert_command.Parameters.Add(new OracleParameter("6", cbJobTitle.Text));
                        insert_command.Parameters.Add(new OracleParameter("7", cbAddress.Text));
                        insert_command.Parameters.Add(new OracleParameter("8", txtPhone.Text));
                        insert_command.Parameters.Add(new OracleParameter("9", txtEmail.Text));

                        MemoryStream ms = new MemoryStream();
                        pbPhoto.Image.Save(ms, pbPhoto.Image.RawFormat);
                        insert_command.Parameters.Add(new OracleParameter("10", OracleDbType.Blob)).Value = ms.ToArray();

                        insert_command.Parameters.Add(new OracleParameter("11", txtUsername.Text));
                        insert_command.Parameters.Add(new OracleParameter("12", txtPassword.Text));
                        insert_command.Parameters.Add(new OracleParameter("13", cbUserType.Text));

                        if (insert_command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("One record has added to Database!", "CREATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnCreate.Text = "Create";
                            btnUpdate.Enabled = true;
                            btnDelete.Text = "Delete";
                            dgvStaff.Enabled = true;
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
                if (MessageBox.Show("Are you sure to update, " + txtStaffName.Text + "?", "UPDATE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtStaffID.Text))
                    {
                        MessageBox.Show("Student ID can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtStaffName.Text))
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
                    else if (string.IsNullOrEmpty(cbAddress.Text))
                    {
                        MessageBox.Show("Phone can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtPhone.Text))
                    {
                        MessageBox.Show("Email can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtEmail.Text))
                    {
                        MessageBox.Show("Email can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtUsername.Text))
                    {
                        MessageBox.Show("Email can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(txtPassword.Text))
                    {
                        MessageBox.Show("Email can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (string.IsNullOrEmpty(cbUserType.Text))
                    {
                        MessageBox.Show("User Type can't not be blank!", "EMPTY FIELD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        string sql = "UPDATE tblStaff SET StaffName = :2, Sex = :3, DOB = :4, POB = :5, JobTitle = :6, Address = :7, Phone = :8, Email = :9, Photo = :10, UserName = :11, UserPassword = :12, UserType = :13 WHERE StaffID = :1";
                        OracleCommand update_command = new OracleCommand(sql, conn);
                        update_command.Parameters.Add(new OracleParameter("2", txtStaffName.Text));
                        update_command.Parameters.Add(new OracleParameter("3", cbSex.Text));
                        update_command.Parameters.Add(new OracleParameter("4", dtpDOB.Text));
                        update_command.Parameters.Add(new OracleParameter("5", cbPOB.Text));
                        update_command.Parameters.Add(new OracleParameter("6", cbJobTitle.Text));
                        update_command.Parameters.Add(new OracleParameter("7", cbAddress.Text));
                        update_command.Parameters.Add(new OracleParameter("8", txtPhone.Text));
                        update_command.Parameters.Add(new OracleParameter("9", txtEmail.Text));

                        MemoryStream ms = new MemoryStream();
                        pbPhoto.Image.Save(ms, pbPhoto.Image.RawFormat);
                        update_command.Parameters.Add(new OracleParameter("10", OracleDbType.Blob)).Value = ms.ToArray();

                        update_command.Parameters.Add(new OracleParameter("11", txtUsername.Text));
                        update_command.Parameters.Add(new OracleParameter("12", txtPassword.Text));
                        update_command.Parameters.Add(new OracleParameter("13", cbUserType.Text));
                        update_command.Parameters.Add(new OracleParameter("1", txtStaffID.Text));

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
                    dgvStaff.Enabled = true;
                }
                else if (btnDelete.Text == "Delete")
                {
                    if (MessageBox.Show("Are you sure to delete, " + txtStaffName.Text + "?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string sql = "DELETE tblStaff WHERE StaffID = :1";
                        OracleCommand delete_cmd = new OracleCommand(sql, conn);
                        delete_cmd.Parameters.Add(new OracleParameter("1", txtStaffID.Text));

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

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            txtStaffID.Text = dgvStaff.CurrentRow.Cells[0].Value.ToString();
            txtStaffName.Text = dgvStaff.CurrentRow.Cells[1].Value.ToString();
            cbSex.Text = dgvStaff.CurrentRow.Cells[2].Value.ToString();
            dtpDOB.Text = dgvStaff.CurrentRow.Cells[3].Value.ToString();
            cbPOB.Text = dgvStaff.CurrentRow.Cells[4].Value.ToString();
            cbJobTitle.Text = dgvStaff.CurrentRow.Cells[5].Value.ToString();
            cbAddress.Text = dgvStaff.CurrentRow.Cells[6].Value.ToString();
            txtPhone.Text = dgvStaff.CurrentRow.Cells[7].Value.ToString();
            txtEmail.Text = dgvStaff.CurrentRow.Cells[8].Value.ToString();

            //get and show image
            byte[] img = (byte[])dgvStaff.CurrentRow.Cells[9].Value;
            MemoryStream ms = new MemoryStream(img);
            pbPhoto.Image = Image.FromStream(ms);

            txtUsername.Text = dgvStaff.CurrentRow.Cells[10].Value.ToString();
            txtPassword.Text = dgvStaff.CurrentRow.Cells[11].Value.ToString();
            cbUserType.Text = dgvStaff.CurrentRow.Cells[12].Value.ToString();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                OracleCommand sql_search = new OracleCommand("SELECT * FROM tblStaff WHERE" + " UPPER (StaffID || StaffName || Sex || DOB || POB || JobTitle || Address || Phone || Email)" + " LIKE UPPER ('%" + txtSearch.Text + "%') ORDER BY StaffID ASC", conn);
                OracleDataAdapter adapt = new OracleDataAdapter(sql_search);
                DataTable dt = new DataTable();
                adapt.Fill(dt);

                dgvStaff.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
