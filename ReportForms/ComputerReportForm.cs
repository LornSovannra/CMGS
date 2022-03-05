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
    public partial class ComputerReportForm : Form
    {
        OracleConnection conn = Classes.DBConnection.Connect();

        public ComputerReportForm()
        {
            InitializeComponent();
        }

        private void ComputerReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        void LoadReport()
        {
            string select_sql = "SELECT com.ComputerID, com.ComputerName, com.Description, cat.CategoryName, com.Qty, com.UnitPriceIn, com.UnitPriceOut, com.Photo FROM tblComputers com, tblCategories cat WHERE cat.CategoryID = com.CategoryID ORDER BY com.ComputerID ASC";
            OracleDataAdapter adapt = new OracleDataAdapter(select_sql, conn);
            DataSet ds = new DataSet();

            adapt.Fill(ds, "Computers");
            CrystalReports.ComputerCrystalReport crpt = new CrystalReports.ComputerCrystalReport();
            crpt.SetDataSource(ds.Tables["Computers"]);

            crpt.Parameter_ComputerName.CurrentValues.Clear();
            crpt.Parameter_ComputerName.CurrentValues.AddValue(txtSearch.Text.Trim());
            crpt.SetParameterValue("ComputerName", crpt.Parameter_ComputerName.CurrentValues);

            crvComputer.ReportSource = crpt;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string select_sql = "SELECT com.ComputerID, com.ComputerName, com.Description, cat.CategoryName, com.Qty, com.UnitPriceIn, com.UnitPriceOut, com.Photo FROM tblComputers com, tblCategories cat WHERE cat.CategoryID = com.CategoryID ORDER BY com.ComputerID ASC";
            OracleDataAdapter adapt = new OracleDataAdapter(select_sql, conn);
            DataSet ds = new DataSet();

            adapt.Fill(ds, "Computers");
            CrystalReports.ComputerCrystalReport crpt = new CrystalReports.ComputerCrystalReport();
            crpt.SetDataSource(ds.Tables["Computers"]);

            crpt.Parameter_ComputerName.CurrentValues.Clear();
            crpt.Parameter_ComputerName.CurrentValues.AddValue(txtSearch.Text.Trim());
            crpt.SetParameterValue("ComputerName", crpt.Parameter_ComputerName.CurrentValues);

            crvComputer.ReportSource = crpt;
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
