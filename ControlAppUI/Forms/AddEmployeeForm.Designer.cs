namespace ControlAppUICore.Forms
{
    partial class AddEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeeForm));
            this.btnEmployeeAdd = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.chebUser = new System.Windows.Forms.CheckBox();
            this.lblAuthority = new System.Windows.Forms.Label();
            this.cmbAuthority = new System.Windows.Forms.ComboBox();
            this.txtRepassword = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblIsUser = new System.Windows.Forms.Label();
            this.dtpEmployeeBDate = new System.Windows.Forms.DateTimePicker();
            this.rtbxAdressInfo = new System.Windows.Forms.RichTextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.mtxtMail = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.cbDepartmentInfo = new System.Windows.Forms.ComboBox();
            this.txtSurnmaeInfo = new System.Windows.Forms.TextBox();
            this.txtNameInfo = new System.Windows.Forms.TextBox();
            this.mtxtTcInfo = new System.Windows.Forms.MaskedTextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblBdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.employeeSurname = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEmployeeAdd
            // 
            this.btnEmployeeAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmployeeAdd.BackgroundImage")));
            this.btnEmployeeAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmployeeAdd.FlatAppearance.BorderSize = 0;
            this.btnEmployeeAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeAdd.Location = new System.Drawing.Point(310, 622);
            this.btnEmployeeAdd.Name = "btnEmployeeAdd";
            this.btnEmployeeAdd.Size = new System.Drawing.Size(30, 32);
            this.btnEmployeeAdd.TabIndex = 12;
            this.btnEmployeeAdd.UseVisualStyleBackColor = true;
            this.btnEmployeeAdd.Click += new System.EventHandler(this.btnEmployeeAdd_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.chebUser);
            this.grpInfo.Controls.Add(this.lblAuthority);
            this.grpInfo.Controls.Add(this.cmbAuthority);
            this.grpInfo.Controls.Add(this.txtRepassword);
            this.grpInfo.Controls.Add(this.lblRePassword);
            this.grpInfo.Controls.Add(this.txtPassword);
            this.grpInfo.Controls.Add(this.lblPassword);
            this.grpInfo.Controls.Add(this.lblIsUser);
            this.grpInfo.Controls.Add(this.dtpEmployeeBDate);
            this.grpInfo.Controls.Add(this.rtbxAdressInfo);
            this.grpInfo.Controls.Add(this.lblAdress);
            this.grpInfo.Controls.Add(this.mtxtMail);
            this.grpInfo.Controls.Add(this.mtxtTel);
            this.grpInfo.Controls.Add(this.cbDepartmentInfo);
            this.grpInfo.Controls.Add(this.txtSurnmaeInfo);
            this.grpInfo.Controls.Add(this.txtNameInfo);
            this.grpInfo.Controls.Add(this.mtxtTcInfo);
            this.grpInfo.Controls.Add(this.lblMail);
            this.grpInfo.Controls.Add(this.lblTel);
            this.grpInfo.Controls.Add(this.lblBdate);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.department);
            this.grpInfo.Controls.Add(this.employeeSurname);
            this.grpInfo.Controls.Add(this.employeeName);
            this.grpInfo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpInfo.Location = new System.Drawing.Point(58, 35);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(524, 566);
            this.grpInfo.TabIndex = 6;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Kişi Bilgileri";
            // 
            // chebUser
            // 
            this.chebUser.AutoSize = true;
            this.chebUser.Location = new System.Drawing.Point(179, 385);
            this.chebUser.Name = "chebUser";
            this.chebUser.Size = new System.Drawing.Size(54, 21);
            this.chebUser.TabIndex = 8;
            this.chebUser.Text = "Evet";
            this.chebUser.UseVisualStyleBackColor = true;
            this.chebUser.CheckedChanged += new System.EventHandler(this.chebUser_CheckedChanged);
            // 
            // lblAuthority
            // 
            this.lblAuthority.AutoSize = true;
            this.lblAuthority.Location = new System.Drawing.Point(79, 526);
            this.lblAuthority.Name = "lblAuthority";
            this.lblAuthority.Size = new System.Drawing.Size(43, 17);
            this.lblAuthority.TabIndex = 32;
            this.lblAuthority.Text = "Yetki :";
            this.lblAuthority.Visible = false;
            // 
            // cmbAuthority
            // 
            this.cmbAuthority.FormattingEnabled = true;
            this.cmbAuthority.Location = new System.Drawing.Point(179, 518);
            this.cmbAuthority.Name = "cmbAuthority";
            this.cmbAuthority.Size = new System.Drawing.Size(216, 25);
            this.cmbAuthority.TabIndex = 11;
            this.cmbAuthority.Visible = false;
            // 
            // txtRepassword
            // 
            this.txtRepassword.Location = new System.Drawing.Point(178, 474);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Size = new System.Drawing.Size(312, 22);
            this.txtRepassword.TabIndex = 10;
            this.txtRepassword.Visible = false;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(73, 481);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(90, 17);
            this.lblRePassword.TabIndex = 30;
            this.lblRePassword.Text = "Tekrar Parola :";
            this.lblRePassword.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(178, 437);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(312, 22);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.Visible = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(76, 440);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 17);
            this.lblPassword.TabIndex = 29;
            this.lblPassword.Text = "Parola :";
            this.lblPassword.Visible = false;
            // 
            // lblIsUser
            // 
            this.lblIsUser.AutoSize = true;
            this.lblIsUser.Location = new System.Drawing.Point(73, 385);
            this.lblIsUser.Name = "lblIsUser";
            this.lblIsUser.Size = new System.Drawing.Size(84, 17);
            this.lblIsUser.TabIndex = 10;
            this.lblIsUser.Text = "Kullanıcı mı ?";
            // 
            // dtpEmployeeBDate
            // 
            this.dtpEmployeeBDate.Location = new System.Drawing.Point(179, 167);
            this.dtpEmployeeBDate.Name = "dtpEmployeeBDate";
            this.dtpEmployeeBDate.Size = new System.Drawing.Size(312, 22);
            this.dtpEmployeeBDate.TabIndex = 4;
            // 
            // rtbxAdressInfo
            // 
            this.rtbxAdressInfo.Location = new System.Drawing.Point(179, 280);
            this.rtbxAdressInfo.Name = "rtbxAdressInfo";
            this.rtbxAdressInfo.Size = new System.Drawing.Size(312, 96);
            this.rtbxAdressInfo.TabIndex = 7;
            this.rtbxAdressInfo.Text = "";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(76, 289);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(47, 17);
            this.lblAdress.TabIndex = 24;
            this.lblAdress.Text = "Adress";
            // 
            // mtxtMail
            // 
            this.mtxtMail.Location = new System.Drawing.Point(179, 243);
            this.mtxtMail.Name = "mtxtMail";
            this.mtxtMail.Size = new System.Drawing.Size(312, 22);
            this.mtxtMail.TabIndex = 6;
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(179, 206);
            this.mtxtTel.Mask = "(999) 000-0000";
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(312, 22);
            this.mtxtTel.TabIndex = 5;
            // 
            // cbDepartmentInfo
            // 
            this.cbDepartmentInfo.FormattingEnabled = true;
            this.cbDepartmentInfo.Location = new System.Drawing.Point(179, 131);
            this.cbDepartmentInfo.Name = "cbDepartmentInfo";
            this.cbDepartmentInfo.Size = new System.Drawing.Size(312, 25);
            this.cbDepartmentInfo.TabIndex = 3;
            // 
            // txtSurnmaeInfo
            // 
            this.txtSurnmaeInfo.Location = new System.Drawing.Point(179, 95);
            this.txtSurnmaeInfo.Name = "txtSurnmaeInfo";
            this.txtSurnmaeInfo.Size = new System.Drawing.Size(312, 22);
            this.txtSurnmaeInfo.TabIndex = 2;
            // 
            // txtNameInfo
            // 
            this.txtNameInfo.Location = new System.Drawing.Point(179, 58);
            this.txtNameInfo.Name = "txtNameInfo";
            this.txtNameInfo.Size = new System.Drawing.Size(312, 22);
            this.txtNameInfo.TabIndex = 1;
            // 
            // mtxtTcInfo
            // 
            this.mtxtTcInfo.Location = new System.Drawing.Point(179, 17);
            this.mtxtTcInfo.Mask = "00000000000";
            this.mtxtTcInfo.Name = "mtxtTcInfo";
            this.mtxtTcInfo.Size = new System.Drawing.Size(312, 22);
            this.mtxtTcInfo.TabIndex = 0;
            this.mtxtTcInfo.ValidatingType = typeof(int);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(76, 243);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(36, 17);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(74, 208);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(54, 17);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Telefon:";
            // 
            // lblBdate
            // 
            this.lblBdate.AutoSize = true;
            this.lblBdate.Location = new System.Drawing.Point(74, 173);
            this.lblBdate.Name = "lblBdate";
            this.lblBdate.Size = new System.Drawing.Size(87, 17);
            this.lblBdate.TabIndex = 11;
            this.lblBdate.Text = "Doğum Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC:";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Location = new System.Drawing.Point(74, 137);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(79, 17);
            this.department.TabIndex = 8;
            this.department.Text = "Departman:";
            // 
            // employeeSurname
            // 
            this.employeeSurname.AutoSize = true;
            this.employeeSurname.Location = new System.Drawing.Point(74, 102);
            this.employeeSurname.Name = "employeeSurname";
            this.employeeSurname.Size = new System.Drawing.Size(48, 17);
            this.employeeSurname.TabIndex = 3;
            this.employeeSurname.Text = "Soyad:";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(74, 65);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(28, 17);
            this.employeeName.TabIndex = 2;
            this.employeeName.Text = "Ad:";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ControlAppUICore.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(588, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 32);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(641, 718);
            this.Controls.Add(this.btnEmployeeAdd);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.AddEmployeeForm_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEmployeeAdd;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.CheckBox chebUser;
        private System.Windows.Forms.Label lblAuthority;
        private System.Windows.Forms.ComboBox cmbAuthority;
        private System.Windows.Forms.TextBox txtRepassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblIsUser;
        private System.Windows.Forms.DateTimePicker dtpEmployeeBDate;
        public System.Windows.Forms.RichTextBox rtbxAdressInfo;
        private System.Windows.Forms.Label lblAdress;
        public System.Windows.Forms.MaskedTextBox mtxtMail;
        public System.Windows.Forms.MaskedTextBox mtxtTel;
        public System.Windows.Forms.ComboBox cbDepartmentInfo;
        public System.Windows.Forms.TextBox txtSurnmaeInfo;
        public System.Windows.Forms.TextBox txtNameInfo;
        public System.Windows.Forms.MaskedTextBox mtxtTcInfo;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblBdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label employeeSurname;
        private System.Windows.Forms.Label employeeName;
    }
}