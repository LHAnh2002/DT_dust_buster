namespace AdministratorDustBuster
{
    partial class frmLogin
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
            this.lbTK = new DevExpress.XtraEditors.LabelControl();
            this.txtTK = new DevExpress.XtraEditors.TextEdit();
            this.btnDangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.txtMK = new DevExpress.XtraEditors.TextEdit();
            this.lbMK = new DevExpress.XtraEditors.LabelControl();
            this.linkQuenMK = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.lbNote = new DevExpress.XtraEditors.LabelControl();
            this.cbMK = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTK
            // 
            this.lbTK.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTK.Appearance.Options.UseFont = true;
            this.lbTK.Location = new System.Drawing.Point(10, 12);
            this.lbTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(56, 15);
            this.lbTK.TabIndex = 0;
            this.lbTK.Text = "Tài khoản:";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(74, 9);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTK.Name = "txtTK";
            this.txtTK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.Properties.Appearance.Options.UseFont = true;
            this.txtTK.Size = new System.Drawing.Size(130, 22);
            this.txtTK.TabIndex = 1;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Appearance.Options.UseFont = true;
            this.btnDangnhap.Location = new System.Drawing.Point(10, 65);
            this.btnDangnhap.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(194, 24);
            this.btnDangnhap.TabIndex = 3;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(74, 37);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMK.Name = "txtMK";
            this.txtMK.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Properties.Appearance.Options.UseFont = true;
            this.txtMK.Size = new System.Drawing.Size(102, 22);
            this.txtMK.TabIndex = 2;
            this.txtMK.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMK_KeyDown);
            // 
            // lbMK
            // 
            this.lbMK.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.Appearance.Options.UseFont = true;
            this.lbMK.Location = new System.Drawing.Point(10, 40);
            this.lbMK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(57, 15);
            this.lbMK.TabIndex = 5;
            this.lbMK.Text = "Mật Khẩu:";
            // 
            // linkQuenMK
            // 
            this.linkQuenMK.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkQuenMK.Appearance.Options.UseFont = true;
            this.linkQuenMK.Location = new System.Drawing.Point(10, 92);
            this.linkQuenMK.Name = "linkQuenMK";
            this.linkQuenMK.Size = new System.Drawing.Size(86, 15);
            this.linkQuenMK.TabIndex = 7;
            this.linkQuenMK.Text = "Quên Mật Khẩu";
            this.linkQuenMK.Click += new System.EventHandler(this.linkQuenMK_Click);
            // 
            // lbNote
            // 
            this.lbNote.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lbNote.Appearance.Options.UseFont = true;
            this.lbNote.Appearance.Options.UseForeColor = true;
            this.lbNote.Location = new System.Drawing.Point(10, 113);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(26, 15);
            this.lbNote.TabIndex = 8;
            this.lbNote.Text = "Note";
            // 
            // cbMK
            // 
            this.cbMK.Location = new System.Drawing.Point(183, 38);
            this.cbMK.Name = "cbMK";
            this.cbMK.Properties.Caption = "";
            this.cbMK.Size = new System.Drawing.Size(19, 22);
            this.cbMK.TabIndex = 9;
            this.cbMK.CheckedChanged += new System.EventHandler(this.cbMK_CheckedChanged);
            // 
            // frmLogin
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 134);
            this.Controls.Add(this.cbMK);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.linkQuenMK);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.lbTK);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.txtTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lbTK;
        private DevExpress.XtraEditors.TextEdit txtTK;
        private DevExpress.XtraEditors.SimpleButton btnDangnhap;
        private DevExpress.XtraEditors.TextEdit txtMK;
        private DevExpress.XtraEditors.LabelControl lbMK;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkQuenMK;
        private DevExpress.XtraEditors.LabelControl lbNote;
        private DevExpress.XtraEditors.CheckEdit cbMK;
    }
}