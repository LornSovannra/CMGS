
namespace Computer_MGS
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.pnDesktop = new System.Windows.Forms.Panel();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pbMinimize = new System.Windows.Forms.PictureBox();
            this.pbMaximize = new System.Windows.Forms.PictureBox();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelNavigation = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.pnSalesDropDown = new System.Windows.Forms.Panel();
            this.btnSaleDetail = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnAboutSales = new System.Windows.Forms.Button();
            this.pnPurchasesDropDown = new System.Windows.Forms.Panel();
            this.btnPurchaseDetail = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnAboutPurchases = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.salesDropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.purchasesDropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnDesktop.SuspendLayout();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.flowLayoutPanelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnSalesDropDown.SuspendLayout();
            this.pnPurchasesDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // pnDesktop
            // 
            this.pnDesktop.Controls.Add(this.pnHeader);
            this.pnDesktop.Controls.Add(this.flowLayoutPanelNavigation);
            this.pnDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDesktop.Location = new System.Drawing.Point(0, 0);
            this.pnDesktop.Name = "pnDesktop";
            this.pnDesktop.Size = new System.Drawing.Size(1414, 793);
            this.pnDesktop.TabIndex = 2;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.pnHeader.Controls.Add(this.label4);
            this.pnHeader.Controls.Add(this.label3);
            this.pnHeader.Controls.Add(this.label2);
            this.pnHeader.Controls.Add(this.pbMinimize);
            this.pnHeader.Controls.Add(this.pbMaximize);
            this.pnHeader.Controls.Add(this.pbClose);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(219, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1195, 62);
            this.pnHeader.TabIndex = 1;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
            this.pnHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseUp);
            // 
            // pbMinimize
            // 
            this.pbMinimize.Image = global::Computer_MGS.Properties.Resources.subtract_60px;
            this.pbMinimize.Location = new System.Drawing.Point(1077, 18);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.Size = new System.Drawing.Size(31, 30);
            this.pbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimize.TabIndex = 45;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // pbMaximize
            // 
            this.pbMaximize.Image = global::Computer_MGS.Properties.Resources.full_screen_60px;
            this.pbMaximize.Location = new System.Drawing.Point(1114, 18);
            this.pbMaximize.Name = "pbMaximize";
            this.pbMaximize.Size = new System.Drawing.Size(31, 30);
            this.pbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaximize.TabIndex = 44;
            this.pbMaximize.TabStop = false;
            this.pbMaximize.Click += new System.EventHandler(this.pbMaximize_Click);
            // 
            // pbClose
            // 
            this.pbClose.Image = global::Computer_MGS.Properties.Resources.Close_64px;
            this.pbClose.Location = new System.Drawing.Point(1151, 18);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(31, 30);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 43;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // flowLayoutPanelNavigation
            // 
            this.flowLayoutPanelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.flowLayoutPanelNavigation.Controls.Add(this.label1);
            this.flowLayoutPanelNavigation.Controls.Add(this.pictureBox1);
            this.flowLayoutPanelNavigation.Controls.Add(this.btnDashboard);
            this.flowLayoutPanelNavigation.Controls.Add(this.btnComputer);
            this.flowLayoutPanelNavigation.Controls.Add(this.pnSalesDropDown);
            this.flowLayoutPanelNavigation.Controls.Add(this.pnPurchasesDropDown);
            this.flowLayoutPanelNavigation.Controls.Add(this.btnCategory);
            this.flowLayoutPanelNavigation.Controls.Add(this.btnMember);
            this.flowLayoutPanelNavigation.Controls.Add(this.btnCustomer);
            this.flowLayoutPanelNavigation.Controls.Add(this.btnSupplier);
            this.flowLayoutPanelNavigation.Controls.Add(this.btnStaff);
            this.flowLayoutPanelNavigation.Controls.Add(this.btnLogout);
            this.flowLayoutPanelNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelNavigation.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelNavigation.Name = "flowLayoutPanelNavigation";
            this.flowLayoutPanelNavigation.Size = new System.Drawing.Size(219, 793);
            this.flowLayoutPanelNavigation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer Moul", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(143, 64);
            this.label1.TabIndex = 13;
            this.label1.Text = "Shield";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Computer_MGS.Properties.Resources.delete_shield_128px;
            this.pictureBox1.Location = new System.Drawing.Point(152, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Computer_MGS.Properties.Resources.dashboard_32_Newpx;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 67);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(218, 58);
            this.btnDashboard.TabIndex = 14;
            this.btnDashboard.Text = "  &Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnComputer.FlatAppearance.BorderSize = 0;
            this.btnComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer.ForeColor = System.Drawing.Color.White;
            this.btnComputer.Image = global::Computer_MGS.Properties.Resources.laptop_computer_32px;
            this.btnComputer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComputer.Location = new System.Drawing.Point(3, 131);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnComputer.Size = new System.Drawing.Size(218, 58);
            this.btnComputer.TabIndex = 24;
            this.btnComputer.Text = "  &Computer";
            this.btnComputer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComputer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnComputer.UseVisualStyleBackColor = false;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // pnSalesDropDown
            // 
            this.pnSalesDropDown.BackColor = System.Drawing.Color.White;
            this.pnSalesDropDown.Controls.Add(this.btnSaleDetail);
            this.pnSalesDropDown.Controls.Add(this.btnSale);
            this.pnSalesDropDown.Controls.Add(this.btnAboutSales);
            this.pnSalesDropDown.Location = new System.Drawing.Point(3, 195);
            this.pnSalesDropDown.MaximumSize = new System.Drawing.Size(218, 134);
            this.pnSalesDropDown.MinimumSize = new System.Drawing.Size(218, 54);
            this.pnSalesDropDown.Name = "pnSalesDropDown";
            this.pnSalesDropDown.Size = new System.Drawing.Size(218, 54);
            this.pnSalesDropDown.TabIndex = 41;
            // 
            // btnSaleDetail
            // 
            this.btnSaleDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnSaleDetail.FlatAppearance.BorderSize = 0;
            this.btnSaleDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaleDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaleDetail.ForeColor = System.Drawing.Color.White;
            this.btnSaleDetail.Image = global::Computer_MGS.Properties.Resources.sale_32px_new;
            this.btnSaleDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleDetail.Location = new System.Drawing.Point(0, 95);
            this.btnSaleDetail.Name = "btnSaleDetail";
            this.btnSaleDetail.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSaleDetail.Size = new System.Drawing.Size(218, 41);
            this.btnSaleDetail.TabIndex = 35;
            this.btnSaleDetail.Text = "  &Sale Detail";
            this.btnSaleDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaleDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaleDetail.UseVisualStyleBackColor = false;
            this.btnSaleDetail.Click += new System.EventHandler(this.btnSaleDetail_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Image = global::Computer_MGS.Properties.Resources.sale_32px_new;
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(0, 54);
            this.btnSale.Name = "btnSale";
            this.btnSale.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSale.Size = new System.Drawing.Size(218, 41);
            this.btnSale.TabIndex = 34;
            this.btnSale.Text = "  &Sale";
            this.btnSale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSale.UseVisualStyleBackColor = false;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // btnAboutSales
            // 
            this.btnAboutSales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnAboutSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutSales.FlatAppearance.BorderSize = 0;
            this.btnAboutSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutSales.ForeColor = System.Drawing.Color.White;
            this.btnAboutSales.Image = global::Computer_MGS.Properties.Resources.expand_arrow_32px;
            this.btnAboutSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutSales.Location = new System.Drawing.Point(0, 0);
            this.btnAboutSales.Name = "btnAboutSales";
            this.btnAboutSales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAboutSales.Size = new System.Drawing.Size(218, 58);
            this.btnAboutSales.TabIndex = 33;
            this.btnAboutSales.Text = "  About Sales";
            this.btnAboutSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutSales.UseVisualStyleBackColor = false;
            this.btnAboutSales.Click += new System.EventHandler(this.btnAboutSales_Click);
            // 
            // pnPurchasesDropDown
            // 
            this.pnPurchasesDropDown.BackColor = System.Drawing.Color.White;
            this.pnPurchasesDropDown.Controls.Add(this.btnPurchaseDetail);
            this.pnPurchasesDropDown.Controls.Add(this.btnPurchase);
            this.pnPurchasesDropDown.Controls.Add(this.btnAboutPurchases);
            this.pnPurchasesDropDown.Location = new System.Drawing.Point(3, 255);
            this.pnPurchasesDropDown.MaximumSize = new System.Drawing.Size(218, 134);
            this.pnPurchasesDropDown.MinimumSize = new System.Drawing.Size(218, 54);
            this.pnPurchasesDropDown.Name = "pnPurchasesDropDown";
            this.pnPurchasesDropDown.Size = new System.Drawing.Size(218, 54);
            this.pnPurchasesDropDown.TabIndex = 42;
            // 
            // btnPurchaseDetail
            // 
            this.btnPurchaseDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnPurchaseDetail.FlatAppearance.BorderSize = 0;
            this.btnPurchaseDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseDetail.ForeColor = System.Drawing.Color.White;
            this.btnPurchaseDetail.Image = global::Computer_MGS.Properties.Resources.purchase_order_32px;
            this.btnPurchaseDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseDetail.Location = new System.Drawing.Point(0, 95);
            this.btnPurchaseDetail.Name = "btnPurchaseDetail";
            this.btnPurchaseDetail.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPurchaseDetail.Size = new System.Drawing.Size(218, 41);
            this.btnPurchaseDetail.TabIndex = 35;
            this.btnPurchaseDetail.Text = "  Purchase Detail";
            this.btnPurchaseDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchaseDetail.UseVisualStyleBackColor = false;
            this.btnPurchaseDetail.Click += new System.EventHandler(this.btnPurchaseDetail_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Image = global::Computer_MGS.Properties.Resources.purchase_order_32px;
            this.btnPurchase.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.Location = new System.Drawing.Point(0, 54);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPurchase.Size = new System.Drawing.Size(218, 41);
            this.btnPurchase.TabIndex = 34;
            this.btnPurchase.Text = "  Purchase";
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnAboutPurchases
            // 
            this.btnAboutPurchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnAboutPurchases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAboutPurchases.FlatAppearance.BorderSize = 0;
            this.btnAboutPurchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAboutPurchases.ForeColor = System.Drawing.Color.White;
            this.btnAboutPurchases.Image = global::Computer_MGS.Properties.Resources.expand_arrow_32px;
            this.btnAboutPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutPurchases.Location = new System.Drawing.Point(0, 0);
            this.btnAboutPurchases.Name = "btnAboutPurchases";
            this.btnAboutPurchases.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAboutPurchases.Size = new System.Drawing.Size(218, 58);
            this.btnAboutPurchases.TabIndex = 33;
            this.btnAboutPurchases.Text = "  About Purchases";
            this.btnAboutPurchases.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAboutPurchases.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAboutPurchases.UseVisualStyleBackColor = false;
            this.btnAboutPurchases.Click += new System.EventHandler(this.btnAboutPurchases_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.White;
            this.btnCategory.Image = global::Computer_MGS.Properties.Resources.categorize_32px;
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(3, 315);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCategory.Size = new System.Drawing.Size(218, 58);
            this.btnCategory.TabIndex = 35;
            this.btnCategory.Text = "  C&ategory";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnMember.FlatAppearance.BorderSize = 0;
            this.btnMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.Image = global::Computer_MGS.Properties.Resources.member_32px;
            this.btnMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.Location = new System.Drawing.Point(3, 379);
            this.btnMember.Name = "btnMember";
            this.btnMember.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMember.Size = new System.Drawing.Size(218, 58);
            this.btnMember.TabIndex = 36;
            this.btnMember.Text = "  &Member";
            this.btnMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMember.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = global::Computer_MGS.Properties.Resources.customer_32px;
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(3, 443);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCustomer.Size = new System.Drawing.Size(218, 58);
            this.btnCustomer.TabIndex = 39;
            this.btnCustomer.Text = "  C&ustomer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomer.UseVisualStyleBackColor = false;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnSupplier.FlatAppearance.BorderSize = 0;
            this.btnSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.White;
            this.btnSupplier.Image = global::Computer_MGS.Properties.Resources.supplier_32px;
            this.btnSupplier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.Location = new System.Drawing.Point(3, 507);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSupplier.Size = new System.Drawing.Size(218, 58);
            this.btnSupplier.TabIndex = 38;
            this.btnSupplier.Text = "  Supplie&r";
            this.btnSupplier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = global::Computer_MGS.Properties.Resources.staff_32px;
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(3, 571);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnStaff.Size = new System.Drawing.Size(218, 58);
            this.btnStaff.TabIndex = 37;
            this.btnStaff.Text = "  S&taff";
            this.btnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(102)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Computer_MGS.Properties.Resources.login_32px;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 635);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(218, 58);
            this.btnLogout.TabIndex = 40;
            this.btnLogout.Text = "  Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // salesDropDownTimer
            // 
            this.salesDropDownTimer.Interval = 15;
            this.salesDropDownTimer.Tick += new System.EventHandler(this.salesDropDownTimer_Tick);
            // 
            // purchasesDropDownTimer
            // 
            this.purchasesDropDownTimer.Interval = 15;
            this.purchasesDropDownTimer.Tick += new System.EventHandler(this.purchasesDropDownTimer_Tick);
            // 
            // pbExit
            // 
            this.pbExit.Image = global::Computer_MGS.Properties.Resources.Close_512px;
            this.pbExit.Location = new System.Drawing.Point(1159, 12);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(25, 23);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 8;
            this.pbExit.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Lorn Sovannra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(213)))));
            this.label4.Location = new System.Drawing.Point(252, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(589, 31);
            this.label4.TabIndex = 48;
            this.label4.Text = "Computer Management System - Dashboard";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 793);
            this.Controls.Add(this.pnDesktop);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Computer Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnDesktop.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.flowLayoutPanelNavigation.ResumeLayout(false);
            this.flowLayoutPanelNavigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnSalesDropDown.ResumeLayout(false);
            this.pnPurchasesDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnDesktop;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavigation;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Panel pnSalesDropDown;
        private System.Windows.Forms.Button btnSaleDetail;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnAboutSales;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer salesDropDownTimer;
        private System.Windows.Forms.Panel pnPurchasesDropDown;
        private System.Windows.Forms.Button btnPurchaseDetail;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnAboutPurchases;
        private System.Windows.Forms.Timer purchasesDropDownTimer;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMinimize;
        private System.Windows.Forms.PictureBox pbMaximize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}

