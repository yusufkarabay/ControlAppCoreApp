namespace ControlAppDesktop.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lblTcInfo = new System.Windows.Forms.Label();
            this.lblNameInfo = new System.Windows.Forms.Label();
            this.lblSurnameInfo = new System.Windows.Forms.Label();
            this.lblTelInfo = new System.Windows.Forms.Label();
            this.lblMailInfo = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.mtxtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.mtxbTC = new System.Windows.Forms.MaskedTextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTcInfo
            // 
            this.lblTcInfo.AutoSize = true;
            this.lblTcInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTcInfo.Location = new System.Drawing.Point(49, 89);
            this.lblTcInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTcInfo.Name = "lblTcInfo";
            this.lblTcInfo.Size = new System.Drawing.Size(28, 16);
            this.lblTcInfo.TabIndex = 0;
            this.lblTcInfo.Text = "TC :";
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNameInfo.Location = new System.Drawing.Point(49, 140);
            this.lblNameInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(30, 16);
            this.lblNameInfo.TabIndex = 1;
            this.lblNameInfo.Text = "Ad :";
            // 
            // lblSurnameInfo
            // 
            this.lblSurnameInfo.AutoSize = true;
            this.lblSurnameInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSurnameInfo.Location = new System.Drawing.Point(49, 191);
            this.lblSurnameInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSurnameInfo.Name = "lblSurnameInfo";
            this.lblSurnameInfo.Size = new System.Drawing.Size(44, 16);
            this.lblSurnameInfo.TabIndex = 2;
            this.lblSurnameInfo.Text = "Soyad";
            // 
            // lblTelInfo
            // 
            this.lblTelInfo.AutoSize = true;
            this.lblTelInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTelInfo.Location = new System.Drawing.Point(49, 345);
            this.lblTelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelInfo.Name = "lblTelInfo";
            this.lblTelInfo.Size = new System.Drawing.Size(56, 16);
            this.lblTelInfo.TabIndex = 5;
            this.lblTelInfo.Text = "Telefon :";
            // 
            // lblMailInfo
            // 
            this.lblMailInfo.AutoSize = true;
            this.lblMailInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMailInfo.Location = new System.Drawing.Point(49, 396);
            this.lblMailInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMailInfo.Name = "lblMailInfo";
            this.lblMailInfo.Size = new System.Drawing.Size(38, 16);
            this.lblMailInfo.TabIndex = 6;
            this.lblMailInfo.Text = "Mail :";
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(162)))), ((int)(((byte)(214)))));
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(165, 450);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(313, 41);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Kaydol";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(165, 139);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(312, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "Yusuf";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSurname.Location = new System.Drawing.Point(165, 189);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(312, 22);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.Text = "Karabay";
            // 
            // mtxtPhone
            // 
            this.mtxtPhone.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtxtPhone.Location = new System.Drawing.Point(165, 345);
            this.mtxtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtPhone.Mask = "(999) 000-0000";
            this.mtxtPhone.Name = "mtxtPhone";
            this.mtxtPhone.Size = new System.Drawing.Size(312, 22);
            this.mtxtPhone.TabIndex = 7;
            this.mtxtPhone.Text = "5542961722";
            this.mtxtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtTel_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtMail.Location = new System.Drawing.Point(165, 400);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(311, 22);
            this.txtMail.TabIndex = 8;
            this.txtMail.Text = "yusufkarabay21@gmail.com";
            // 
            // mtxbTC
            // 
            this.mtxbTC.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mtxbTC.Location = new System.Drawing.Point(165, 89);
            this.mtxbTC.Margin = new System.Windows.Forms.Padding(4);
            this.mtxbTC.Mask = "00000000000";
            this.mtxbTC.Name = "mtxbTC";
            this.mtxbTC.Size = new System.Drawing.Size(311, 22);
            this.mtxbTC.TabIndex = 0;
            this.mtxbTC.Text = "12345678987";
            this.mtxbTC.ValidatingType = typeof(int);
            this.mtxbTC.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtxbTC_MaskInputRejected);
            this.mtxbTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxbTC_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(165, 239);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(312, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "1";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(48, 246);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(51, 16);
            this.lblPassword.TabIndex = 17;
            this.lblPassword.Text = "Parola :";
            // 
            // txtRepassword
            // 
            this.txtRepassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRepassword.Location = new System.Drawing.Point(165, 289);
            this.txtRepassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(312, 22);
            this.txtRepassword.TabIndex = 4;
            this.txtRepassword.Text = "1";
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRePassword.Location = new System.Drawing.Point(48, 296);
            this.lblRePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(91, 16);
            this.lblRePassword.TabIndex = 19;
            this.lblRePassword.Text = "Tekrar Parola :";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClose.BackgroundImage = global::ControlAppUICore.Properties.Resources.back;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClose.Location = new System.Drawing.Point(14, 16);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(562, 850);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtRepassword);
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.mtxbTC);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.mtxtPhone);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.lblMailInfo);
            this.Controls.Add(this.lblTelInfo);
            this.Controls.Add(this.lblSurnameInfo);
            this.Controls.Add(this.lblNameInfo);
            this.Controls.Add(this.lblTcInfo);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTcInfo;
        private System.Windows.Forms.Label lblNameInfo;
        private System.Windows.Forms.Label lblSurnameInfo;
        private System.Windows.Forms.Label lblTelInfo;
        private System.Windows.Forms.Label lblMailInfo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.MaskedTextBox mtxtPhone;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.MaskedTextBox mtxbTC;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Button btnClose;
    }
}