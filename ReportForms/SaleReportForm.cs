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

namespace Computer_MGS.ReportForms
{
    public partial class SaleReportForm : Form
    {
        OracleConnection conn = Classes.DBConnection.Connect();

        public SaleReportForm()
        {
            InitializeComponent();
        }

        private void SaleReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        void LoadReport()
        {
            string select_sql = "SELECT sa.SaleID, st.StaffName, cu.CustomerName, sa.SalesDate FROM tblSales sa, tblStaff st, tblCustomers cu WHERE st.StaffID = sa.StaffID AND cu.CustomerID = sa.CustomerID ORDER BY SaleID ASC";
            OracleDataAdapter adapt = new OracleDataAdapter(select_sql, conn);
            DataSet ds = new DataSet();

            adapt.Fill(ds, "Sales");
            CrystalReports.SaleCrystalReport crpt = new CrystalReports.SaleCrystalReport();
            crpt.SetDataSource(ds.Tables["Sales"]);

            crpt.Parameter_StaffName.CurrentValues.Clear();
            crpt.Parameter_StaffName.CurrentValues.AddValue(txtSearch.Text.Trim());
            crpt.SetParameterValue("StaffName", crpt.Parameter_StaffName.CurrentValues);

            crvSale.ReportSource = crpt;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string select_sql = "SELECT sa.SaleID, st.StaffName, cu.CustomerName, sa.SalesDate FROM tblSales sa, tblStaff st, tblCustomers cu WHERE st.StaffID = sa.StaffID AND cu.CustomerID = sa.CustomerID ORDER BY SaleID ASC";
            OracleDataAdapter adapt = new OracleDataAdapter(select_sql, conn);
            DataSet ds = new DataSet();

            adapt.Fill(ds, "Sales");
            CrystalReports.SaleCrystalReport crpt = new CrystalReports.SaleCrystalReport();
            crpt.SetDataSource(ds.Tables["Sales"]);

            crpt.Parameter_StaffName.CurrentValues.Clear();
            crpt.Parameter_StaffName.CurrentValues.AddValue(txtSearch.Text.Trim());
            crpt.SetParameterValue("StaffName", crpt.Parameter_StaffName.CurrentValues);

            crvSale.ReportSource = crpt;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFind.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
