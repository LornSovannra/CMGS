
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
            this.flowLayoutPanelNavigation = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.pnSalesDropDown = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAboutSales = new System.Windows.Forms.Button();
            this.pnPurchasesDropDown = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
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
            this.pnDesktop.SuspendLayout();
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
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(219, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(1195, 62);
            this.pnHeader.TabIndex = 1;
            this.pnHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseDown);
            this.pnHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseMove);
            this.pnHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnHeader_MouseUp);
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
            // 
            // pnSalesDropDown
            // 
            this.pnSalesDropDown.BackColor = System.Drawing.Color.White;
            this.pnSalesDropDown.Controls.Add(this.button2);
            this.pnSalesDropDown.Controls.Add(this.button1);
            this.pnSalesDropDown.Controls.Add(this.btnAboutSales);
            this.pnSalesDropDown.Location = new System.Drawing.Point(3, 195);
            this.pnSalesDropDown.MaximumSize = new System.Drawing.Size(218, 134);
            this.pnSalesDropDown.MinimumSize = new System.Drawing.Size(218, 54);
            this.pnSalesDropDown.Name = "pnSalesDropDown";
            this.pnSalesDropDown.Size = new System.Drawing.Size(218, 54);
            this.pnSalesDropDown.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Computer_MGS.Properties.Resources.sale_32px_new;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 95);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(218, 41);
            this.button2.TabIndex = 35;
            this.button2.Text = "  &Sale Detail";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Computer_MGS.Properties.Resources.sale_32px_new;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 54);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(218, 41);
            this.button1.TabIndex = 34;
            this.button1.Text = "  &Sale";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
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
            this.btnAboutSales.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // pnPurchasesDropDown
            // 
            this.pnPurchasesDropDown.BackColor = System.Drawing.Color.White;
            this.pnPurchasesDropDown.Controls.Add(this.button3);
            this.pnPurchasesDropDown.Controls.Add(this.button4);
            this.pnPurchasesDropDown.Controls.Add(this.btnAboutPurchases);
            this.pnPurchasesDropDown.Location = new System.Drawing.Point(3, 255);
            this.pnPurchasesDropDown.MaximumSize = new System.Drawing.Size(218, 134);
            this.pnPurchasesDropDown.MinimumSize = new System.Drawing.Size(218, 54);
            this.pnPurchasesDropDown.Name = "pnPurchasesDropDown";
            this.pnPurchasesDropDown.Size = new System.Drawing.Size(218, 54);
            this.pnPurchasesDropDown.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Computer_MGS.Properties.Resources.purchase_order_32px;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 95);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(218, 41);
            this.button3.TabIndex = 35;
            this.button3.Text = "  Purchase Detail";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::Computer_MGS.Properties.Resources.purchase_order_32px;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 54);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(218, 41);
            this.button4.TabIndex = 34;
            this.button4.Text = "  Purchase";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
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
            this.btnAboutPurchases.Click += new System.EventHandler(this.btnPurchase_Click);
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
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAboutSales;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Timer salesDropDownTimer;
        private System.Windows.Forms.Panel pnPurchasesDropDown;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnAboutPurchases;
        private System.Windows.Forms.Timer purchasesDropDownTimer;
    }
}

