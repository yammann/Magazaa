namespace WebFormsUI
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnCollapse = new DevExpress.XtraEditors.SimpleButton();
            this.btnMini = new DevExpress.XtraEditors.SimpleButton();
            this.btnMax = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new DevExpress.XtraEditors.SimpleButton();
            this.btnProduct = new DevExpress.XtraEditors.SimpleButton();
            this.btnSale = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrice = new DevExpress.XtraEditors.SimpleButton();
            this.btnReturn = new DevExpress.XtraEditors.SimpleButton();
            this.btnEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.btnOrder = new DevExpress.XtraEditors.SimpleButton();
            this.btnReport = new DevExpress.XtraEditors.SimpleButton();
            this.btnStore = new DevExpress.XtraEditors.SimpleButton();
            this.btnUsers = new DevExpress.XtraEditors.SimpleButton();
            this.btnExpenses = new DevExpress.XtraEditors.SimpleButton();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblEmployeeRole = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.picEmployee = new System.Windows.Forms.PictureBox();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlHead.SuspendLayout();
            this.pnlNav.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.Color.Thistle;
            this.pnlHead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHead.Controls.Add(this.btnCollapse);
            this.pnlHead.Controls.Add(this.btnMini);
            this.pnlHead.Controls.Add(this.btnMax);
            this.pnlHead.Controls.Add(this.btnClose);
            this.pnlHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHead.Location = new System.Drawing.Point(0, 0);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(1000, 42);
            this.pnlHead.TabIndex = 0;
            // 
            // btnCollapse
            // 
            this.btnCollapse.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnCollapse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCollapse.ImageOptions.SvgImage")));
            this.btnCollapse.Location = new System.Drawing.Point(0, 0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnCollapse.Size = new System.Drawing.Size(50, 42);
            this.btnCollapse.TabIndex = 1;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMini.ImageOptions.SvgImage")));
            this.btnMini.Location = new System.Drawing.Point(906, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMini.Size = new System.Drawing.Size(36, 36);
            this.btnMini.TabIndex = 0;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMax.ImageOptions.SvgImage")));
            this.btnMax.Location = new System.Drawing.Point(856, 3);
            this.btnMax.Name = "btnMax";
            this.btnMax.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMax.Size = new System.Drawing.Size(36, 36);
            this.btnMax.TabIndex = 0;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(956, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(36, 36);
            this.btnClose.TabIndex = 0;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.Thistle;
            this.pnlNav.Controls.Add(this.flowLayoutPanel1);
            this.pnlNav.Controls.Add(this.pnlUser);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNav.Location = new System.Drawing.Point(0, 42);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(175, 600);
            this.pnlNav.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnHome);
            this.flowLayoutPanel1.Controls.Add(this.btnProduct);
            this.flowLayoutPanel1.Controls.Add(this.btnSale);
            this.flowLayoutPanel1.Controls.Add(this.btnPrice);
            this.flowLayoutPanel1.Controls.Add(this.btnReturn);
            this.flowLayoutPanel1.Controls.Add(this.btnEmployee);
            this.flowLayoutPanel1.Controls.Add(this.btnOrder);
            this.flowLayoutPanel1.Controls.Add(this.btnReport);
            this.flowLayoutPanel1.Controls.Add(this.btnStore);
            this.flowLayoutPanel1.Controls.Add(this.btnUsers);
            this.flowLayoutPanel1.Controls.Add(this.btnExpenses);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 140);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(175, 460);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Appearance.Options.UseFont = true;
            this.btnHome.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHome.ImageOptions.SvgImage")));
            this.btnHome.Location = new System.Drawing.Point(3, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnHome.Size = new System.Drawing.Size(169, 36);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Ana Sayfa";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnProduct
            // 
            this.btnProduct.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Appearance.Options.UseFont = true;
            this.btnProduct.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProduct.ImageOptions.SvgImage")));
            this.btnProduct.Location = new System.Drawing.Point(3, 45);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnProduct.Size = new System.Drawing.Size(169, 36);
            this.btnProduct.TabIndex = 8;
            this.btnProduct.Text = "Categoriler";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click_1);
            // 
            // btnSale
            // 
            this.btnSale.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Appearance.Options.UseFont = true;
            this.btnSale.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSale.ImageOptions.SvgImage")));
            this.btnSale.Location = new System.Drawing.Point(3, 87);
            this.btnSale.Name = "btnSale";
            this.btnSale.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSale.Size = new System.Drawing.Size(169, 36);
            this.btnSale.TabIndex = 5;
            this.btnSale.Text = "Satış";
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click_1);
            // 
            // btnPrice
            // 
            this.btnPrice.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.Appearance.Options.UseFont = true;
            this.btnPrice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPrice.ImageOptions.SvgImage")));
            this.btnPrice.Location = new System.Drawing.Point(3, 129);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPrice.Size = new System.Drawing.Size(169, 36);
            this.btnPrice.TabIndex = 6;
            this.btnPrice.Text = "Fiyatlar";
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click_1);
            // 
            // btnReturn
            // 
            this.btnReturn.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Appearance.Options.UseFont = true;
            this.btnReturn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReturn.ImageOptions.SvgImage")));
            this.btnReturn.Location = new System.Drawing.Point(3, 171);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnReturn.Size = new System.Drawing.Size(169, 36);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "İade";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click_1);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Appearance.Options.UseFont = true;
            this.btnEmployee.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEmployee.ImageOptions.SvgImage")));
            this.btnEmployee.Location = new System.Drawing.Point(3, 213);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEmployee.Size = new System.Drawing.Size(169, 36);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "Çalışanlar";
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click_1);
            // 
            // btnOrder
            // 
            this.btnOrder.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Appearance.Options.UseFont = true;
            this.btnOrder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOrder.ImageOptions.SvgImage")));
            this.btnOrder.Location = new System.Drawing.Point(3, 255);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnOrder.Size = new System.Drawing.Size(169, 36);
            this.btnOrder.TabIndex = 10;
            this.btnOrder.Text = "Siparişler";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // btnReport
            // 
            this.btnReport.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Appearance.Options.UseFont = true;
            this.btnReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReport.ImageOptions.SvgImage")));
            this.btnReport.Location = new System.Drawing.Point(3, 297);
            this.btnReport.Name = "btnReport";
            this.btnReport.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnReport.Size = new System.Drawing.Size(169, 36);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Raporlar";
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnStore
            // 
            this.btnStore.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.Appearance.Options.UseFont = true;
            this.btnStore.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStore.ImageOptions.SvgImage")));
            this.btnStore.Location = new System.Drawing.Point(3, 339);
            this.btnStore.Name = "btnStore";
            this.btnStore.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnStore.Size = new System.Drawing.Size(169, 36);
            this.btnStore.TabIndex = 3;
            this.btnStore.Text = "Depo";
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click_1);
            // 
            // btnUsers
            // 
            this.btnUsers.Appearance.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.Appearance.Options.UseFont = true;
            this.btnUsers.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUsers.ImageOptions.SvgImage")));
            this.btnUsers.Location = new System.Drawing.Point(3, 381);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnUsers.Size = new System.Drawing.Size(169, 36);
            this.btnUsers.TabIndex = 11;
            this.btnUsers.Text = "kulancılar";
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnExpenses
            // 
            this.btnExpenses.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.Appearance.Options.UseFont = true;
            this.btnExpenses.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExpenses.ImageOptions.SvgImage")));
            this.btnExpenses.Location = new System.Drawing.Point(3, 423);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnExpenses.Size = new System.Drawing.Size(169, 36);
            this.btnExpenses.TabIndex = 12;
            this.btnExpenses.Text = "Mağaza Masrafları";
            this.btnExpenses.Click += new System.EventHandler(this.btnExpenses_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUser.Controls.Add(this.lblEmployeeRole);
            this.pnlUser.Controls.Add(this.lblEmployeeName);
            this.pnlUser.Controls.Add(this.picEmployee);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(175, 140);
            this.pnlUser.TabIndex = 0;
            // 
            // lblEmployeeRole
            // 
            this.lblEmployeeRole.AutoSize = true;
            this.lblEmployeeRole.Location = new System.Drawing.Point(70, 120);
            this.lblEmployeeRole.Name = "lblEmployeeRole";
            this.lblEmployeeRole.Size = new System.Drawing.Size(35, 13);
            this.lblEmployeeRole.TabIndex = 1;
            this.lblEmployeeRole.Text = "label2";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(56, 97);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(35, 13);
            this.lblEmployeeName.TabIndex = 0;
            this.lblEmployeeName.Text = "label1";
            // 
            // picEmployee
            // 
            this.picEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.picEmployee.Image = ((System.Drawing.Image)(resources.GetObject("picEmployee.Image")));
            this.picEmployee.Location = new System.Drawing.Point(0, 0);
            this.picEmployee.Name = "picEmployee";
            this.picEmployee.Size = new System.Drawing.Size(173, 94);
            this.picEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmployee.TabIndex = 0;
            this.picEmployee.TabStop = false;
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.White;
            this.pnlCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCenter.Location = new System.Drawing.Point(175, 42);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(825, 600);
            this.pnlCenter.TabIndex = 2;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlHead;
            this.bunifuDragControl1.Vertical = true;
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 642);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlNav);
            this.Controls.Add(this.pnlHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.pnlHead.ResumeLayout(false);
            this.pnlNav.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHead;
        private DevExpress.XtraEditors.SimpleButton btnMini;
        private DevExpress.XtraEditors.SimpleButton btnMax;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel pnlUser;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private DevExpress.XtraEditors.SimpleButton btnCollapse;
        public System.Windows.Forms.Panel pnlCenter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public System.Windows.Forms.Label lblEmployeeRole;
        public System.Windows.Forms.Label lblEmployeeName;
        public System.Windows.Forms.PictureBox picEmployee;
        public DevExpress.XtraEditors.SimpleButton btnHome;
        public DevExpress.XtraEditors.SimpleButton btnProduct;
        public DevExpress.XtraEditors.SimpleButton btnSale;
        public DevExpress.XtraEditors.SimpleButton btnPrice;
        public DevExpress.XtraEditors.SimpleButton btnReturn;
        public DevExpress.XtraEditors.SimpleButton btnEmployee;
        public DevExpress.XtraEditors.SimpleButton btnOrder;
        public DevExpress.XtraEditors.SimpleButton btnReport;
        public DevExpress.XtraEditors.SimpleButton btnStore;
        public DevExpress.XtraEditors.SimpleButton btnUsers;
        public DevExpress.XtraEditors.SimpleButton btnExpenses;
    }
}

