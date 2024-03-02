namespace AdministratorDustBuster.UI
{
    partial class frmChangeEmail
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
            this.btnGuiMa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtotp = new DevExpress.XtraEditors.TextEdit();
            this.lbXM = new DevExpress.XtraEditors.LabelControl();
            this.txtemail = new DevExpress.XtraEditors.TextEdit();
            this.lbEmail = new DevExpress.XtraEditors.LabelControl();
            this.btnxmotp = new DevExpress.XtraEditors.SimpleButton();
            this.lbNote = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtotp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuiMa
            // 
            this.btnGuiMa.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuiMa.Appearance.Options.UseFont = true;
            this.btnGuiMa.Location = new System.Drawing.Point(168, 30);
            this.btnGuiMa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuiMa.Name = "btnGuiMa";
            this.btnGuiMa.Size = new System.Drawing.Size(74, 24);
            this.btnGuiMa.TabIndex = 14;
            this.btnGuiMa.Text = "Gửi Mã";
            this.btnGuiMa.Click += new System.EventHandler(this.btnGuiMa_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(177, 11);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 15);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "@gmail.com";
            // 
            // txtotp
            // 
            this.txtotp.Location = new System.Drawing.Point(54, 32);
            this.txtotp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtotp.Name = "txtotp";
            this.txtotp.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtotp.Properties.Appearance.Options.UseFont = true;
            this.txtotp.Size = new System.Drawing.Size(106, 22);
            this.txtotp.TabIndex = 13;
            // 
            // lbXM
            // 
            this.lbXM.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbXM.Appearance.Options.UseFont = true;
            this.lbXM.Location = new System.Drawing.Point(15, 35);
            this.lbXM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbXM.Name = "lbXM";
            this.lbXM.Size = new System.Drawing.Size(27, 15);
            this.lbXM.TabIndex = 16;
            this.lbXM.Text = "OTP:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(54, 8);
            this.txtemail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtemail.Name = "txtemail";
            this.txtemail.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.Properties.Appearance.Options.UseFont = true;
            this.txtemail.Size = new System.Drawing.Size(106, 22);
            this.txtemail.TabIndex = 12;
            // 
            // lbEmail
            // 
            this.lbEmail.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Appearance.Options.UseFont = true;
            this.lbEmail.Location = new System.Drawing.Point(15, 11);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(31, 15);
            this.lbEmail.TabIndex = 15;
            this.lbEmail.Text = "Email:";
            // 
            // btnxmotp
            // 
            this.btnxmotp.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxmotp.Appearance.Options.UseFont = true;
            this.btnxmotp.Location = new System.Drawing.Point(13, 56);
            this.btnxmotp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnxmotp.Name = "btnxmotp";
            this.btnxmotp.Size = new System.Drawing.Size(229, 24);
            this.btnxmotp.TabIndex = 18;
            this.btnxmotp.Text = "Xác Thực Email";
            this.btnxmotp.Click += new System.EventHandler(this.btnxmotp_Click);
            // 
            // lbNote
            // 
            this.lbNote.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNote.Appearance.ForeColor = System.Drawing.Color.Lime;
            this.lbNote.Appearance.Options.UseFont = true;
            this.lbNote.Appearance.Options.UseForeColor = true;
            this.lbNote.Location = new System.Drawing.Point(15, 86);
            this.lbNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbNote.Name = "lbNote";
            this.lbNote.Size = new System.Drawing.Size(26, 15);
            this.lbNote.TabIndex = 19;
            this.lbNote.Text = "Note";
            // 
            // frmChangeEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 105);
            this.Controls.Add(this.btnxmotp);
            this.Controls.Add(this.lbNote);
            this.Controls.Add(this.btnGuiMa);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtotp);
            this.Controls.Add(this.lbXM);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.lbEmail);
            this.MaximizeBox = false;
            this.Name = "frmChangeEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Email";
            ((System.ComponentModel.ISupportInitialize)(this.txtotp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnGuiMa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtotp;
        private DevExpress.XtraEditors.LabelControl lbXM;
        private DevExpress.XtraEditors.TextEdit txtemail;
        private DevExpress.XtraEditors.LabelControl lbEmail;
        private DevExpress.XtraEditors.SimpleButton btnxmotp;
        private DevExpress.XtraEditors.LabelControl lbNote;
    }
}