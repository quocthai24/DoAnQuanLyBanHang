namespace QuanLyBanHangVer1
{
    partial class frmDangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.chkPass = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(117, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(117, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(301, 68);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(293, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(301, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(293, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(301, 232);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 51);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangNhap.Location = new System.Drawing.Point(470, 232);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(124, 51);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // chkPass
            // 
            this.chkPass.AutoSize = true;
            this.chkPass.Location = new System.Drawing.Point(301, 187);
            this.chkPass.Name = "chkPass";
            this.chkPass.Size = new System.Drawing.Size(140, 24);
            this.chkPass.TabIndex = 9;
            this.chkPass.Text = "Hiện Mật Khẩu";
            this.chkPass.UseVisualStyleBackColor = true;
            this.chkPass.CheckedChanged += new System.EventHandler(this.chkPass_CheckedChanged);
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkPass);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDangNhap";
            this.Text = "Màn Hình Đăng Nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.CheckBox chkPass;
    }
}

