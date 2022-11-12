namespace ControlAppDesktop.Forms
{
    partial class EmployeeUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeUpdateForm));
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.mtxbTC = new System.Windows.Forms.MaskedTextBox();
            this.lblAuthority = new System.Windows.Forms.Label();
            this.cbAuthority = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rtbxAdressInfo = new System.Windows.Forms.RichTextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.mtxtMail = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTel = new System.Windows.Forms.MaskedTextBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.txtSurnmaeInfo = new System.Windows.Forms.TextBox();
            this.txtNameInfo = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblBdate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.employeeSurname = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.mtxbTC);
            this.grpInfo.Controls.Add(this.lblAuthority);
            this.grpInfo.Controls.Add(this.cbAuthority);
            this.grpInfo.Controls.Add(this.dateTimePicker1);
            this.grpInfo.Controls.Add(this.rtbxAdressInfo);
            this.grpInfo.Controls.Add(this.lblAdress);
            this.grpInfo.Controls.Add(this.mtxtMail);
            this.grpInfo.Controls.Add(this.mtxtTel);
            this.grpInfo.Controls.Add(this.cbDepartment);
            this.grpInfo.Controls.Add(this.txtSurnmaeInfo);
            this.grpInfo.Controls.Add(this.txtNameInfo);
            this.grpInfo.Controls.Add(this.lblMail);
            this.grpInfo.Controls.Add(this.lblTel);
            this.grpInfo.Controls.Add(this.lblBdate);
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.department);
            this.grpInfo.Controls.Add(this.employeeSurname);
            this.grpInfo.Controls.Add(this.employeeName);
            this.grpInfo.Location = new System.Drawing.Point(50, 32);
            this.grpInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpInfo.Size = new System.Drawing.Size(478, 518);
            this.grpInfo.TabIndex = 5;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Kişi Bilgileri";
            this.grpInfo.Enter += new System.EventHandler(this.grpInfo_Enter);
            // 
            // mtxbTC
            // 
            this.mtxbTC.Enabled = false;
            this.mtxbTC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxbTC.Location = new System.Drawing.Point(117, 39);
            this.mtxbTC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mtxbTC.Mask = "00000000000";
            this.mtxbTC.Name = "mtxbTC";
            this.mtxbTC.Size = new System.Drawing.Size(265, 23);
            this.mtxbTC.TabIndex = 0;
            this.mtxbTC.ValidatingType = typeof(int);
            // 
            // lblAuthority
            // 
            this.lblAuthority.AutoSize = true;
            this.lblAuthority.Location = new System.Drawing.Point(10, 192);
            this.lblAuthority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthority.Name = "lblAuthority";
            this.lblAuthority.Size = new System.Drawing.Size(47, 16);
            this.lblAuthority.TabIndex = 34;
            this.lblAuthority.Text = "Yetki :";
            // 
            // cbAuthority
            // 
            this.cbAuthority.FormattingEnabled = true;
            this.cbAuthority.Location = new System.Drawing.Point(117, 189);
            this.cbAuthority.Margin = new System.Windows.Forms.Padding(4);
            this.cbAuthority.Name = "cbAuthority";
            this.cbAuthority.Size = new System.Drawing.Size(265, 24);
            this.cbAuthority.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(117, 229);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 23);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // rtbxAdressInfo
            // 
            this.rtbxAdressInfo.Location = new System.Drawing.Point(117, 346);
            this.rtbxAdressInfo.Margin = new System.Windows.Forms.Padding(4);
            this.rtbxAdressInfo.Name = "rtbxAdressInfo";
            this.rtbxAdressInfo.Size = new System.Drawing.Size(265, 117);
            this.rtbxAdressInfo.TabIndex = 8;
            this.rtbxAdressInfo.Text = "";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(10, 346);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(47, 16);
            this.lblAdress.TabIndex = 24;
            this.lblAdress.Text = "Adress";
            // 
            // mtxtMail
            // 
            this.mtxtMail.Location = new System.Drawing.Point(117, 307);
            this.mtxtMail.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtMail.Name = "mtxtMail";
            this.mtxtMail.Size = new System.Drawing.Size(265, 23);
            this.mtxtMail.TabIndex = 7;
            // 
            // mtxtTel
            // 
            this.mtxtTel.Location = new System.Drawing.Point(117, 268);
            this.mtxtTel.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtTel.Name = "mtxtTel";
            this.mtxtTel.Size = new System.Drawing.Size(265, 23);
            this.mtxtTel.TabIndex = 6;
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(117, 149);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(265, 24);
            this.cbDepartment.TabIndex = 3;
            // 
            // txtSurnmaeInfo
            // 
            this.txtSurnmaeInfo.Location = new System.Drawing.Point(117, 110);
            this.txtSurnmaeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurnmaeInfo.Name = "txtSurnmaeInfo";
            this.txtSurnmaeInfo.Size = new System.Drawing.Size(265, 23);
            this.txtSurnmaeInfo.TabIndex = 2;
            // 
            // txtNameInfo
            // 
            this.txtNameInfo.Location = new System.Drawing.Point(117, 71);
            this.txtNameInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameInfo.Name = "txtNameInfo";
            this.txtNameInfo.Size = new System.Drawing.Size(265, 23);
            this.txtNameInfo.TabIndex = 1;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(10, 311);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(38, 16);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "Mail:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(10, 271);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(54, 16);
            this.lblTel.TabIndex = 13;
            this.lblTel.Text = "Telefon:";
            // 
            // lblBdate
            // 
            this.lblBdate.AutoSize = true;
            this.lblBdate.Location = new System.Drawing.Point(7, 223);
            this.lblBdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBdate.Name = "lblBdate";
            this.lblBdate.Size = new System.Drawing.Size(96, 16);
            this.lblBdate.TabIndex = 11;
            this.lblBdate.Text = "Doğum Tarihi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC:";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Location = new System.Drawing.Point(7, 149);
            this.department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(79, 16);
            this.department.TabIndex = 8;
            this.department.Text = "Departman:";
            // 
            // employeeSurname
            // 
            this.employeeSurname.AutoSize = true;
            this.employeeSurname.Location = new System.Drawing.Point(8, 110);
            this.employeeSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeSurname.Name = "employeeSurname";
            this.employeeSurname.Size = new System.Drawing.Size(46, 16);
            this.employeeSurname.TabIndex = 3;
            this.employeeSurname.Text = "Soyad:";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(10, 66);
            this.employeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(27, 16);
            this.employeeName.TabIndex = 2;
            this.employeeName.Text = "Ad:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(234, 570);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ControlAppUICore.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(564, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 32);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // EmployeeUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(624, 637);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpInfo);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.updateEmployeeFrom_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblBdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.Label employeeSurname;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label lblAdress;
        public System.Windows.Forms.ComboBox cbDepartment;
        public System.Windows.Forms.TextBox txtSurnmaeInfo;
        public System.Windows.Forms.TextBox txtNameInfo;
        public System.Windows.Forms.MaskedTextBox mtxtMail;
        public System.Windows.Forms.MaskedTextBox mtxtTel;
        public System.Windows.Forms.RichTextBox rtbxAdressInfo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblAuthority;
        private System.Windows.Forms.ComboBox cbAuthority;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.MaskedTextBox mtxbTC;
    }
}