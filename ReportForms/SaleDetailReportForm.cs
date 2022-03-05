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
    public partial class SaleDetailReportForm : Form
    {
        OracleConnection conn = Classes.DBConnection.Connect();

        public SaleDetailReportForm()
        {
            InitializeComponent();
        }

        private void SaleDetailReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        void LoadReport()
        {
            string select_sql = "SELECT sd.SaleID, com.ComputerName, sd.QtySales, sd.Discount, sd.Remark FROM tblSaleDetails sd, tblComputers com WHERE com.ComputerID = sd.ComputerID ORDER BY sd.SaleID ASC";
            OracleDataAdapter adapt = new OracleDataAdapter(select_sql, conn);
            DataSet ds = new DataSet();

            adapt.Fill(ds, "SaleDetails");
            CrystalReports.SaleDetailCrystalReport crpt = new CrystalReports.SaleDetailCrystalReport();
            crpt.SetDataSource(ds.Tables["SaleDetails"]);

            crpt.Parameter_ComputerName.CurrentValues.Clear();
            crpt.Parameter_ComputerName.CurrentValues.AddValue(txtSearch.Text.Trim());
            crpt.SetParameterValue("ComputerName", crpt.Parameter_ComputerName.CurrentValues);

            crvSaleDetail.ReportSource = crpt;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string select_sql = "SELECT sd.SaleID, com.ComputerName, sd.QtySales, sd.Discount, sd.Remark FROM tblSaleDetails sd, tblComputers com WHERE com.ComputerID = sd.ComputerID ORDER BY sd.SaleID ASC";
            OracleDataAdapter adapt = new OracleDataAdapter(select_sql, conn);
            DataSet ds = new DataSet();

            adapt.Fill(ds, "SaleDetails");
            CrystalReports.SaleDetailCrystalReport crpt = new CrystalReports.SaleDetailCrystalReport();
            crpt.SetDataSource(ds.Tables["SaleDetails"]);

            crpt.Parameter_ComputerName.CurrentValues.Clear();
            crpt.Parameter_ComputerName.CurrentValues.AddValue(txtSearch.Text.Trim());
            crpt.SetParameterValue("ComputerName", crpt.Parameter_ComputerName.CurrentValues);

            crvSaleDetail.ReportSource = crpt;
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
