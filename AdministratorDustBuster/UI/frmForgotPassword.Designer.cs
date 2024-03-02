namespace AdministratorDustBuster.UI
{
    partial class frmForgotPassword
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
            this.txtotp = new DevExpress.XtraEditors.TextEdit();
            this.lbXM = new DevExpress.XtraEditors.LabelControl();
            this.txtemail = new DevExpress.XtraEditors.TextEdit();
            this.lbEmail = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnGuiMa = new DevExpress.XtraEditors.SimpleButton();
            this.txtnlmk = new DevExpress.XtraEditors.TextEdit();
            this.lbnl = new DevExpress.XtraEditors.LabelControl();
            this.txtmk = new DevExpress.XtraEditors.TextEdit();
            this.lbMK = new DevExpress.XtraEditors.LabelControl();
            this.lbNote = new DevExpress.XtraEditors.LabelControl();
            this.btnDLMK = new DevExpress.XtraEditors.SimpleButton();
            this.btnxmotp = new DevExpress.XtraEditors.SimpleButton();
            this.cbMK = new DevExpress.XtraEditors.CheckEdit();
            this.cbNLMK = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtotp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnlmk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNLMK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtotp
            // 
            this.txtotp.Location = new System.Drawing.Point(51, 26);
            this.txtotp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtotp.Name = "txtotp";
            this.txtotp.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotp.Properties.Appearance.Options.UseFont = true;
            this.txtotp.Size = new System.Drawing.Size(106, 22);
            this.txtotp.TabIndex = 2;
            // 
            // lbXM
            // 
            this.lbXM.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXM.Appearance.Options.UseFont = true;
            this.lbXM.Location = new System.Drawing.Point(12, 29);
            this.lbXM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbXM.Name = "lbXM";
            this.lbXM.Size = new System.Drawing.Size(27, 15);
            this.lbXM.TabIndex = 9;
            this.lbXM.Text = "OTP:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(51, 2);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtemail.Name = "txtemail";
            this.txtemail.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Properties.Appearance.Options.UseFont = true;
            this.txtemail.Size = new System.Drawing.Size(106, 22);
            this.txtemail.TabIndex = 1;
            // 
            // lbEmail
            // 
            this.lbEmail.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Appearance.Options.UseFont = true;
            this.lbEmail.Location = new System.Drawing.Point(12, 5);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(31, 15);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "Email:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(174, 5);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 15);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "@gmail.com";
            // 
            // btnGuiMa
            // 
            this.btnGuiMa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiMa.Appearance.Options.UseFont = true;
            this.btnGuiMa.Location = new System.Drawing.Point(165, 24);
            this.btnGuiMa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuiMa.Name = "btnGuiMa";
            this.btnGuiMa.Size = new System.Drawing.Size(74, 24);
            this.btnGuiMa.TabIndex = 3;
            this.btnGuiMa.Text = "Gửi Mã";
            this.btnGuiMa.Click += new System.EventHandler(this.btnGuiMa_Click);
            // 
            // txtnlmk
            // 
            this.txtnlmk.Enabled = false;
            this.txtnlmk.Location = new System.Drawing.Point(77, 108);
            this.txtnlmk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtnlmk.Name = "txtnlmk";
            this.txtnlmk.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnlmk.Properties.Appearance.Options.UseFont = true;
            this.txtnlmk.Size = new System.Drawing.Size(138, 22);
            this.txtnlmk.TabIndex = 6;
            // 
            // lbnl
            // 
            this.lbnl.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnl.Appearance.Options.UseFont = true;
            this.lbnl.Enabled = false;
            this.lbnl.Location = new System.Drawing.Point(12, 111);
            this.lbnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbnl.Name = "lbnl";
            this.lbnl.Size = new System.Drawing.Size(51, 15);
            this.lbnl.TabIndex = 15;
            this.lbnl.Text = "Nhập Lại:";
            // 
            // txtmk
            // 
            this.txtmk.Enabled = false;
            this.txtmk.Location = new System.Drawing.Point(77, 84);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmk.Name = "txtmk";
            this.txtmk.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Properties.Appearance.Options.UseFont = true;
            this.txtmk.Size = new System.Drawing.Size(138, 22);
            this.txtmk.TabIndex = 5;
            // 
            // lbMK
            // 
            this.lbMK.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMK.Appearance.Options.UseFont = true;
            this.lbMK.Enabled = false;
            this.lbMK.Location = new System.Drawing.Point(12, 87);
            this.lbMK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(57, 15);
            this.lbMK.TabIndex = 13;
            this.lbMK.Text = "Mật Khẩu:";
            // 
            // lbNote
            // 
            this.lbNote.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lbNote.Appearance.Options.UseFont = true;
            this.lbNote.Appearance.Options.UseForeColor = true;
            this.lbNote.Location = new System.Drawing.Point(12, 162);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(26, 15);
            this.lbNote.TabIndex = 17;
            this.lbNote.Text = "Note";
            // 
            // btnDLMK
            // 
            this.btnDLMK.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDLMK.Appearance.Options.UseFont = true;
            this.btnDLMK.Enabled = false;
            this.btnDLMK.Location = new System.Drawing.Point(13, 132);
            this.btnDLMK.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDLMK.Name = "btnDLMK";
            this.btnDLMK.Size = new System.Drawing.Size(226, 24);
            this.btnDLMK.TabIndex = 7;
            this.btnDLMK.Text = "Đặt lại mật khẩu";
            this.btnDLMK.Click += new System.EventHandler(this.btnDLMK_Click);
            // 
            // btnxmotp
            // 
            this.btnxmotp.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxmotp.Appearance.Options.UseFont = true;
            this.btnxmotp.Location = new System.Drawing.Point(13, 54);
            this.btnxmotp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnxmotp.Name = "btnxmotp";
            this.btnxmotp.Size = new System.Drawing.Size(226, 24);
            this.btnxmotp.TabIndex = 4;
            this.btnxmotp.Text = "Xác minh mã OTP";
            this.btnxmotp.Click += new System.EventHandler(this.btnxmotp_Click);
            // 
            // cbMK
            // 
            this.cbMK.Enabled = false;
            this.cbMK.Location = new System.Drawing.Point(220, 87);
            this.cbMK.Name = "cbMK";
            this.cbMK.Properties.Caption = "";
            this.cbMK.Size = new System.Drawing.Size(19, 20);
            this.cbMK.TabIndex = 8;
            this.cbMK.CheckedChanged += new System.EventHandler(this.cbMK_CheckedChanged);
            // 
            // cbNLMK
            // 
            this.cbNLMK.Enabled = false;
            this.cbNLMK.Location = new System.Drawing.Point(220, 110);
            this.cbNLMK.Name = "cbNLMK";
            this.cbNLMK.Properties.Caption = "";
            this.cbNLMK.Size = new System.Drawing.Size(19, 20);
            this.cbNLMK.TabIndex = 9;
            this.cbNLMK.CheckedChanged += new System.EventHandler(this.cbNLMK_CheckedChanged);
            // 
            // frmForgotPassword
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 183);
            this.Controls.Add(this.cbNLMK);
            this.Controls.Add(this.cbMK);
            this.Controls.Add(this.btnxmotp);
            this.Controls.Add(this.btnDLMK);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.txtnlmk);
            this.Controls.Add(this.lbnl);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.lbMK);
            this.Controls.Add(this.btnGuiMa);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtotp);
            this.Controls.Add(this.lbXM);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lbEmail);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quên Mật Khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.txtotp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnlmk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNLMK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtotp;
        private DevExpress.XtraEditors.LabelControl lbXM;
        private DevExpress.XtraEditors.TextEdit txtemail;
        private DevExpress.XtraEditors.LabelControl lbEmail;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuiMa;
        private DevExpress.XtraEditors.TextEdit txtnlmk;
        private DevExpress.XtraEditors.LabelControl lbnl;
        private DevExpress.XtraEditors.TextEdit txtmk;
        private DevExpress.XtraEditors.LabelControl lbMK;
        private DevExpress.XtraEditors.LabelControl lbNote;
        private DevExpress.XtraEditors.SimpleButton btnDLMK;
        private DevExpress.XtraEditors.SimpleButton btnxmotp;
        private DevExpress.XtraEditors.CheckEdit cbMK;
        private DevExpress.XtraEditors.CheckEdit cbNLMK;
    }
}