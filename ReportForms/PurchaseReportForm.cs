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
    public partial class PurchaseReportForm : Form
    {
        OracleConnection conn = Classes.DBConnection.Connect();

        public PurchaseReportForm()
        {
            InitializeComponent();
        }

        private void PurchaseReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        void LoadReport()
        {
            string select_sql = "SELECT pur.PurchaseID, sta.StaffName, sup.SupplierName, pur.PurchaseDate FROM tblPurchases pur, tblStaff sta, tblSuppliers sup WHERE sta.StaffID = pur.StaffID AND sup.SupplierID = pur.SupplierID ORDER BY pur.PurchaseID ASC";
            OracleDataAdapter adapt = new OracleDataAdapter(select_sql, conn);
            DataSet ds = new DataSet();

            adapt.Fill(ds, "Purchases");
            CrystalReports.PurchaseCrystalReport crpt = new CrystalReports.PurchaseCrystalReport();
            crpt.SetDataSource(ds.Tables["Purchases"]);

            crpt.Parameter_StaffName.CurrentValues.Clear();
            crpt.Parameter_StaffName.CurrentValues.AddValue(txtSearch.Text.Trim());
            crpt.SetParameterValue("StaffName", crpt.Parameter_StaffName.CurrentValues);

            crvPurchase.ReportSource = crpt;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string select_sql = "SELECT pur.PurchaseID, sta.StaffName, sup.SupplierName, pur.PurchaseDate FROM tblPurchases pur, tblStaff sta, tblSuppliers sup WHERE sta.StaffID = pur.StaffID AND sup.SupplierID = pur.SupplierID ORDER BY pur.PurchaseID ASC";
            OracleDataAdapter adapt = new OracleDataAdapter(select_sql, conn);
            DataSet ds = new DataSet();

            adapt.Fill(ds, "Purchases");
            CrystalReports.PurchaseCrystalReport crpt = new CrystalReports.PurchaseCrystalReport();
            crpt.SetDataSource(ds.Tables["Purchases"]);

            crpt.Parameter_StaffName.CurrentValues.Clear();
            crpt.Parameter_StaffName.CurrentValues.AddValue(txtSearch.Text.Trim());
            crpt.SetParameterValue("StaffName", crpt.Parameter_StaffName.CurrentValues);

            crvPurchase.ReportSource = crpt;
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
