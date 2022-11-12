namespace ControlAppDesktop.Forms
{
    partial class CabinetDeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CabinetDeliveryForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbxCabinetDelivery = new System.Windows.Forms.GroupBox();
            this.btnCabinetDelivery = new System.Windows.Forms.Button();
            this.cbxDeliveryEmployee = new System.Windows.Forms.ComboBox();
            this.txtCabinetNo = new System.Windows.Forms.TextBox();
            this.lblDeliveryEmployee = new System.Windows.Forms.Label();
            this.lblCabinetNoInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxCabinetDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 76);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // gbxCabinetDelivery
            // 
            this.gbxCabinetDelivery.Controls.Add(this.btnCabinetDelivery);
            this.gbxCabinetDelivery.Controls.Add(this.cbxDeliveryEmployee);
            this.gbxCabinetDelivery.Controls.Add(this.txtCabinetNo);
            this.gbxCabinetDelivery.Controls.Add(this.lblDeliveryEmployee);
            this.gbxCabinetDelivery.Controls.Add(this.lblCabinetNoInfo);
            this.gbxCabinetDelivery.Location = new System.Drawing.Point(100, 132);
            this.gbxCabinetDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCabinetDelivery.Name = "gbxCabinetDelivery";
            this.gbxCabinetDelivery.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCabinetDelivery.Size = new System.Drawing.Size(491, 300);
            this.gbxCabinetDelivery.TabIndex = 6;
            this.gbxCabinetDelivery.TabStop = false;
            this.gbxCabinetDelivery.Text = "Dolap Teslim Et";
            // 
            // btnCabinetDelivery
            // 
            this.btnCabinetDelivery.Location = new System.Drawing.Point(192, 154);
            this.btnCabinetDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnCabinetDelivery.Name = "btnCabinetDelivery";
            this.btnCabinetDelivery.Size = new System.Drawing.Size(88, 28);
            this.btnCabinetDelivery.TabIndex = 2;
            this.btnCabinetDelivery.Text = "Teslim Et";
            this.btnCabinetDelivery.UseVisualStyleBackColor = true;
            this.btnCabinetDelivery.Click += new System.EventHandler(this.btnCabinetDelivery_Click);
            // 
            // cbxDeliveryEmployee
            // 
            this.cbxDeliveryEmployee.FormattingEnabled = true;
            this.cbxDeliveryEmployee.Location = new System.Drawing.Point(144, 81);
            this.cbxDeliveryEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDeliveryEmployee.Name = "cbxDeliveryEmployee";
            this.cbxDeliveryEmployee.Size = new System.Drawing.Size(225, 24);
            this.cbxDeliveryEmployee.TabIndex = 1;
            // 
            // txtCabinetNo
            // 
            this.txtCabinetNo.Location = new System.Drawing.Point(143, 41);
            this.txtCabinetNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCabinetNo.Name = "txtCabinetNo";
            this.txtCabinetNo.Size = new System.Drawing.Size(227, 22);
            this.txtCabinetNo.TabIndex = 0;
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
            // lblCabinetNoInfo
            // 
            this.lblCabinetNoInfo.AutoSize = true;
            this.lblCabinetNoInfo.Location = new System.Drawing.Point(7, 49);
            this.lblCabinetNoInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCabinetNoInfo.Name = "lblCabinetNoInfo";
            this.lblCabinetNoInfo.Size = new System.Drawing.Size(92, 16);
            this.lblCabinetNoInfo.TabIndex = 0;
            this.lblCabinetNoInfo.Text = "Çekmece No :";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ControlAppUICore.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(648, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 32);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CabinetDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(704, 610);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxCabinetDelivery);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CabinetDeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.CabinetDeliveryForm_Load);
            this.gbxCabinetDelivery.ResumeLayout(false);
            this.gbxCabinetDelivery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxCabinetDelivery;
        private System.Windows.Forms.Button btnCabinetDelivery;
        private System.Windows.Forms.ComboBox cbxDeliveryEmployee;
        private System.Windows.Forms.TextBox txtCabinetNo;
        private System.Windows.Forms.Label lblDeliveryEmployee;
        private System.Windows.Forms.Label lblCabinetNoInfo;
        private System.Windows.Forms.Button btnClose;
    }
}