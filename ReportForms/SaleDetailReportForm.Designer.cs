
namespace Computer_MGS.ReportForms
{
    partial class SaleDetailReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.crvSaleDetail = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // crvSaleDetail
            // 
            this.crvSaleDetail.ActiveViewIndex = -1;
            this.crvSaleDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvSaleDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSaleDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvSaleDetail.Location = new System.Drawing.Point(14, 44);
            this.crvSaleDetail.Name = "crvSaleDetail";
            this.crvSaleDetail.Size = new System.Drawing.Size(1132, 665);
            this.crvSaleDetail.TabIndex = 26;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(1051, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 26);
            this.btnFind.TabIndex = 25;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(82, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(963, 26);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.label9.Location = new System.Drawing.Point(10, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Search";
            // 
            // SaleDetailReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 721);
            this.Controls.Add(this.crvSaleDetail);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label9);
            this.Name = "SaleDetailReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleDetailReportForm";
            this.Load += new System.EventHandler(this.SaleDetailReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSaleDetail;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
    }
}