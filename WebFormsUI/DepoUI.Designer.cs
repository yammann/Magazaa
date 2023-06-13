namespace WebFormsUI
{
    partial class DepoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepoUI));
            this.pnlDepo = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOut = new DevExpress.XtraEditors.SimpleButton();
            this.btnOutList = new DevExpress.XtraEditors.SimpleButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEnded = new DevExpress.XtraEditors.SimpleButton();
            this.btnEndedList = new DevExpress.XtraEditors.SimpleButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnEnterList = new DevExpress.XtraEditors.SimpleButton();
            this.btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnEditAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnAditUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAditDelet = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnBusiness = new DevExpress.XtraEditors.SimpleButton();
            this.pnlDepo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDepo
            // 
            this.pnlDepo.Controls.Add(this.gridControl1);
            this.pnlDepo.Controls.Add(this.panel2);
            this.pnlDepo.Controls.Add(this.panel6);
            this.pnlDepo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDepo.Location = new System.Drawing.Point(0, 0);
            this.pnlDepo.Name = "pnlDepo";
            this.pnlDepo.Size = new System.Drawing.Size(825, 500);
            this.pnlDepo.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Entities.Concreate.Store);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 34);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(825, 416);
            this.gridControl1.TabIndex = 7;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 50);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel3.BackColor = System.Drawing.Color.Thistle;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnOut);
            this.panel3.Controls.Add(this.btnOutList);
            this.panel3.Location = new System.Drawing.Point(275, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(275, 50);
            this.panel3.TabIndex = 0;
            // 
            // btnOut
            // 
            this.btnOut.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.btnOut.Appearance.Options.UseFont = true;
            this.btnOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOut.ImageOptions.SvgImage")));
            this.btnOut.Location = new System.Drawing.Point(148, 0);
            this.btnOut.Name = "btnOut";
            this.btnOut.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnOut.Size = new System.Drawing.Size(125, 48);
            this.btnOut.TabIndex = 2;
            this.btnOut.Text = "Çıkarma";
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click_1);
            // 
            // btnOutList
            // 
            this.btnOutList.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.btnOutList.Appearance.Options.UseFont = true;
            this.btnOutList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnOutList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOutList.ImageOptions.SvgImage")));
            this.btnOutList.Location = new System.Drawing.Point(0, 0);
            this.btnOutList.Name = "btnOutList";
            this.btnOutList.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnOutList.Size = new System.Drawing.Size(125, 48);
            this.btnOutList.TabIndex = 1;
            this.btnOutList.Text = "Çıkarıldı";
            this.btnOutList.Click += new System.EventHandler(this.btnOutList_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Thistle;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnEnded);
            this.panel4.Controls.Add(this.btnEndedList);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(275, 50);
            this.panel4.TabIndex = 1;
            // 
            // btnEnded
            // 
            this.btnEnded.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.btnEnded.Appearance.Options.UseFont = true;
            this.btnEnded.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnded.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEnded.ImageOptions.SvgImage")));
            this.btnEnded.Location = new System.Drawing.Point(148, 0);
            this.btnEnded.Name = "btnEnded";
            this.btnEnded.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEnded.Size = new System.Drawing.Size(125, 48);
            this.btnEnded.TabIndex = 2;
            this.btnEnded.Text = "Yok Etme";
            this.btnEnded.Click += new System.EventHandler(this.btnEnded_Click_1);
            // 
            // btnEndedList
            // 
            this.btnEndedList.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.btnEndedList.Appearance.Options.UseFont = true;
            this.btnEndedList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEndedList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEndedList.ImageOptions.SvgImage")));
            this.btnEndedList.Location = new System.Drawing.Point(0, 0);
            this.btnEndedList.Name = "btnEndedList";
            this.btnEndedList.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEndedList.Size = new System.Drawing.Size(125, 48);
            this.btnEndedList.TabIndex = 1;
            this.btnEndedList.Text = "Yok Edildi";
            this.btnEndedList.Click += new System.EventHandler(this.btnEndedList_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Thistle;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnEnterList);
            this.panel5.Controls.Add(this.btnEnter);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(550, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 50);
            this.panel5.TabIndex = 1;
            // 
            // btnEnterList
            // 
            this.btnEnterList.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F);
            this.btnEnterList.Appearance.Options.UseFont = true;
            this.btnEnterList.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEnterList.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEnterList.ImageOptions.SvgImage")));
            this.btnEnterList.Location = new System.Drawing.Point(0, 0);
            this.btnEnterList.Name = "btnEnterList";
            this.btnEnterList.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEnterList.Size = new System.Drawing.Size(125, 48);
            this.btnEnterList.TabIndex = 1;
            this.btnEnterList.Text = "Girildi";
            this.btnEnterList.Click += new System.EventHandler(this.btnEnterList_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnter.Appearance.Options.UseFont = true;
            this.btnEnter.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnter.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEnter.ImageOptions.SvgImage")));
            this.btnEnter.Location = new System.Drawing.Point(148, 0);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEnter.Size = new System.Drawing.Size(125, 48);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Girdirme";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Controls.Add(this.btnBusiness);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(825, 34);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnEditAdd);
            this.panel7.Controls.Add(this.btnAditUpdate);
            this.panel7.Controls.Add(this.btnUpdate);
            this.panel7.Controls.Add(this.btnAditDelet);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(48, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(438, 34);
            this.panel7.TabIndex = 10;
            // 
            // btnEditAdd
            // 
            this.btnEditAdd.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAdd.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnEditAdd.Appearance.Options.UseFont = true;
            this.btnEditAdd.Appearance.Options.UseForeColor = true;
            this.btnEditAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditAdd.ImageOptions.SvgImage")));
            this.btnEditAdd.Location = new System.Drawing.Point(3, 0);
            this.btnEditAdd.Name = "btnEditAdd";
            this.btnEditAdd.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEditAdd.Size = new System.Drawing.Size(125, 34);
            this.btnEditAdd.TabIndex = 6;
            this.btnEditAdd.Text = "Ekle";
            this.btnEditAdd.Click += new System.EventHandler(this.btnEditAdd_Click);
            // 
            // btnAditUpdate
            // 
            this.btnAditUpdate.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAditUpdate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAditUpdate.Appearance.Options.UseFont = true;
            this.btnAditUpdate.Appearance.Options.UseForeColor = true;
            this.btnAditUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAditUpdate.ImageOptions.SvgImage")));
            this.btnAditUpdate.Location = new System.Drawing.Point(253, 0);
            this.btnAditUpdate.Name = "btnAditUpdate";
            this.btnAditUpdate.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAditUpdate.Size = new System.Drawing.Size(125, 34);
            this.btnAditUpdate.TabIndex = 4;
            this.btnAditUpdate.Text = "Günceleme";
            this.btnAditUpdate.Click += new System.EventHandler(this.btnAditUpdate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Appearance.Options.UseForeColor = true;
            this.btnUpdate.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(378, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnUpdate.Size = new System.Drawing.Size(40, 34);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAditDelet
            // 
            this.btnAditDelet.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAditDelet.Appearance.ForeColor = System.Drawing.Color.Tomato;
            this.btnAditDelet.Appearance.Options.UseFont = true;
            this.btnAditDelet.Appearance.Options.UseForeColor = true;
            this.btnAditDelet.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAditDelet.ImageOptions.SvgImage")));
            this.btnAditDelet.Location = new System.Drawing.Point(128, 0);
            this.btnAditDelet.Name = "btnAditDelet";
            this.btnAditDelet.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAditDelet.Size = new System.Drawing.Size(125, 34);
            this.btnAditDelet.TabIndex = 5;
            this.btnAditDelet.Text = "Sil";
            this.btnAditDelet.Click += new System.EventHandler(this.btnAditDelet_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(48, 34);
            this.panel1.TabIndex = 9;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(48, 34);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnBusiness
            // 
            this.btnBusiness.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusiness.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBusiness.Appearance.Options.UseFont = true;
            this.btnBusiness.Appearance.Options.UseForeColor = true;
            this.btnBusiness.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBusiness.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBusiness.ImageOptions.SvgImage")));
            this.btnBusiness.Location = new System.Drawing.Point(653, 0);
            this.btnBusiness.Name = "btnBusiness";
            this.btnBusiness.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnBusiness.Size = new System.Drawing.Size(172, 34);
            this.btnBusiness.TabIndex = 8;
            this.btnBusiness.Text = "Depo Haraketleri";
            this.btnBusiness.Click += new System.EventHandler(this.btnBusiness_Click);
            // 
            // DepoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 500);
            this.Controls.Add(this.pnlDepo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DepoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DepoUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlDepo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlDepo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.SimpleButton btnOut;
        private DevExpress.XtraEditors.SimpleButton btnOutList;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraEditors.SimpleButton btnEnded;
        private DevExpress.XtraEditors.SimpleButton btnEndedList;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btnEnterList;
        private DevExpress.XtraEditors.SimpleButton btnEnter;
        private System.Windows.Forms.Panel panel6;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAditUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAditDelet;
        private DevExpress.XtraEditors.SimpleButton btnEditAdd;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton btnBusiness;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel1;
    }
}