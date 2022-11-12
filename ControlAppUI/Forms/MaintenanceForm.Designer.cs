namespace ControlAppDesktop.Forms
{
    partial class MaintenanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceForm));
            this.lblContractName = new System.Windows.Forms.Label();
            this.lblContractStartTime = new System.Windows.Forms.Label();
            this.lblContractCompany = new System.Windows.Forms.Label();
            this.lblCompanyAdress = new System.Windows.Forms.Label();
            this.lblContractCompanyTel = new System.Windows.Forms.Label();
            this.lblContractNotes = new System.Windows.Forms.Label();
            this.gbContract = new System.Windows.Forms.GroupBox();
            this.dgvContract = new System.Windows.Forms.DataGridView();
            this.contextMenuStripContract = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbMaintanance = new System.Windows.Forms.GroupBox();
            this.dgvMaintenance = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbContractInfo = new System.Windows.Forms.GroupBox();
            this.dtpContractEndTime = new System.Windows.Forms.DateTimePicker();
            this.lblContractEndTime = new System.Windows.Forms.Label();
            this.rtbContractNotes = new System.Windows.Forms.RichTextBox();
            this.txtCompanyTel = new System.Windows.Forms.TextBox();
            this.btnContractAdd = new System.Windows.Forms.Button();
            this.btnContractList = new System.Windows.Forms.Button();
            this.dtpContractStartTime = new System.Windows.Forms.DateTimePicker();
            this.btnContractUpdate = new System.Windows.Forms.Button();
            this.txtCompanyAdress = new System.Windows.Forms.TextBox();
            this.txtContractCompany = new System.Windows.Forms.TextBox();
            this.txtContractName = new System.Windows.Forms.TextBox();
            this.gbMaintananceInfo = new System.Windows.Forms.GroupBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbContractSelect = new System.Windows.Forms.ComboBox();
            this.dtpFirstMaintenance = new System.Windows.Forms.DateTimePicker();
            this.btnMaintananceList = new System.Windows.Forms.Button();
            this.btnMaintananceAdd = new System.Windows.Forms.Button();
            this.btnMaintananceUpdate = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblContractSelect = new System.Windows.Forms.Label();
            this.lblFirstMaintenance = new System.Windows.Forms.Label();
            this.MaintenanceMail = new System.Windows.Forms.Button();
            this.gbContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.contextMenuStripContract.SuspendLayout();
            this.gbMaintanance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbContractInfo.SuspendLayout();
            this.gbMaintananceInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContractName
            // 
            this.lblContractName.AutoSize = true;
            this.lblContractName.Location = new System.Drawing.Point(19, 30);
            this.lblContractName.Name = "lblContractName";
            this.lblContractName.Size = new System.Drawing.Size(83, 15);
            this.lblContractName.TabIndex = 0;
            this.lblContractName.Text = "Sözleşme Adı :";
            // 
            // lblContractStartTime
            // 
            this.lblContractStartTime.AutoSize = true;
            this.lblContractStartTime.Location = new System.Drawing.Point(19, 63);
            this.lblContractStartTime.Name = "lblContractStartTime";
            this.lblContractStartTime.Size = new System.Drawing.Size(108, 15);
            this.lblContractStartTime.TabIndex = 1;
            this.lblContractStartTime.Text = "Başlangıç Zamanı :";
            // 
            // lblContractCompany
            // 
            this.lblContractCompany.AutoSize = true;
            this.lblContractCompany.Location = new System.Drawing.Point(19, 126);
            this.lblContractCompany.Name = "lblContractCompany";
            this.lblContractCompany.Size = new System.Drawing.Size(138, 15);
            this.lblContractCompany.TabIndex = 2;
            this.lblContractCompany.Text = "Sözleşme Yapılan Firma :";
            // 
            // lblCompanyAdress
            // 
            this.lblCompanyAdress.AutoSize = true;
            this.lblCompanyAdress.Location = new System.Drawing.Point(19, 159);
            this.lblCompanyAdress.Name = "lblCompanyAdress";
            this.lblCompanyAdress.Size = new System.Drawing.Size(76, 15);
            this.lblCompanyAdress.TabIndex = 3;
            this.lblCompanyAdress.Text = "Firma Adres :";
            // 
            // lblContractCompanyTel
            // 
            this.lblContractCompanyTel.AutoSize = true;
            this.lblContractCompanyTel.Location = new System.Drawing.Point(19, 192);
            this.lblContractCompanyTel.Name = "lblContractCompanyTel";
            this.lblContractCompanyTel.Size = new System.Drawing.Size(84, 15);
            this.lblContractCompanyTel.TabIndex = 4;
            this.lblContractCompanyTel.Text = "Firma Telefon :";
            // 
            // lblContractNotes
            // 
            this.lblContractNotes.AutoSize = true;
            this.lblContractNotes.Location = new System.Drawing.Point(19, 225);
            this.lblContractNotes.Name = "lblContractNotes";
            this.lblContractNotes.Size = new System.Drawing.Size(101, 15);
            this.lblContractNotes.TabIndex = 5;
            this.lblContractNotes.Text = "Sözleşme Notları :";
            // 
            // gbContract
            // 
            this.gbContract.Controls.Add(this.dgvContract);
            this.gbContract.Location = new System.Drawing.Point(120, 363);
            this.gbContract.Name = "gbContract";
            this.gbContract.Size = new System.Drawing.Size(914, 269);
            this.gbContract.TabIndex = 25;
            this.gbContract.TabStop = false;
            this.gbContract.Text = "Sözleşme Listesi";
            this.gbContract.Visible = false;
            // 
            // dgvContract
            // 
            this.dgvContract.AllowUserToAddRows = false;
            this.dgvContract.AllowUserToDeleteRows = false;
            this.dgvContract.AllowUserToResizeColumns = false;
            this.dgvContract.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvContract.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContract.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContract.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvContract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.ContextMenuStrip = this.contextMenuStripContract;
            this.dgvContract.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvContract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContract.Location = new System.Drawing.Point(3, 17);
            this.dgvContract.MultiSelect = false;
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.ReadOnly = true;
            this.dgvContract.RowHeadersVisible = false;
            this.dgvContract.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContract.Size = new System.Drawing.Size(908, 249);
            this.dgvContract.TabIndex = 2;
            // 
            // contextMenuStripContract
            // 
            this.contextMenuStripContract.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStripContract.Name = "contextMenuStripContract";
            this.contextMenuStripContract.Size = new System.Drawing.Size(121, 48);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.updateToolStripMenuItem.Text = "Güncelle";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.deleteToolStripMenuItem.Text = "Sil";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // gbMaintanance
            // 
            this.gbMaintanance.Controls.Add(this.dgvMaintenance);
            this.gbMaintanance.Location = new System.Drawing.Point(114, 363);
            this.gbMaintanance.Name = "gbMaintanance";
            this.gbMaintanance.Size = new System.Drawing.Size(914, 269);
            this.gbMaintanance.TabIndex = 26;
            this.gbMaintanance.TabStop = false;
            this.gbMaintanance.Text = "Bakım Listesi";
            this.gbMaintanance.Visible = false;
            // 
            // dgvMaintenance
            // 
            this.dgvMaintenance.AllowUserToAddRows = false;
            this.dgvMaintenance.AllowUserToDeleteRows = false;
            this.dgvMaintenance.AllowUserToResizeColumns = false;
            this.dgvMaintenance.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.dgvMaintenance.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMaintenance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMaintenance.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaintenance.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMaintenance.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaintenance.Location = new System.Drawing.Point(3, 17);
            this.dgvMaintenance.MultiSelect = false;
            this.dgvMaintenance.Name = "dgvMaintenance";
            this.dgvMaintenance.ReadOnly = true;
            this.dgvMaintenance.RowHeadersVisible = false;
            this.dgvMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaintenance.Size = new System.Drawing.Size(908, 249);
            this.dgvMaintenance.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateMaintenanceToolStripMenuItem,
            this.deleteMaintenanceToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // updateMaintenanceToolStripMenuItem
            // 
            this.updateMaintenanceToolStripMenuItem.Name = "updateMaintenanceToolStripMenuItem";
            this.updateMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.updateMaintenanceToolStripMenuItem.Text = "Güncelle";
            this.updateMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.updateMaintenanceToolStripMenuItem_Click);
            // 
            // deleteMaintenanceToolStripMenuItem
            // 
            this.deleteMaintenanceToolStripMenuItem.Name = "deleteMaintenanceToolStripMenuItem";
            this.deleteMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.deleteMaintenanceToolStripMenuItem.Text = "Sil";
            this.deleteMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.deleteMaintenanceToolStripMenuItem_Click);
            // 
            // gbContractInfo
            // 
            this.gbContractInfo.Controls.Add(this.dtpContractEndTime);
            this.gbContractInfo.Controls.Add(this.lblContractEndTime);
            this.gbContractInfo.Controls.Add(this.rtbContractNotes);
            this.gbContractInfo.Controls.Add(this.txtCompanyTel);
            this.gbContractInfo.Controls.Add(this.btnContractAdd);
            this.gbContractInfo.Controls.Add(this.btnContractList);
            this.gbContractInfo.Controls.Add(this.dtpContractStartTime);
            this.gbContractInfo.Controls.Add(this.btnContractUpdate);
            this.gbContractInfo.Controls.Add(this.txtCompanyAdress);
            this.gbContractInfo.Controls.Add(this.txtContractCompany);
            this.gbContractInfo.Controls.Add(this.txtContractName);
            this.gbContractInfo.Controls.Add(this.lblContractName);
            this.gbContractInfo.Controls.Add(this.lblContractStartTime);
            this.gbContractInfo.Controls.Add(this.lblContractNotes);
            this.gbContractInfo.Controls.Add(this.lblContractCompany);
            this.gbContractInfo.Controls.Add(this.lblContractCompanyTel);
            this.gbContractInfo.Controls.Add(this.lblCompanyAdress);
            this.gbContractInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbContractInfo.Location = new System.Drawing.Point(31, 12);
            this.gbContractInfo.Name = "gbContractInfo";
            this.gbContractInfo.Size = new System.Drawing.Size(450, 329);
            this.gbContractInfo.TabIndex = 26;
            this.gbContractInfo.TabStop = false;
            this.gbContractInfo.Text = "Sözleşme Bilgileri";
            // 
            // dtpContractEndTime
            // 
            this.dtpContractEndTime.Location = new System.Drawing.Point(188, 87);
            this.dtpContractEndTime.Name = "dtpContractEndTime";
            this.dtpContractEndTime.Size = new System.Drawing.Size(244, 21);
            this.dtpContractEndTime.TabIndex = 2;
            // 
            // lblContractEndTime
            // 
            this.lblContractEndTime.AutoSize = true;
            this.lblContractEndTime.Location = new System.Drawing.Point(19, 96);
            this.lblContractEndTime.Name = "lblContractEndTime";
            this.lblContractEndTime.Size = new System.Drawing.Size(79, 15);
            this.lblContractEndTime.TabIndex = 16;
            this.lblContractEndTime.Text = "Bitiş  Zamanı :";
            // 
            // rtbContractNotes
            // 
            this.rtbContractNotes.Location = new System.Drawing.Point(188, 212);
            this.rtbContractNotes.Name = "rtbContractNotes";
            this.rtbContractNotes.Size = new System.Drawing.Size(244, 71);
            this.rtbContractNotes.TabIndex = 6;
            this.rtbContractNotes.Text = "";
            // 
            // txtCompanyTel
            // 
            this.txtCompanyTel.Location = new System.Drawing.Point(188, 186);
            this.txtCompanyTel.Name = "txtCompanyTel";
            this.txtCompanyTel.Size = new System.Drawing.Size(244, 21);
            this.txtCompanyTel.TabIndex = 5;
            this.txtCompanyTel.Text = "Firma Telefon...";
            this.txtCompanyTel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCompanyTel_MouseClick);
            // 
            // btnContractAdd
            // 
            this.btnContractAdd.BackgroundImage = global::ControlAppUICore.Properties.Resources.plus;
            this.btnContractAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContractAdd.FlatAppearance.BorderSize = 0;
            this.btnContractAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContractAdd.Location = new System.Drawing.Point(277, 289);
            this.btnContractAdd.Name = "btnContractAdd";
            this.btnContractAdd.Size = new System.Drawing.Size(32, 32);
            this.btnContractAdd.TabIndex = 7;
            this.btnContractAdd.UseVisualStyleBackColor = true;
            this.btnContractAdd.Click += new System.EventHandler(this.btnContractAdd_Click);
            // 
            // btnContractList
            // 
            this.btnContractList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnContractList.FlatAppearance.BorderSize = 0;
            this.btnContractList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContractList.Location = new System.Drawing.Point(20, 300);
            this.btnContractList.Name = "btnContractList";
            this.btnContractList.Size = new System.Drawing.Size(75, 23);
            this.btnContractList.TabIndex = 8;
            this.btnContractList.Text = "Listele";
            this.btnContractList.UseVisualStyleBackColor = false;
            this.btnContractList.Click += new System.EventHandler(this.btnContractList_Click);
            // 
            // dtpContractStartTime
            // 
            this.dtpContractStartTime.Location = new System.Drawing.Point(188, 57);
            this.dtpContractStartTime.Name = "dtpContractStartTime";
            this.dtpContractStartTime.Size = new System.Drawing.Size(244, 21);
            this.dtpContractStartTime.TabIndex = 1;
            // 
            // btnContractUpdate
            // 
            this.btnContractUpdate.BackgroundImage = global::ControlAppUICore.Properties.Resources.upload;
            this.btnContractUpdate.FlatAppearance.BorderSize = 0;
            this.btnContractUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContractUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnContractUpdate.Location = new System.Drawing.Point(378, 289);
            this.btnContractUpdate.Name = "btnContractUpdate";
            this.btnContractUpdate.Size = new System.Drawing.Size(32, 32);
            this.btnContractUpdate.TabIndex = 9;
            this.btnContractUpdate.UseVisualStyleBackColor = true;
            this.btnContractUpdate.Visible = false;
            this.btnContractUpdate.Click += new System.EventHandler(this.btnContractUpdate_Click);
            // 
            // txtCompanyAdress
            // 
            this.txtCompanyAdress.Location = new System.Drawing.Point(188, 156);
            this.txtCompanyAdress.Name = "txtCompanyAdress";
            this.txtCompanyAdress.Size = new System.Drawing.Size(244, 21);
            this.txtCompanyAdress.TabIndex = 4;
            this.txtCompanyAdress.Text = "Firma Adresi...";
            this.txtCompanyAdress.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtCompanyAdress_MouseClick);
            // 
            // txtContractCompany
            // 
            this.txtContractCompany.Location = new System.Drawing.Point(188, 120);
            this.txtContractCompany.Name = "txtContractCompany";
            this.txtContractCompany.Size = new System.Drawing.Size(244, 21);
            this.txtContractCompany.TabIndex = 3;
            this.txtContractCompany.Text = "Firma Adı...";
            this.txtContractCompany.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtContractCompany_MouseClick);
            // 
            // txtContractName
            // 
            this.txtContractName.Location = new System.Drawing.Point(188, 24);
            this.txtContractName.Name = "txtContractName";
            this.txtContractName.Size = new System.Drawing.Size(244, 21);
            this.txtContractName.TabIndex = 0;
            this.txtContractName.Text = "Sözleşme Adı...";
            this.txtContractName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtContractName_MouseClick);
            // 
            // gbMaintananceInfo
            // 
            this.gbMaintananceInfo.Controls.Add(this.cbMonth);
            this.gbMaintananceInfo.Controls.Add(this.cbContractSelect);
            this.gbMaintananceInfo.Controls.Add(this.dtpFirstMaintenance);
            this.gbMaintananceInfo.Controls.Add(this.btnMaintananceList);
            this.gbMaintananceInfo.Controls.Add(this.btnMaintananceAdd);
            this.gbMaintananceInfo.Controls.Add(this.btnMaintananceUpdate);
            this.gbMaintananceInfo.Controls.Add(this.lblMonth);
            this.gbMaintananceInfo.Controls.Add(this.lblContractSelect);
            this.gbMaintananceInfo.Controls.Add(this.lblFirstMaintenance);
            this.gbMaintananceInfo.Location = new System.Drawing.Point(785, 42);
            this.gbMaintananceInfo.Name = "gbMaintananceInfo";
            this.gbMaintananceInfo.Size = new System.Drawing.Size(366, 211);
            this.gbMaintananceInfo.TabIndex = 27;
            this.gbMaintananceInfo.TabStop = false;
            this.gbMaintananceInfo.Text = "Bakım Bilgileri";
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(154, 46);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(200, 23);
            this.cbMonth.TabIndex = 11;
            // 
            // cbContractSelect
            // 
            this.cbContractSelect.FormattingEnabled = true;
            this.cbContractSelect.Location = new System.Drawing.Point(154, 19);
            this.cbContractSelect.Name = "cbContractSelect";
            this.cbContractSelect.Size = new System.Drawing.Size(200, 23);
            this.cbContractSelect.TabIndex = 10;
            // 
            // dtpFirstMaintenance
            // 
            this.dtpFirstMaintenance.Location = new System.Drawing.Point(154, 75);
            this.dtpFirstMaintenance.Name = "dtpFirstMaintenance";
            this.dtpFirstMaintenance.Size = new System.Drawing.Size(200, 21);
            this.dtpFirstMaintenance.TabIndex = 12;
            // 
            // btnMaintananceList
            // 
            this.btnMaintananceList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMaintananceList.FlatAppearance.BorderSize = 0;
            this.btnMaintananceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintananceList.Location = new System.Drawing.Point(6, 182);
            this.btnMaintananceList.Name = "btnMaintananceList";
            this.btnMaintananceList.Size = new System.Drawing.Size(75, 23);
            this.btnMaintananceList.TabIndex = 14;
            this.btnMaintananceList.Text = "Listele";
            this.btnMaintananceList.UseVisualStyleBackColor = false;
            this.btnMaintananceList.Click += new System.EventHandler(this.btnMaintananceList_Click);
            // 
            // btnMaintananceAdd
            // 
            this.btnMaintananceAdd.BackgroundImage = global::ControlAppUICore.Properties.Resources.plus;
            this.btnMaintananceAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaintananceAdd.FlatAppearance.BorderSize = 0;
            this.btnMaintananceAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintananceAdd.Location = new System.Drawing.Point(243, 112);
            this.btnMaintananceAdd.Name = "btnMaintananceAdd";
            this.btnMaintananceAdd.Size = new System.Drawing.Size(32, 32);
            this.btnMaintananceAdd.TabIndex = 13;
            this.btnMaintananceAdd.UseVisualStyleBackColor = true;
            this.btnMaintananceAdd.Click += new System.EventHandler(this.btnMaintananceAdd_Click);
            // 
            // btnMaintananceUpdate
            // 
            this.btnMaintananceUpdate.BackgroundImage = global::ControlAppUICore.Properties.Resources.upload;
            this.btnMaintananceUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaintananceUpdate.FlatAppearance.BorderSize = 0;
            this.btnMaintananceUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintananceUpdate.Location = new System.Drawing.Point(311, 112);
            this.btnMaintananceUpdate.Name = "btnMaintananceUpdate";
            this.btnMaintananceUpdate.Size = new System.Drawing.Size(32, 32);
            this.btnMaintananceUpdate.TabIndex = 15;
            this.btnMaintananceUpdate.UseVisualStyleBackColor = true;
            this.btnMaintananceUpdate.Visible = false;
            this.btnMaintananceUpdate.Click += new System.EventHandler(this.btnMaintananceUpdate_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(17, 55);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(108, 15);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "Bakım Aralığı (Ay) :";
            // 
            // lblContractSelect
            // 
            this.lblContractSelect.AutoSize = true;
            this.lblContractSelect.Location = new System.Drawing.Point(19, 30);
            this.lblContractSelect.Name = "lblContractSelect";
            this.lblContractSelect.Size = new System.Drawing.Size(103, 15);
            this.lblContractSelect.TabIndex = 0;
            this.lblContractSelect.Text = "Sözleşme Seçiniz :";
            // 
            // lblFirstMaintenance
            // 
            this.lblFirstMaintenance.AutoSize = true;
            this.lblFirstMaintenance.Location = new System.Drawing.Point(17, 81);
            this.lblFirstMaintenance.Name = "lblFirstMaintenance";
            this.lblFirstMaintenance.Size = new System.Drawing.Size(104, 15);
            this.lblFirstMaintenance.TabIndex = 1;
            this.lblFirstMaintenance.Text = "İlk Bakım  Zamanı :";
            // 
            // MaintenanceMail
            // 
            this.MaintenanceMail.BackColor = System.Drawing.Color.LightSkyBlue;
            this.MaintenanceMail.FlatAppearance.BorderSize = 0;
            this.MaintenanceMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaintenanceMail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaintenanceMail.Location = new System.Drawing.Point(547, 21);
            this.MaintenanceMail.Name = "MaintenanceMail";
            this.MaintenanceMail.Size = new System.Drawing.Size(176, 48);
            this.MaintenanceMail.TabIndex = 16;
            this.MaintenanceMail.Text = "Bilgilendirme Mail İşlemleri";
            this.MaintenanceMail.UseVisualStyleBackColor = false;
            this.MaintenanceMail.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaintenanceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.gbMaintanance);
            this.Controls.Add(this.MaintenanceMail);
            this.Controls.Add(this.gbMaintananceInfo);
            this.Controls.Add(this.gbContractInfo);
            this.Controls.Add(this.gbContract);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MaintenanceForm";
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.MaintenanceForm_Load);
            this.gbContract.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.contextMenuStripContract.ResumeLayout(false);
            this.gbMaintanance.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaintenance)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbContractInfo.ResumeLayout(false);
            this.gbContractInfo.PerformLayout();
            this.gbMaintananceInfo.ResumeLayout(false);
            this.gbMaintananceInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContractName;
        private System.Windows.Forms.Label lblContractStartTime;
        private System.Windows.Forms.Label lblContractCompany;
        private System.Windows.Forms.Label lblCompanyAdress;
        private System.Windows.Forms.Label lblContractCompanyTel;
        private System.Windows.Forms.Label lblContractNotes;
        private System.Windows.Forms.GroupBox gbContract;
        private System.Windows.Forms.GroupBox gbContractInfo;
        private System.Windows.Forms.Button btnContractList;
        private System.Windows.Forms.Button btnContractUpdate;
        private System.Windows.Forms.GroupBox gbMaintananceInfo;
        private System.Windows.Forms.Label lblContractSelect;
        private System.Windows.Forms.Label lblFirstMaintenance;
        private System.Windows.Forms.TextBox txtCompanyTel;
        private System.Windows.Forms.DateTimePicker dtpContractStartTime;
        private System.Windows.Forms.TextBox txtCompanyAdress;
        private System.Windows.Forms.TextBox txtContractCompany;
        private System.Windows.Forms.TextBox txtContractName;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbContractSelect;
        private System.Windows.Forms.DateTimePicker dtpFirstMaintenance;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnContractAdd;
        private System.Windows.Forms.Button btnMaintananceAdd;
        private System.Windows.Forms.Button btnMaintananceList;
        private System.Windows.Forms.Button btnMaintananceUpdate;
        private System.Windows.Forms.RichTextBox rtbContractNotes;
        private System.Windows.Forms.Button MaintenanceMail;
        private System.Windows.Forms.DateTimePicker dtpContractEndTime;
        private System.Windows.Forms.Label lblContractEndTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripContract;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbMaintanance;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMaintenanceToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMaintenance;
        private System.Windows.Forms.DataGridView dgvContract;
    }
}