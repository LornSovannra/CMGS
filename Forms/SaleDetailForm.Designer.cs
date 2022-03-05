
namespace Computer_MGS.Forms
{
    partial class SaleDetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbSaleID = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbComputerID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQtySales = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvSaleDetail = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "MANAGE YOUR SALE DETAIL\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cbSaleID);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rtbRemark);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbComputerID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtQtySales);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 100);
            this.panel1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.label11.Location = new System.Drawing.Point(624, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "%";
            // 
            // cbSaleID
            // 
            this.cbSaleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSaleID.FormattingEnabled = true;
            this.cbSaleID.Location = new System.Drawing.Point(131, 12);
            this.cbSaleID.Name = "cbSaleID";
            this.cbSaleID.Size = new System.Drawing.Size(205, 28);
            this.cbSaleID.TabIndex = 29;
            this.cbSaleID.SelectedIndexChanged += new System.EventHandler(this.cbSaleID_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(668, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Remark";
            // 
            // rtbRemark
            // 
            this.rtbRemark.Location = new System.Drawing.Point(672, 35);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(207, 51);
            this.rtbRemark.TabIndex = 27;
            this.rtbRemark.Text = "";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(447, 58);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(205, 26);
            this.txtDiscount.TabIndex = 26;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(355, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Discount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(355, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Qty Sales";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Computer ID";
            // 
            // cbComputerID
            // 
            this.cbComputerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbComputerID.FormattingEnabled = true;
            this.cbComputerID.Location = new System.Drawing.Point(131, 58);
            this.cbComputerID.Name = "cbComputerID";
            this.cbComputerID.Size = new System.Drawing.Size(205, 28);
            this.cbComputerID.TabIndex = 4;
            this.cbComputerID.SelectedIndexChanged += new System.EventHandler(this.cbComputerID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sale ID";
            // 
            // txtQtySales
            // 
            this.txtQtySales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtySales.Location = new System.Drawing.Point(447, 12);
            this.txtQtySales.Name = "txtQtySales";
            this.txtQtySales.Size = new System.Drawing.Size(205, 26);
            this.txtQtySales.TabIndex = 0;
            this.txtQtySales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtySales_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnMakeReport);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Location = new System.Drawing.Point(910, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 100);
            this.panel2.TabIndex = 4;
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnMakeReport.FlatAppearance.BorderSize = 0;
            this.btnMakeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReport.ForeColor = System.Drawing.Color.White;
            this.btnMakeReport.Location = new System.Drawing.Point(154, 53);
            this.btnMakeReport.Name = "btnMakeReport";
            this.btnMakeReport.Size = new System.Drawing.Size(117, 43);
            this.btnMakeReport.TabIndex = 20;
            this.btnMakeReport.Text = "Make Report";
            this.btnMakeReport.UseVisualStyleBackColor = false;
            this.btnMakeReport.Click += new System.EventHandler(this.btnMakeReport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(82, 54);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 42);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(4, 54);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(72, 43);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(4, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(267, 46);
            this.btnCreate.TabIndex = 17;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(12, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1172, 50);
            this.panel3.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(82, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1073, 26);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.label9.Location = new System.Drawing.Point(10, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Search";
            // 
            // dgvSaleDetail
            // 
            this.dgvSaleDetail.AllowUserToAddRows = false;
            this.dgvSaleDetail.AllowUserToDeleteRows = false;
            this.dgvSaleDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSaleDetail.BackgroundColor = System.Drawing.Color.White;
            this.dgvSaleDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSaleDetail.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvSaleDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleDetail.Location = new System.Drawing.Point(12, 217);
            this.dgvSaleDetail.Name = "dgvSaleDetail";
            this.dgvSaleDetail.ReadOnly = true;
            this.dgvSaleDetail.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSaleDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSaleDetail.Size = new System.Drawing.Size(1172, 499);
            this.dgvSaleDetail.TabIndex = 6;
            this.dgvSaleDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSaleDetail_CellClick);
            // 
            // SaleDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 726);
            this.Controls.Add(this.dgvSaleDetail);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SaleDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleDetailForm";
            this.Load += new System.EventHandler(this.SaleDetailForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbComputerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQtySales;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMakeReport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvSaleDetail;
        private System.Windows.Forms.ComboBox cbSaleID;
        private System.Windows.Forms.Label label11;
    }
}