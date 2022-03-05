using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Oracle.ManagedDataAccess.Client;
using Computer_MGS.Properties;

namespace Computer_MGS.Forms
{
    public partial class LoginForm : Form
    {
        OracleConnection conn;

        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 50, 50));
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = Classes.DBConnection.Connect();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text))
                {
                    MessageBox.Show("Please enter username", "Require Username", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsername.Focus();
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Please enter password", "Require Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPassword.Focus();
                }
                else
                {
                    string sql = "SELECT * FROM tblStaff WHERE USERNAME = '" + txtUsername.Text + "' AND USERPASSWORD = '" + txtPassword.Text + "'";
                    OracleDataAdapter adapter = new OracleDataAdapter(sql, conn);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);
                    if (dt.Rows.Count == 1)
                    {
                        //Invoke class from UserLogin Class
                        //Save User Login Info
                        Classes.UserLogin.setStaffID(dt.Rows[0]["StaffID"].ToString());
                        Classes.UserLogin.setStaffName(dt.Rows[0]["StaffName"].ToString());
                        Classes.UserLogin.setUserType(dt.Rows[0]["UserType"].ToString());

                        //Show MainForm
                        MainForm frm = new MainForm();
                        this.Hide();
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Wrong credential!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact your system administator! Tel: 099 961 656 (Lorn Sovannra)", "FORGOT PASSWORD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "You're going to exit this application.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        bool mouseDown;
        private Point offset;

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnShowHidePassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShowHidePassword.Image = Resources.invisible_24px_new;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShowHidePassword.Image = Resources.visible_24px_new;
            }
        }
    }
}
