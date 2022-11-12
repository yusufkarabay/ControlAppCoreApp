namespace ControlAppDesktop.Forms
{
    partial class GeneratorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorForm));
            this.dtpFirst = new System.Windows.Forms.DateTimePicker();
            this.dtpSecond = new System.Windows.Forms.DateTimePicker();
            this.txtWorkedTime = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddWorkedTime = new System.Windows.Forms.Button();
            this.btnTimeSearch = new System.Windows.Forms.Button();
            this.lblWorkedTime = new System.Windows.Forms.Label();
            this.lblLastFullTime = new System.Windows.Forms.Label();
            this.lblLastFullTimeInfo = new System.Windows.Forms.Label();
            this.lblLastFullEmployee = new System.Windows.Forms.Label();
            this.lblAllWorkedTime = new System.Windows.Forms.Label();
            this.lblLastYear = new System.Windows.Forms.Label();
            this.lblLastWorked = new System.Windows.Forms.Label();
            this.lblListByTwoTime = new System.Windows.Forms.Label();
            this.lblFirstTime = new System.Windows.Forms.Label();
            this.lblSecondTime = new System.Windows.Forms.Label();
            this.lblListByTwoTimeInfo = new System.Windows.Forms.Label();
            this.lblAllWorkedTimeInfo = new System.Windows.Forms.Label();
            this.lblLastYearInfo = new System.Windows.Forms.Label();
            this.lblLastWorkedInfo = new System.Windows.Forms.Label();
            this.lblLastFullEmployeeInfo = new System.Windows.Forms.Label();
            this.btnFull = new System.Windows.Forms.Button();
            this.lblThreeMonth = new System.Windows.Forms.Label();
            this.lblThreeMonthInfo = new System.Windows.Forms.Label();
            this.lblSixMonthInfo = new System.Windows.Forms.Label();
            this.lblSixMonth = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFirst
            // 
            this.dtpFirst.Location = new System.Drawing.Point(311, 119);
            this.dtpFirst.Name = "dtpFirst";
            this.dtpFirst.Size = new System.Drawing.Size(200, 21);
            this.dtpFirst.TabIndex = 0;
            // 
            // dtpSecond
            // 
            this.dtpSecond.Location = new System.Drawing.Point(539, 119);
            this.dtpSecond.Name = "dtpSecond";
            this.dtpSecond.Size = new System.Drawing.Size(200, 21);
            this.dtpSecond.TabIndex = 1;
            // 
            // txtWorkedTime
            // 
            this.txtWorkedTime.Location = new System.Drawing.Point(556, 289);
            this.txtWorkedTime.Name = "txtWorkedTime";
            this.txtWorkedTime.Size = new System.Drawing.Size(59, 21);
            this.txtWorkedTime.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.editToolStripMenuItem.Text = "Düzenle";
            // 
            // btnAddWorkedTime
            // 
            this.btnAddWorkedTime.BackgroundImage = global::ControlAppUICore.Properties.Resources.plus;
            this.btnAddWorkedTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddWorkedTime.FlatAppearance.BorderSize = 0;
            this.btnAddWorkedTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddWorkedTime.Location = new System.Drawing.Point(556, 329);
            this.btnAddWorkedTime.Name = "btnAddWorkedTime";
            this.btnAddWorkedTime.Size = new System.Drawing.Size(32, 32);
            this.btnAddWorkedTime.TabIndex = 19;
            this.btnAddWorkedTime.UseVisualStyleBackColor = true;
            this.btnAddWorkedTime.Click += new System.EventHandler(this.btnAddWorkedTime_Click);
            // 
            // btnTimeSearch
            // 
            this.btnTimeSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnTimeSearch.FlatAppearance.BorderSize = 0;
            this.btnTimeSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimeSearch.Location = new System.Drawing.Point(487, 164);
            this.btnTimeSearch.Name = "btnTimeSearch";
            this.btnTimeSearch.Size = new System.Drawing.Size(108, 23);
            this.btnTimeSearch.TabIndex = 1;
            this.btnTimeSearch.Text = "Listele";
            this.btnTimeSearch.UseVisualStyleBackColor = false;
            this.btnTimeSearch.Click += new System.EventHandler(this.btnTimeSearch_Click);
            // 
            // lblWorkedTime
            // 
            this.lblWorkedTime.AutoSize = true;
            this.lblWorkedTime.Location = new System.Drawing.Point(445, 292);
            this.lblWorkedTime.Name = "lblWorkedTime";
            this.lblWorkedTime.Size = new System.Drawing.Size(97, 15);
            this.lblWorkedTime.TabIndex = 21;
            this.lblWorkedTime.Text = "Çalışma Zamanı :";
            // 
            // lblLastFullTime
            // 
            this.lblLastFullTime.AutoSize = true;
            this.lblLastFullTime.Location = new System.Drawing.Point(844, 297);
            this.lblLastFullTime.Name = "lblLastFullTime";
            this.lblLastFullTime.Size = new System.Drawing.Size(134, 15);
            this.lblLastFullTime.TabIndex = 22;
            this.lblLastFullTime.Text = "Son Yakıt Alma Zamanı :";
            // 
            // lblLastFullTimeInfo
            // 
            this.lblLastFullTimeInfo.AutoSize = true;
            this.lblLastFullTimeInfo.Location = new System.Drawing.Point(998, 297);
            this.lblLastFullTimeInfo.Name = "lblLastFullTimeInfo";
            this.lblLastFullTimeInfo.Size = new System.Drawing.Size(49, 15);
            this.lblLastFullTimeInfo.TabIndex = 23;
            this.lblLastFullTimeInfo.Text = "00.00.00";
            // 
            // lblLastFullEmployee
            // 
            this.lblLastFullEmployee.AutoSize = true;
            this.lblLastFullEmployee.Location = new System.Drawing.Point(847, 336);
            this.lblLastFullEmployee.Name = "lblLastFullEmployee";
            this.lblLastFullEmployee.Size = new System.Drawing.Size(140, 15);
            this.lblLastFullEmployee.TabIndex = 24;
            this.lblLastFullEmployee.Text = "Son Yakıt Alan Personel :";
            // 
            // lblAllWorkedTime
            // 
            this.lblAllWorkedTime.AutoSize = true;
            this.lblAllWorkedTime.Location = new System.Drawing.Point(84, 276);
            this.lblAllWorkedTime.Name = "lblAllWorkedTime";
            this.lblAllWorkedTime.Size = new System.Drawing.Size(100, 15);
            this.lblAllWorkedTime.TabIndex = 25;
            this.lblAllWorkedTime.Text = "Toplam Kullanım :";
            // 
            // lblLastYear
            // 
            this.lblLastYear.AutoSize = true;
            this.lblLastYear.Location = new System.Drawing.Point(84, 307);
            this.lblLastYear.Name = "lblLastYear";
            this.lblLastYear.Size = new System.Drawing.Size(161, 15);
            this.lblLastYear.TabIndex = 26;
            this.lblLastYear.Text = "Bulunduğumuz Yıl Kullanımı :";
            // 
            // lblLastWorked
            // 
            this.lblLastWorked.AutoSize = true;
            this.lblLastWorked.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastWorked.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLastWorked.Location = new System.Drawing.Point(84, 412);
            this.lblLastWorked.Name = "lblLastWorked";
            this.lblLastWorked.Size = new System.Drawing.Size(98, 16);
            this.lblLastWorked.TabIndex = 29;
            this.lblLastWorked.Text = "Son Kullanım :";
            // 
            // lblListByTwoTime
            // 
            this.lblListByTwoTime.AutoSize = true;
            this.lblListByTwoTime.Location = new System.Drawing.Point(769, 125);
            this.lblListByTwoTime.Name = "lblListByTwoTime";
            this.lblListByTwoTime.Size = new System.Drawing.Size(160, 15);
            this.lblListByTwoTime.TabIndex = 30;
            this.lblListByTwoTime.Text = "Sorgulama Aralığı Kullanımı :";
            // 
            // lblFirstTime
            // 
            this.lblFirstTime.AutoSize = true;
            this.lblFirstTime.Location = new System.Drawing.Point(311, 100);
            this.lblFirstTime.Name = "lblFirstTime";
            this.lblFirstTime.Size = new System.Drawing.Size(92, 15);
            this.lblFirstTime.TabIndex = 31;
            this.lblFirstTime.Text = "Başlangıç Tarihi";
            // 
            // lblSecondTime
            // 
            this.lblSecondTime.AutoSize = true;
            this.lblSecondTime.Location = new System.Drawing.Point(556, 100);
            this.lblSecondTime.Name = "lblSecondTime";
            this.lblSecondTime.Size = new System.Drawing.Size(60, 15);
            this.lblSecondTime.TabIndex = 32;
            this.lblSecondTime.Text = "Bitiş Tarihi";
            // 
            // lblListByTwoTimeInfo
            // 
            this.lblListByTwoTimeInfo.AutoSize = true;
            this.lblListByTwoTimeInfo.Location = new System.Drawing.Point(950, 126);
            this.lblListByTwoTimeInfo.Name = "lblListByTwoTimeInfo";
            this.lblListByTwoTimeInfo.Size = new System.Drawing.Size(0, 15);
            this.lblListByTwoTimeInfo.TabIndex = 36;
            // 
            // lblAllWorkedTimeInfo
            // 
            this.lblAllWorkedTimeInfo.AutoSize = true;
            this.lblAllWorkedTimeInfo.Location = new System.Drawing.Point(272, 276);
            this.lblAllWorkedTimeInfo.Name = "lblAllWorkedTimeInfo";
            this.lblAllWorkedTimeInfo.Size = new System.Drawing.Size(19, 15);
            this.lblAllWorkedTimeInfo.TabIndex = 37;
            this.lblAllWorkedTimeInfo.Text = "00";
            // 
            // lblLastYearInfo
            // 
            this.lblLastYearInfo.AutoSize = true;
            this.lblLastYearInfo.Location = new System.Drawing.Point(272, 307);
            this.lblLastYearInfo.Name = "lblLastYearInfo";
            this.lblLastYearInfo.Size = new System.Drawing.Size(19, 15);
            this.lblLastYearInfo.TabIndex = 38;
            this.lblLastYearInfo.Text = "00";
            // 
            // lblLastWorkedInfo
            // 
            this.lblLastWorkedInfo.AutoSize = true;
            this.lblLastWorkedInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastWorkedInfo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblLastWorkedInfo.Location = new System.Drawing.Point(272, 412);
            this.lblLastWorkedInfo.Name = "lblLastWorkedInfo";
            this.lblLastWorkedInfo.Size = new System.Drawing.Size(21, 16);
            this.lblLastWorkedInfo.TabIndex = 41;
            this.lblLastWorkedInfo.Text = "00";
            // 
            // lblLastFullEmployeeInfo
            // 
            this.lblLastFullEmployeeInfo.AutoSize = true;
            this.lblLastFullEmployeeInfo.Location = new System.Drawing.Point(1001, 336);
            this.lblLastFullEmployeeInfo.Name = "lblLastFullEmployeeInfo";
            this.lblLastFullEmployeeInfo.Size = new System.Drawing.Size(59, 15);
            this.lblLastFullEmployeeInfo.TabIndex = 42;
            this.lblLastFullEmployeeInfo.Text = "Employee";
            // 
            // btnFull
            // 
            this.btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFull.Location = new System.Drawing.Point(896, 369);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(133, 23);
            this.btnFull.TabIndex = 2;
            this.btnFull.Text = "Yakıt Alındı";
            this.btnFull.UseVisualStyleBackColor = true;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // lblThreeMonth
            // 
            this.lblThreeMonth.AutoSize = true;
            this.lblThreeMonth.Location = new System.Drawing.Point(84, 369);
            this.lblThreeMonth.Name = "lblThreeMonth";
            this.lblThreeMonth.Size = new System.Drawing.Size(111, 15);
            this.lblThreeMonth.TabIndex = 44;
            this.lblThreeMonth.Text = "Son 3 Ay Kullanımı :";
            // 
            // lblThreeMonthInfo
            // 
            this.lblThreeMonthInfo.AutoSize = true;
            this.lblThreeMonthInfo.Location = new System.Drawing.Point(272, 369);
            this.lblThreeMonthInfo.Name = "lblThreeMonthInfo";
            this.lblThreeMonthInfo.Size = new System.Drawing.Size(19, 15);
            this.lblThreeMonthInfo.TabIndex = 45;
            this.lblThreeMonthInfo.Text = "00";
            // 
            // lblSixMonthInfo
            // 
            this.lblSixMonthInfo.AutoSize = true;
            this.lblSixMonthInfo.Location = new System.Drawing.Point(272, 338);
            this.lblSixMonthInfo.Name = "lblSixMonthInfo";
            this.lblSixMonthInfo.Size = new System.Drawing.Size(19, 15);
            this.lblSixMonthInfo.TabIndex = 47;
            this.lblSixMonthInfo.Text = "00";
            // 
            // lblSixMonth
            // 
            this.lblSixMonth.AutoSize = true;
            this.lblSixMonth.Location = new System.Drawing.Point(84, 338);
            this.lblSixMonth.Name = "lblSixMonth";
            this.lblSixMonth.Size = new System.Drawing.Size(111, 15);
            this.lblSixMonth.TabIndex = 46;
            this.lblSixMonth.Text = "Son 6 Ay Kullanımı :";
            // 
            // GeneratorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.lblSixMonthInfo);
            this.Controls.Add(this.lblSixMonth);
            this.Controls.Add(this.lblThreeMonthInfo);
            this.Controls.Add(this.lblThreeMonth);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.lblLastFullEmployeeInfo);
            this.Controls.Add(this.lblLastWorkedInfo);
            this.Controls.Add(this.lblLastYearInfo);
            this.Controls.Add(this.lblAllWorkedTimeInfo);
            this.Controls.Add(this.lblListByTwoTimeInfo);
            this.Controls.Add(this.lblSecondTime);
            this.Controls.Add(this.lblFirstTime);
            this.Controls.Add(this.lblListByTwoTime);
            this.Controls.Add(this.lblLastWorked);
            this.Controls.Add(this.lblLastYear);
            this.Controls.Add(this.lblAllWorkedTime);
            this.Controls.Add(this.lblLastFullEmployee);
            this.Controls.Add(this.lblLastFullTimeInfo);
            this.Controls.Add(this.lblLastFullTime);
            this.Controls.Add(this.lblWorkedTime);
            this.Controls.Add(this.btnTimeSearch);
            this.Controls.Add(this.btnAddWorkedTime);
            this.Controls.Add(this.txtWorkedTime);
            this.Controls.Add(this.dtpSecond);
            this.Controls.Add(this.dtpFirst);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneratorForm";
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.GeneratorForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFirst;
        private System.Windows.Forms.DateTimePicker dtpSecond;
        private System.Windows.Forms.TextBox txtWorkedTime;
        private System.Windows.Forms.Button btnAddWorkedTime;
        private System.Windows.Forms.Button btnTimeSearch;
        private System.Windows.Forms.Label lblWorkedTime;
        private System.Windows.Forms.Label lblLastFullTime;
        private System.Windows.Forms.Label lblLastFullTimeInfo;
        private System.Windows.Forms.Label lblLastFullEmployee;
        private System.Windows.Forms.Label lblAllWorkedTime;
        private System.Windows.Forms.Label lblLastYear;
        private System.Windows.Forms.Label lblLastWorked;
        private System.Windows.Forms.Label lblListByTwoTime;
        private System.Windows.Forms.Label lblFirstTime;
        private System.Windows.Forms.Label lblSecondTime;
        private System.Windows.Forms.Label lblListByTwoTimeInfo;
        private System.Windows.Forms.Label lblAllWorkedTimeInfo;
        private System.Windows.Forms.Label lblLastYearInfo;
        private System.Windows.Forms.Label lblLastWorkedInfo;
        private System.Windows.Forms.Label lblLastFullEmployeeInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Label lblThreeMonth;
        private System.Windows.Forms.Label lblThreeMonthInfo;
        private System.Windows.Forms.Label lblSixMonthInfo;
        private System.Windows.Forms.Label lblSixMonth;
    }
}