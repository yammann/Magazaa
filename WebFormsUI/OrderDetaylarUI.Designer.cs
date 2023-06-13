namespace WebFormsUI
{
    partial class OrderDetaylarUI
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
            this.pnlOrderDetaylar = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantiti = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFinalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlOrderDetaylar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlOrderDetaylar
            // 
            this.pnlOrderDetaylar.Controls.Add(this.gridControl1);
            this.pnlOrderDetaylar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOrderDetaylar.Location = new System.Drawing.Point(0, 0);
            this.pnlOrderDetaylar.Name = "pnlOrderDetaylar";
            this.pnlOrderDetaylar.Size = new System.Drawing.Size(800, 450);
            this.pnlOrderDetaylar.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Entities.Concreate.oneOrder);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colOrderId,
            this.colProductId,
            this.colQuantiti,
            this.colPrice,
            this.coldiscount,
            this.colFinalPrice,
            this.colDdate});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colId, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colOrderId
            // 
            this.colOrderId.FieldName = "OrderId";
            this.colOrderId.Name = "colOrderId";
            this.colOrderId.Visible = true;
            this.colOrderId.VisibleIndex = 1;
            // 
            // colProductId
            // 
            this.colProductId.FieldName = "ProductId";
            this.colProductId.Name = "colProductId";
            this.colProductId.Visible = true;
            this.colProductId.VisibleIndex = 2;
            // 
            // colQuantiti
            // 
            this.colQuantiti.FieldName = "Quantiti";
            this.colQuantiti.Name = "colQuantiti";
            this.colQuantiti.Visible = true;
            this.colQuantiti.VisibleIndex = 3;
            // 
            // colPrice
            // 
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 4;
            // 
            // coldiscount
            // 
            this.coldiscount.FieldName = "discount";
            this.coldiscount.Name = "coldiscount";
            this.coldiscount.Visible = true;
            this.coldiscount.VisibleIndex = 5;
            // 
            // colFinalPrice
            // 
            this.colFinalPrice.FieldName = "FinalPrice";
            this.colFinalPrice.Name = "colFinalPrice";
            this.colFinalPrice.Visible = true;
            this.colFinalPrice.VisibleIndex = 6;
            // 
            // colDdate
            // 
            this.colDdate.FieldName = "Ddate";
            this.colDdate.Name = "colDdate";
            this.colDdate.Visible = true;
            this.colDdate.VisibleIndex = 7;
            // 
            // OrderDetaylarUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlOrderDetaylar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderDetaylarUI";
            this.Text = "OrderDetaylarUI";
            this.pnlOrderDetaylar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlOrderDetaylar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantiti;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn coldiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colFinalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colDdate;
    }
}