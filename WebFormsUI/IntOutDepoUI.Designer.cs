namespace WebFormsUI
{
    partial class IntOutDepoUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntOutDepoUI));
            this.pnlIntOutDepo = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBusiness = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBusinessDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colByPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantiti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSorceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.pnlIntOutDepo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlIntOutDepo
            // 
            this.pnlIntOutDepo.Controls.Add(this.simpleButton1);
            this.pnlIntOutDepo.Controls.Add(this.gridControl1);
            this.pnlIntOutDepo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlIntOutDepo.Location = new System.Drawing.Point(0, 0);
            this.pnlIntOutDepo.Name = "pnlIntOutDepo";
            this.pnlIntOutDepo.Size = new System.Drawing.Size(825, 500);
            this.pnlIntOutDepo.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Entities.Concreate.IntOutStore);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(825, 500);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBusiness,
            this.colBusinessDate,
            this.colByPrice,
            this.colNote,
            this.colId,
            this.colProductId,
            this.colProductName,
            this.colQuantiti,
            this.colSorceName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colBusiness
            // 
            this.colBusiness.FieldName = "Business";
            this.colBusiness.Name = "colBusiness";
            this.colBusiness.Visible = true;
            this.colBusiness.VisibleIndex = 0;
            // 
            // colBusinessDate
            // 
            this.colBusinessDate.FieldName = "BusinessDate";
            this.colBusinessDate.Name = "colBusinessDate";
            this.colBusinessDate.Visible = true;
            this.colBusinessDate.VisibleIndex = 1;
            // 
            // colByPrice
            // 
            this.colByPrice.FieldName = "ByPrice";
            this.colByPrice.Name = "colByPrice";
            this.colByPrice.Visible = true;
            this.colByPrice.VisibleIndex = 2;
            // 
            // colNote
            // 
            this.colNote.FieldName = "Note";
            this.colNote.Name = "colNote";
            this.colNote.Visible = true;
            this.colNote.VisibleIndex = 3;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 4;
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 5;
            // 
            // colProductName
            // 
            this.colProductName.FieldName = "ProductName";
            this.colProductName.Name = "colProductName";
            this.colProductName.Visible = true;
            this.colProductName.VisibleIndex = 6;
            // 
            // colQuantiti
            // 
            this.colQuantiti.FieldName = "Quantiti";
            this.colQuantiti.Name = "colQuantiti";
            this.colQuantiti.Visible = true;
            this.colQuantiti.VisibleIndex = 7;
            // 
            // colSorceName
            // 
            this.colSorceName.FieldName = "SorceName";
            this.colSorceName.Name = "colSorceName";
            this.colSorceName.Visible = true;
            this.colSorceName.VisibleIndex = 8;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(0, 0);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(47, 33);
            this.simpleButton1.TabIndex = 10;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // IntOutDepoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 500);
            this.Controls.Add(this.pnlIntOutDepo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IntOutDepoUI";
            this.Text = "IntOutDepoUI";
            this.pnlIntOutDepo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colBusiness;
        private DevExpress.XtraGrid.Columns.GridColumn colBusinessDate;
        private DevExpress.XtraGrid.Columns.GridColumn colByPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colNote;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantiti;
        private DevExpress.XtraGrid.Columns.GridColumn colSorceName;
        public System.Windows.Forms.Panel pnlIntOutDepo;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}