namespace ControlAppDesktop.Forms
{
    partial class GuestCardDeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestCardDeliveryForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbxGuestCardDelivery = new System.Windows.Forms.GroupBox();
            this.btnGuestCardDelivery = new System.Windows.Forms.Button();
            this.cbxDeliveryEmployee = new System.Windows.Forms.ComboBox();
            this.txtGuestCardNo = new System.Windows.Forms.TextBox();
            this.lblDeliveryEmployee = new System.Windows.Forms.Label();
            this.lblNoInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxGuestCardDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(64, 32);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // gbxGuestCardDelivery
            // 
            this.gbxGuestCardDelivery.Controls.Add(this.btnGuestCardDelivery);
            this.gbxGuestCardDelivery.Controls.Add(this.cbxDeliveryEmployee);
            this.gbxGuestCardDelivery.Controls.Add(this.txtGuestCardNo);
            this.gbxGuestCardDelivery.Controls.Add(this.lblDeliveryEmployee);
            this.gbxGuestCardDelivery.Controls.Add(this.lblNoInfo);
            this.gbxGuestCardDelivery.Location = new System.Drawing.Point(44, 100);
            this.gbxGuestCardDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.gbxGuestCardDelivery.Name = "gbxGuestCardDelivery";
            this.gbxGuestCardDelivery.Padding = new System.Windows.Forms.Padding(4);
            this.gbxGuestCardDelivery.Size = new System.Drawing.Size(430, 222);
            this.gbxGuestCardDelivery.TabIndex = 8;
            this.gbxGuestCardDelivery.TabStop = false;
            this.gbxGuestCardDelivery.Text = "Misafir Kart Teslim Et";
            // 
            // btnGuestCardDelivery
            // 
            this.btnGuestCardDelivery.Location = new System.Drawing.Point(192, 154);
            this.btnGuestCardDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuestCardDelivery.Name = "btnGuestCardDelivery";
            this.btnGuestCardDelivery.Size = new System.Drawing.Size(88, 28);
            this.btnGuestCardDelivery.TabIndex = 2;
            this.btnGuestCardDelivery.Text = "Teslim Et";
            this.btnGuestCardDelivery.UseVisualStyleBackColor = true;
            this.btnGuestCardDelivery.Click += new System.EventHandler(this.btnGuestCardDelivery_Click);
            // 
            // cbxDeliveryEmployee
            // 
            this.cbxDeliveryEmployee.FormattingEnabled = true;
            this.cbxDeliveryEmployee.Location = new System.Drawing.Point(144, 81);
            this.cbxDeliveryEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDeliveryEmployee.Name = "cbxDeliveryEmployee";
            this.cbxDeliveryEmployee.Size = new System.Drawing.Size(226, 24);
            this.cbxDeliveryEmployee.TabIndex = 1;
            // 
            // txtGuestCardNo
            // 
            this.txtGuestCardNo.Location = new System.Drawing.Point(142, 41);
            this.txtGuestCardNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGuestCardNo.Name = "txtGuestCardNo";
            this.txtGuestCardNo.Size = new System.Drawing.Size(227, 22);
            this.txtGuestCardNo.TabIndex = 0;
            // 
            // lblDeliveryEmployee
            // 
            this.lblDeliveryEmployee.AutoSize = true;
            this.lblDeliveryEmployee.Location = new System.Drawing.Point(7, 85);
            this.lblDeliveryEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeliveryEmployee.Name = "lblDeliveryEmployee";
            this.lblDeliveryEmployee.Size = new System.Drawing.Size(132, 16);
            this.lblDeliveryEmployee.TabIndex = 1;
            this.lblDeliveryEmployee.Text = "Teslim Alan Personel :";
            // 
            // lblNoInfo
            // 
            this.lblNoInfo.AutoSize = true;
            this.lblNoInfo.Location = new System.Drawing.Point(7, 49);
            this.lblNoInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoInfo.Name = "lblNoInfo";
            this.lblNoInfo.Size = new System.Drawing.Size(92, 16);
            this.lblNoInfo.TabIndex = 0;
            this.lblNoInfo.Text = "Çekmece No :";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ControlAppUICore.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(483, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // GuestCardDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(528, 390);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxGuestCardDelivery);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GuestCardDeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.GuestCardDeliveryForm_Load);
            this.gbxGuestCardDelivery.ResumeLayout(false);
            this.gbxGuestCardDelivery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxGuestCardDelivery;
        private System.Windows.Forms.Button btnGuestCardDelivery;
        private System.Windows.Forms.ComboBox cbxDeliveryEmployee;
        private System.Windows.Forms.TextBox txtGuestCardNo;
        private System.Windows.Forms.Label lblDeliveryEmployee;
        private System.Windows.Forms.Label lblNoInfo;
        private System.Windows.Forms.Button btnClose;
    }
}