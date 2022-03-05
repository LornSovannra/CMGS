
namespace Computer_MGS.Forms
{
    partial class SaleForm
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
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCustomerID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMakeReport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvSale = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGE YOUR SALE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtStaffID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtpSaleDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbCustomerID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSaleID);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 100);
            this.panel1.TabIndex = 2;
            // 
            // txtStaffID
            // 
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.Location = new System.Drawing.Point(95, 58);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(284, 26);
            this.txtStaffID.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(407, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sale Date";
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.CustomFormat = "dd-MMM-yy";
            this.dtpSaleDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSaleDate.Location = new System.Drawing.Point(551, 56);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(284, 26);
            this.dtpSaleDate.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Staff ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(407, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer ID";
            // 
            // cbCustomerID
            // 
            this.cbCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomerID.FormattingEnabled = true;
            this.cbCustomerID.Location = new System.Drawing.Point(551, 12);
            this.cbCustomerID.Name = "cbCustomerID";
            this.cbCustomerID.Size = new System.Drawing.Size(284, 28);
            this.cbCustomerID.TabIndex = 4;
            this.cbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cbCustomerID_SelectedIndexChanged);
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
            // txtSaleID
            // 
            this.txtSaleID.Enabled = false;
            this.txtSaleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleID.Location = new System.Drawing.Point(95, 12);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(284, 26);
            this.txtSaleID.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnMakeReport);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnCreate);
            this.panel2.Location = new System.Drawing.Point(867, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 100);
            this.panel2.TabIndex = 3;
            // 
            // btnMakeReport
            // 
            this.btnMakeReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.btnMakeReport.FlatAppearance.BorderSize = 0;
            this.btnMakeReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReport.ForeColor = System.Drawing.Color.White;
            this.btnMakeReport.Location = new System.Drawing.Point(197, 54);
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
            this.btnDelete.Location = new System.Drawing.Point(115, 55);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(76, 42);
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
            this.btnUpdate.Location = new System.Drawing.Point(3, 54);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 43);
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
            this.btnCreate.Location = new System.Drawing.Point(3, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(311, 46);
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
            this.panel3.Location = new System.Drawing.Point(12, 159);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1172, 50);
            this.panel3.TabIndex = 4;
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
            // dgvSale
            // 
            this.dgvSale.AllowUserToAddRows = false;
            this.dgvSale.AllowUserToDeleteRows = false;
            this.dgvSale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSale.BackgroundColor = System.Drawing.Color.White;
            this.dgvSale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSale.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dgvSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSale.Location = new System.Drawing.Point(12, 215);
            this.dgvSale.Name = "dgvSale";
            this.dgvSale.ReadOnly = true;
            this.dgvSale.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSale.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSale.Size = new System.Drawing.Size(1172, 499);
            this.dgvSale.TabIndex = 5;
            this.dgvSale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSale_CellClick);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 726);
            this.Controls.Add(this.dgvSale);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "SaleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleForm";
            this.Load += new System.EventHandler(this.SaleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCustomerID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMakeReport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvSale;
        private System.Windows.Forms.TextBox txtStaffID;
    }
}