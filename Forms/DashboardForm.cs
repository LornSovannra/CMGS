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
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        OracleConnection conn;

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                conn = Classes.DBConnection.Connect();
                lblDate.Text = DateTime.Now.ToString("D");

                OracleCommand sql_select_computers = new OracleCommand("SELECT SUM(Qty) AS TotalQty FROM tblComputers", conn);
                OracleDataAdapter adapt_computers = new OracleDataAdapter(sql_select_computers);
                DataTable dt_computers = new DataTable();
                adapt_computers.Fill(dt_computers);
                txtComputer.Text = dt_computers.Rows[0]["TotalQty"].ToString();

                OracleCommand sql_select_sales = new OracleCommand("SELECT SUM(QtySales) AS TotalQtySales FROM tblSaleDetails", conn);
                OracleDataAdapter adapt_sales = new OracleDataAdapter(sql_select_sales);
                DataTable dt_sales = new DataTable();
                adapt_sales.Fill(dt_sales);
                txtSale.Text = dt_sales.Rows[0]["TotalQtySales"].ToString();

                OracleCommand sql_select_purchases = new OracleCommand("SELECT SUM(PurchaseQty) AS TotalPurchaseQty FROM tblPurchaseDetails", conn);
                OracleDataAdapter adapt_purchases = new OracleDataAdapter(sql_select_purchases);
                DataTable dt_purchases = new DataTable();
                adapt_purchases.Fill(dt_purchases);
                txtPurchase.Text = dt_purchases.Rows[0]["TotalPurchaseQty"].ToString();

                OracleCommand sql_select_categories = new OracleCommand("SELECT * FROM tblCategories", conn);
                OracleDataAdapter adapt_categories = new OracleDataAdapter(sql_select_categories);
                DataTable dt_categoires = new DataTable();
                adapt_categories.Fill(dt_categoires);
                txtCategory.Text = dt_categoires.Rows.Count.ToString();

                OracleCommand sql_select_members = new OracleCommand("SELECT * FROM tblMembers", conn);
                OracleDataAdapter adapt_members = new OracleDataAdapter(sql_select_members);
                DataTable dt_members = new DataTable();
                adapt_members.Fill(dt_members);
                txtMember.Text = dt_members.Rows.Count.ToString();

                OracleCommand sql_select_customers = new OracleCommand("SELECT * FROM tblCustomers", conn);
                OracleDataAdapter adapt_customers = new OracleDataAdapter(sql_select_customers);
                DataTable dt_customers = new DataTable();
                adapt_customers.Fill(dt_customers);
                txtCustomer.Text = dt_customers.Rows.Count.ToString();

                OracleCommand sql_select_suppliers = new OracleCommand("SELECT * FROM tblSuppliers", conn);
                OracleDataAdapter adapt_suppliers = new OracleDataAdapter(sql_select_suppliers);
                DataTable dt_suppliers = new DataTable();
                adapt_suppliers.Fill(dt_suppliers);
                txtSupplier.Text = dt_suppliers.Rows.Count.ToString();

                OracleCommand sql_select_staff = new OracleCommand("SELECT * FROM tblStaff", conn);
                OracleDataAdapter adapt_staff = new OracleDataAdapter(sql_select_staff);
                DataTable dt_staff = new DataTable();
                adapt_staff.Fill(dt_staff);
                txtStaff.Text = dt_staff.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("T");
        }
    }
}
