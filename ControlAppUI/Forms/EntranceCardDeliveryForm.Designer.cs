namespace ControlAppDesktop.Forms
{
    partial class EntranceCardDeliveryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntranceCardDeliveryForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gbxEntranceCardDelivery = new System.Windows.Forms.GroupBox();
            this.lbEtranceCard = new System.Windows.Forms.Label();
            this.btnHeadsetDelivery = new System.Windows.Forms.Button();
            this.cbxDeliveryEmployee = new System.Windows.Forms.ComboBox();
            this.txtEntranceCardSeriNo = new System.Windows.Forms.TextBox();
            this.lblDeliveryEmployee = new System.Windows.Forms.Label();
            this.lblEntranceCardSeriNoInfo = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxEntranceCardDelivery.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(63, 35);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // gbxEntranceCardDelivery
            // 
            this.gbxEntranceCardDelivery.Controls.Add(this.lbEtranceCard);
            this.gbxEntranceCardDelivery.Controls.Add(this.btnHeadsetDelivery);
            this.gbxEntranceCardDelivery.Controls.Add(this.cbxDeliveryEmployee);
            this.gbxEntranceCardDelivery.Controls.Add(this.txtEntranceCardSeriNo);
            this.gbxEntranceCardDelivery.Controls.Add(this.lblDeliveryEmployee);
            this.gbxEntranceCardDelivery.Controls.Add(this.lblEntranceCardSeriNoInfo);
            this.gbxEntranceCardDelivery.Location = new System.Drawing.Point(40, 90);
            this.gbxEntranceCardDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.gbxEntranceCardDelivery.Name = "gbxEntranceCardDelivery";
            this.gbxEntranceCardDelivery.Padding = new System.Windows.Forms.Padding(4);
            this.gbxEntranceCardDelivery.Size = new System.Drawing.Size(430, 222);
            this.gbxEntranceCardDelivery.TabIndex = 2;
            this.gbxEntranceCardDelivery.TabStop = false;
            // 
            // lbEtranceCard
            // 
            this.lbEtranceCard.AutoSize = true;
            this.lbEtranceCard.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbEtranceCard.Location = new System.Drawing.Point(7, 0);
            this.lbEtranceCard.Name = "lbEtranceCard";
            this.lbEtranceCard.Size = new System.Drawing.Size(105, 15);
            this.lbEtranceCard.TabIndex = 4;
            this.lbEtranceCard.Text = "Giriş Kartı Teslim Et";
            // 
            // btnHeadsetDelivery
            // 
            this.btnHeadsetDelivery.Location = new System.Drawing.Point(207, 131);
            this.btnHeadsetDelivery.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeadsetDelivery.Name = "btnHeadsetDelivery";
            this.btnHeadsetDelivery.Size = new System.Drawing.Size(88, 28);
            this.btnHeadsetDelivery.TabIndex = 2;
            this.btnHeadsetDelivery.Text = "Teslim Et";
            this.btnHeadsetDelivery.UseVisualStyleBackColor = true;
            this.btnHeadsetDelivery.Click += new System.EventHandler(this.btnHeadsetDelivery_Click);
            // 
            // cbxDeliveryEmployee
            // 
            this.cbxDeliveryEmployee.FormattingEnabled = true;
            this.cbxDeliveryEmployee.Location = new System.Drawing.Point(144, 81);
            this.cbxDeliveryEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.cbxDeliveryEmployee.Name = "cbxDeliveryEmployee";
            this.cbxDeliveryEmployee.Size = new System.Drawing.Size(205, 24);
            this.cbxDeliveryEmployee.TabIndex = 1;
            // 
            // txtEntranceCardSeriNo
            // 
            this.txtEntranceCardSeriNo.Location = new System.Drawing.Point(142, 41);
            this.txtEntranceCardSeriNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEntranceCardSeriNo.Name = "txtEntranceCardSeriNo";
            this.txtEntranceCardSeriNo.Size = new System.Drawing.Size(205, 22);
            this.txtEntranceCardSeriNo.TabIndex = 0;
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
            // lblEntranceCardSeriNoInfo
            // 
            this.lblEntranceCardSeriNoInfo.AutoSize = true;
            this.lblEntranceCardSeriNoInfo.Location = new System.Drawing.Point(7, 49);
            this.lblEntranceCardSeriNoInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntranceCardSeriNoInfo.Name = "lblEntranceCardSeriNoInfo";
            this.lblEntranceCardSeriNoInfo.Size = new System.Drawing.Size(110, 16);
            this.lblEntranceCardSeriNoInfo.TabIndex = 0;
            this.lblEntranceCardSeriNoInfo.Text = "Giriş Kartı Seri No :";
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
            // EntranceCardDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(528, 390);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.gbxEntranceCardDelivery);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EntranceCardDeliveryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.EntranceCardDeliveryForm_Load);
            this.gbxEntranceCardDelivery.ResumeLayout(false);
            this.gbxEntranceCardDelivery.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbxEntranceCardDelivery;
        private System.Windows.Forms.Button btnHeadsetDelivery;
        private System.Windows.Forms.ComboBox cbxDeliveryEmployee;
        private System.Windows.Forms.TextBox txtEntranceCardSeriNo;
        private System.Windows.Forms.Label lblDeliveryEmployee;
        private System.Windows.Forms.Label lblEntranceCardSeriNoInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbEtranceCard;
    }
}