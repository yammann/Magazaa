namespace WebFormsUI
{
    partial class EmployeeAditUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeAditUI));
            this.pnlAdit = new System.Windows.Forms.Panel();
            this.cmpState = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.tbxAdres = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxSalary = new System.Windows.Forms.MaskedTextBox();
            this.tbxMail = new System.Windows.Forms.MaskedTextBox();
            this.tbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.tbxStartDate = new DevExpress.XtraEditors.DateTimeOffsetEdit();
            this.pnlAdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxStartDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAdit
            // 
            this.pnlAdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdit.Controls.Add(this.tbxStartDate);
            this.pnlAdit.Controls.Add(this.tbxPhone);
            this.pnlAdit.Controls.Add(this.tbxMail);
            this.pnlAdit.Controls.Add(this.tbxSalary);
            this.pnlAdit.Controls.Add(this.cmpState);
            this.pnlAdit.Controls.Add(this.label8);
            this.pnlAdit.Controls.Add(this.label5);
            this.pnlAdit.Controls.Add(this.label6);
            this.pnlAdit.Controls.Add(this.label7);
            this.pnlAdit.Controls.Add(this.pictureEdit1);
            this.pnlAdit.Controls.Add(this.btnClose);
            this.pnlAdit.Controls.Add(this.btnAdd);
            this.pnlAdit.Controls.Add(this.tbxAdres);
            this.pnlAdit.Controls.Add(this.tbxName);
            this.pnlAdit.Controls.Add(this.label4);
            this.pnlAdit.Controls.Add(this.label3);
            this.pnlAdit.Controls.Add(this.label2);
            this.pnlAdit.Controls.Add(this.label1);
            this.pnlAdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdit.Location = new System.Drawing.Point(0, 0);
            this.pnlAdit.Name = "pnlAdit";
            this.pnlAdit.Size = new System.Drawing.Size(400, 450);
            this.pnlAdit.TabIndex = 1;
            // 
            // cmpState
            // 
            this.cmpState.FormattingEnabled = true;
            this.cmpState.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cmpState.Location = new System.Drawing.Point(209, 372);
            this.cmpState.Name = "cmpState";
            this.cmpState.Size = new System.Drawing.Size(134, 21);
            this.cmpState.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 365);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Durum :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefon :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Email :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Maaş :";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(209, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(134, 96);
            this.pictureEdit1.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnClose.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClose.ImageOptions.SvgImage")));
            this.btnClose.Location = new System.Drawing.Point(363, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.Appearance.Options.UseForeColor = true;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdd.Location = new System.Drawing.Point(0, 413);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(398, 35);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxAdres
            // 
            this.tbxAdres.Location = new System.Drawing.Point(209, 164);
            this.tbxAdres.Name = "tbxAdres";
            this.tbxAdres.Size = new System.Drawing.Size(134, 20);
            this.tbxAdres.TabIndex = 2;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(209, 123);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(134, 20);
            this.tbxName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Başlangıç Tarih :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çalışan Adı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resim :";
            // 
            // tbxSalary
            // 
            this.tbxSalary.Location = new System.Drawing.Point(209, 246);
            this.tbxSalary.Mask = "0000000";
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.Size = new System.Drawing.Size(134, 20);
            this.tbxSalary.TabIndex = 15;
            this.tbxSalary.ValidatingType = typeof(int);
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(209, 285);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(134, 20);
            this.tbxMail.TabIndex = 16;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(209, 328);
            this.tbxPhone.Mask = "(999) 000-0000";
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(134, 20);
            this.tbxPhone.TabIndex = 17;
            // 
            // tbxStartDate
            // 
            this.tbxStartDate.EditValue = null;
            this.tbxStartDate.Location = new System.Drawing.Point(209, 205);
            this.tbxStartDate.Name = "tbxStartDate";
            this.tbxStartDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tbxStartDate.Properties.MaskSettings.Set("mask", "d");
            this.tbxStartDate.Properties.MaskSettings.Set("useAdvancingCaret", true);
            this.tbxStartDate.Properties.MaskSettings.Set("spinWithCarry", true);
            this.tbxStartDate.Size = new System.Drawing.Size(134, 20);
            this.tbxStartDate.TabIndex = 18;
            // 
            // EmployeeAditUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(this.pnlAdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeAditUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeAditUI";
            this.pnlAdit.ResumeLayout(false);
            this.pnlAdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbxStartDate.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnlAdit;
        public DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        public DevExpress.XtraEditors.SimpleButton btnAdd;
        public System.Windows.Forms.TextBox tbxAdres;
        public System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmpState;
        public System.Windows.Forms.MaskedTextBox tbxPhone;
        public System.Windows.Forms.MaskedTextBox tbxMail;
        public System.Windows.Forms.MaskedTextBox tbxSalary;
        public DevExpress.XtraEditors.DateTimeOffsetEdit tbxStartDate;
    }
}