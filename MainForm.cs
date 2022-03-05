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

namespace Computer_MGS
{
    public partial class MainForm : Form
    {
        OracleConnection conn;
        bool mouseDown;
        private Point offset;
        private Form activeForm;

        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 35, 35));
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

        private void pnHeader_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void pnHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void pnHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnDesktop.Controls.Add(childForm);
            this.pnDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private bool isSalesCollapsed;

        private void salesDropDownTimer_Tick(object sender, EventArgs e)
        {
            if (isSalesCollapsed)
            {
                btnAboutSales.Image = Resources.collapse_arrow_32px_new;
                pnSalesDropDown.Height += 10;
                if(pnSalesDropDown.Size == pnSalesDropDown.MaximumSize)
                {
                    salesDropDownTimer.Stop();
                    isSalesCollapsed = false;
                }
            }
            else
            {
                btnAboutSales.Image = Resources.expand_arrow_32px;
                pnSalesDropDown.Height -= 10;
                if (pnSalesDropDown.Size == pnSalesDropDown.MinimumSize)
                {
                    salesDropDownTimer.Stop();
                    isSalesCollapsed = true;
                }
            }
        }

        private void btnAboutSales_Click(object sender, EventArgs e)
        {
            salesDropDownTimer.Start();
        }

        private bool isPurchasesCollapsed;

        private void purchasesDropDownTimer_Tick(object sender, EventArgs e)
        {
            if (isPurchasesCollapsed)
            {
                btnAboutPurchases.Image = Resources.collapse_arrow_32px_new;
                pnPurchasesDropDown.Height += 10;
                if (pnPurchasesDropDown.Size == pnPurchasesDropDown.MaximumSize)
                {
                    purchasesDropDownTimer.Stop();
                    isPurchasesCollapsed = false;
                }
            }
            else
            {
                btnAboutPurchases.Image = Resources.expand_arrow_32px;
                pnPurchasesDropDown.Height -= 10;
                if (pnPurchasesDropDown.Size == pnPurchasesDropDown.MinimumSize)
                {
                    purchasesDropDownTimer.Stop();
                    isPurchasesCollapsed = true;
                }
            }
        }

        private void btnAboutPurchases_Click(object sender, EventArgs e)
        {
            purchasesDropDownTimer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DashboardForm(), sender);
            lblStaffName.Text = Classes.UserLogin.getStaffName();
            lblStaffUserType.Text = Classes.UserLogin.getUserType();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DashboardForm(), sender);
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ComputerForm(), sender);
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SaleForm(), sender);
        }

        private void btnSaleDetail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SaleDetailForm(), sender);
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.PurchaseForm(), sender);
        }

        private void btnPurchaseDetail_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.PurchaseDetailForm(), sender);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CategoryForm(), sender);
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MemberForm(), sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.CustomerForm(), sender);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SupplierForm(), sender);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StaffForm(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "You're going to logout this account.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Forms.LoginForm lf = new Forms.LoginForm();
                this.Hide();
                lf.Show();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "You're going to exit this application.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pbMaximize_Click(object sender, EventArgs e)
        {

        }

        private void pbMinimize_Click(object sender, EventArgs e)
        {

        }
    }
}
