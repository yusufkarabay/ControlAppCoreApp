namespace ControlAppDesktop.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.btnAuthorityForm = new System.Windows.Forms.Button();
            this.btnDepartmentForm = new System.Windows.Forms.Button();
            this.btnEmployeeChecked = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAuthorityForm
            // 
            this.btnAuthorityForm.Location = new System.Drawing.Point(27, 22);
            this.btnAuthorityForm.Name = "btnAuthorityForm";
            this.btnAuthorityForm.Size = new System.Drawing.Size(210, 50);
            this.btnAuthorityForm.TabIndex = 0;
            this.btnAuthorityForm.Text = "Yetki İşlemleri";
            this.btnAuthorityForm.UseVisualStyleBackColor = true;
          
            // 
            // btnDepartmentForm
            // 
            this.btnDepartmentForm.Location = new System.Drawing.Point(264, 22);
            this.btnDepartmentForm.Name = "btnDepartmentForm";
            this.btnDepartmentForm.Size = new System.Drawing.Size(205, 50);
            this.btnDepartmentForm.TabIndex = 1;
            this.btnDepartmentForm.Text = "Departman İşlemleri";
            this.btnDepartmentForm.UseVisualStyleBackColor = true;
            this.btnDepartmentForm.Click += new System.EventHandler(this.btnDepartmentForm_Click);
            // 
            // btnEmployeeChecked
            // 
            this.btnEmployeeChecked.Location = new System.Drawing.Point(515, 22);
            this.btnEmployeeChecked.Name = "btnEmployeeChecked";
            this.btnEmployeeChecked.Size = new System.Drawing.Size(205, 50);
            this.btnEmployeeChecked.TabIndex = 2;
            this.btnEmployeeChecked.Text = "Personel Onaylama İşlemleri";
            this.btnEmployeeChecked.UseVisualStyleBackColor = true;
            this.btnEmployeeChecked.Click += new System.EventHandler(this.btnEmployeeChecked_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1480, 913);
            this.Controls.Add(this.btnEmployeeChecked);
            this.Controls.Add(this.btnDepartmentForm);
            this.Controls.Add(this.btnAuthorityForm);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuthorityForm;
        private System.Windows.Forms.Button btnDepartmentForm;
        private System.Windows.Forms.Button btnEmployeeChecked;
    }
}