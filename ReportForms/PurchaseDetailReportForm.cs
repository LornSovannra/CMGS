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
    public partial class PurchaseDetailReportForm : Form
    {
        OracleConnection conn = Classes.DBConnection.Connect();

        public PurchaseDetailReportForm()
        {
            InitializeComponent();
        }

        private void PurchaseDetailReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        void LoadReport()
        {
            string select_sql = "SELECT pur.PurchaseID, com.ComputerName, pur.PurchaseQty FROM tblPurchaseDetails pur, tblComputers com WHERE com.ComputerID = pur.ComputerID ORDER BY pur.PurchaseID ASC";
            OracleDataAdapter adapt = new OracleDataAdapter(select_sql, conn);
            DataSet ds = new DataSet();

            adapt.Fill(ds, "PurchaseDetails");
            CrystalReports.PurchaseDetailCrystalReport crpt = new CrystalReports.PurchaseDetailCrystalReport();
            crpt.SetDataSource(ds.Tables["PurchaseDetails"]);

            crpt.Parameter_ComputerName.CurrentValues.Clear();
            crpt.Parameter_ComputerName.CurrentValues.AddValue(txtSearch.Text.Trim());
            crpt.SetParameterValue("ComputerName", crpt.Parameter_ComputerName.CurrentValues);

            crvPurchaseDetail.ReportSource = crpt;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string select_sql = "SELECT pur.PurchaseID, com.ComputerName, pur.PurchaseQty FROM tblPurchaseDetails pur, tblComputers com WHERE com.ComputerID = pur.ComputerID ORDER BY pur.PurchaseID ASC";
            OracleDataAdapter adapt = new OracleDataAdapter(select_sql, conn);
            DataSet ds = new DataSet();

            adapt.Fill(ds, "PurchaseDetails");
            CrystalReports.PurchaseDetailCrystalReport crpt = new CrystalReports.PurchaseDetailCrystalReport();
            crpt.SetDataSource(ds.Tables["PurchaseDetails"]);

            crpt.Parameter_ComputerName.CurrentValues.Clear();
            crpt.Parameter_ComputerName.CurrentValues.AddValue(txtSearch.Text.Trim());
            crpt.SetParameterValue("ComputerName", crpt.Parameter_ComputerName.CurrentValues);

            crvPurchaseDetail.ReportSource = crpt;
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
