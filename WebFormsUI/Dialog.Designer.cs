namespace WebFormsUI
{
    partial class Dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dialog));
            this.pnlDialog = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDialog = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlColor = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlDialog.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDialog
            // 
            this.pnlDialog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDialog.Controls.Add(this.panel3);
            this.pnlDialog.Controls.Add(this.pictureBox1);
            this.pnlDialog.Controls.Add(this.PnlColor);
            this.pnlDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDialog.Location = new System.Drawing.Point(0, 0);
            this.pnlDialog.Name = "pnlDialog";
            this.pnlDialog.Size = new System.Drawing.Size(400, 75);
            this.pnlDialog.TabIndex = 0;
            this.pnlDialog.TabStop = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.lblDialog);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(78, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(306, 71);
            this.panel3.TabIndex = 1;
            // 
            // lblDialog
            // 
            this.lblDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDialog.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialog.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.lblDialog.Location = new System.Drawing.Point(0, 0);
            this.lblDialog.Name = "lblDialog";
            this.lblDialog.Size = new System.Drawing.Size(306, 71);
            this.lblDialog.TabIndex = 0;
            this.lblDialog.Text = "Messeg";
            this.lblDialog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDialog.Click += new System.EventHandler(this.lblDialog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PnlColor
            // 
            this.PnlColor.BackColor = System.Drawing.Color.Red;
            this.PnlColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PnlColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.PnlColor.Location = new System.Drawing.Point(384, 0);
            this.PnlColor.Name = "PnlColor";
            this.PnlColor.Size = new System.Drawing.Size(12, 71);
            this.PnlColor.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 75);
            this.ControlBox = false;
            this.Controls.Add(this.pnlDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog";
            this.TopMost = true;
            this.pnlDialog.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel pnlDialog;
        public System.Windows.Forms.Label lblDialog;
        public System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Panel PnlColor;
    }
}