namespace ControlAppDesktop.Forms
{
    partial class HeadsetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeadsetForm));
            this.gbHeadset = new System.Windows.Forms.GroupBox();
            this.dgvHeadset = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnDeliveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblHeadsetSeriNo = new System.Windows.Forms.Label();
            this.headsetstatus = new System.Windows.Forms.Label();
            this.lblDeliveryPerson = new System.Windows.Forms.Label();
            this.lblReceiverPerson = new System.Windows.Forms.Label();
            this.lblHeadsetStatusInfo = new System.Windows.Forms.Label();
            this.lblDeliveryPersonInfo = new System.Windows.Forms.Label();
            this.lblReceiverPersonInfo = new System.Windows.Forms.Label();
            this.lblHeadsetSeriNoInfo = new System.Windows.Forms.Label();
            this.btnHeadsetDelivery = new System.Windows.Forms.Button();
            this.btnHeadsetList = new System.Windows.Forms.Button();
            this.btnHeadsetSearch = new System.Windows.Forms.Button();
            this.txtHeadsetSearch = new System.Windows.Forms.TextBox();
            this.rbHeadsetSeriNo = new System.Windows.Forms.RadioButton();
            this.rbDeliveryEmployee = new System.Windows.Forms.RadioButton();
            this.gbSearchInfo = new System.Windows.Forms.GroupBox();
            this.rbReciverEmployee = new System.Windows.Forms.RadioButton();
            this.gbHeadset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeadset)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.gbSearchInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbHeadset
            // 
            this.gbHeadset.Controls.Add(this.dgvHeadset);
            this.gbHeadset.Location = new System.Drawing.Point(115, 391);
            this.gbHeadset.Name = "gbHeadset";
            this.gbHeadset.Size = new System.Drawing.Size(767, 255);
            this.gbHeadset.TabIndex = 0;
            this.gbHeadset.TabStop = false;
            this.gbHeadset.Text = "Teslim Edilmiş Kulaklıklar";
            // 
            // dgvHeadset
            // 
            this.dgvHeadset.AllowUserToAddRows = false;
            this.dgvHeadset.AllowUserToDeleteRows = false;
            this.dgvHeadset.AllowUserToResizeColumns = false;
            this.dgvHeadset.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvHeadset.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHeadset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHeadset.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvHeadset.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHeadset.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvHeadset.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvHeadset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHeadset.Location = new System.Drawing.Point(3, 18);
            this.dgvHeadset.MultiSelect = false;
            this.dgvHeadset.Name = "dgvHeadset";
            this.dgvHeadset.ReadOnly = true;
            this.dgvHeadset.RowHeadersVisible = false;
            this.dgvHeadset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHeadset.Size = new System.Drawing.Size(761, 234);
            this.dgvHeadset.TabIndex = 1;
            this.dgvHeadset.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHeadset_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnDeliveryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // returnDeliveryToolStripMenuItem
            // 
            this.returnDeliveryToolStripMenuItem.Name = "returnDeliveryToolStripMenuItem";
            this.returnDeliveryToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.returnDeliveryToolStripMenuItem.Text = "Teslim Al";
            this.returnDeliveryToolStripMenuItem.Click += new System.EventHandler(this.returnDeliveryToolStripMenuItem_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblHeadsetSeriNo);
            this.grpInfo.Controls.Add(this.headsetstatus);
            this.grpInfo.Controls.Add(this.lblDeliveryPerson);
            this.grpInfo.Controls.Add(this.lblReceiverPerson);
            this.grpInfo.Controls.Add(this.lblHeadsetStatusInfo);
            this.grpInfo.Controls.Add(this.lblDeliveryPersonInfo);
            this.grpInfo.Controls.Add(this.lblReceiverPersonInfo);
            this.grpInfo.Controls.Add(this.lblHeadsetSeriNoInfo);
            this.grpInfo.Location = new System.Drawing.Point(109, 99);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(328, 159);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Kulaklık Bilgileri";
            // 
            // lblHeadsetSeriNo
            // 
            this.lblHeadsetSeriNo.AutoSize = true;
            this.lblHeadsetSeriNo.Location = new System.Drawing.Point(28, 31);
            this.lblHeadsetSeriNo.Name = "lblHeadsetSeriNo";
            this.lblHeadsetSeriNo.Size = new System.Drawing.Size(99, 16);
            this.lblHeadsetSeriNo.TabIndex = 10;
            this.lblHeadsetSeriNo.Text = "Kulaklık Seri No:";
            // 
            // headsetstatus
            // 
            this.headsetstatus.AutoSize = true;
            this.headsetstatus.Location = new System.Drawing.Point(28, 109);
            this.headsetstatus.Name = "headsetstatus";
            this.headsetstatus.Size = new System.Drawing.Size(99, 16);
            this.headsetstatus.TabIndex = 8;
            this.headsetstatus.Text = "Kulaklık Durumu";
            // 
            // lblDeliveryPerson
            // 
            this.lblDeliveryPerson.AutoSize = true;
            this.lblDeliveryPerson.Location = new System.Drawing.Point(28, 83);
            this.lblDeliveryPerson.Name = "lblDeliveryPerson";
            this.lblDeliveryPerson.Size = new System.Drawing.Size(78, 16);
            this.lblDeliveryPerson.TabIndex = 3;
            this.lblDeliveryPerson.Text = "Teslim Eden:";
            // 
            // lblReceiverPerson
            // 
            this.lblReceiverPerson.AutoSize = true;
            this.lblReceiverPerson.Location = new System.Drawing.Point(28, 57);
            this.lblReceiverPerson.Name = "lblReceiverPerson";
            this.lblReceiverPerson.Size = new System.Drawing.Size(76, 16);
            this.lblReceiverPerson.TabIndex = 2;
            this.lblReceiverPerson.Text = "Teslim Alan:";
            // 
            // lblHeadsetStatusInfo
            // 
            this.lblHeadsetStatusInfo.AutoSize = true;
            this.lblHeadsetStatusInfo.Location = new System.Drawing.Point(149, 109);
            this.lblHeadsetStatusInfo.Name = "lblHeadsetStatusInfo";
            this.lblHeadsetStatusInfo.Size = new System.Drawing.Size(21, 16);
            this.lblHeadsetStatusInfo.TabIndex = 9;
            this.lblHeadsetStatusInfo.Text = "00";
            // 
            // lblDeliveryPersonInfo
            // 
            this.lblDeliveryPersonInfo.AutoSize = true;
            this.lblDeliveryPersonInfo.Location = new System.Drawing.Point(149, 83);
            this.lblDeliveryPersonInfo.Name = "lblDeliveryPersonInfo";
            this.lblDeliveryPersonInfo.Size = new System.Drawing.Size(21, 16);
            this.lblDeliveryPersonInfo.TabIndex = 5;
            this.lblDeliveryPersonInfo.Text = "00";
            // 
            // lblReceiverPersonInfo
            // 
            this.lblReceiverPersonInfo.AutoSize = true;
            this.lblReceiverPersonInfo.Location = new System.Drawing.Point(149, 57);
            this.lblReceiverPersonInfo.Name = "lblReceiverPersonInfo";
            this.lblReceiverPersonInfo.Size = new System.Drawing.Size(21, 16);
            this.lblReceiverPersonInfo.TabIndex = 4;
            this.lblReceiverPersonInfo.Text = "00";
            // 
            // lblHeadsetSeriNoInfo
            // 
            this.lblHeadsetSeriNoInfo.AutoSize = true;
            this.lblHeadsetSeriNoInfo.Location = new System.Drawing.Point(149, 31);
            this.lblHeadsetSeriNoInfo.Name = "lblHeadsetSeriNoInfo";
            this.lblHeadsetSeriNoInfo.Size = new System.Drawing.Size(21, 16);
            this.lblHeadsetSeriNoInfo.TabIndex = 1;
            this.lblHeadsetSeriNoInfo.Text = "00";
            // 
            // btnHeadsetDelivery
            // 
            this.btnHeadsetDelivery.BackColor = System.Drawing.Color.LightGray;
            this.btnHeadsetDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeadsetDelivery.Location = new System.Drawing.Point(902, 29);
            this.btnHeadsetDelivery.Name = "btnHeadsetDelivery";
            this.btnHeadsetDelivery.Size = new System.Drawing.Size(121, 27);
            this.btnHeadsetDelivery.TabIndex = 1;
            this.btnHeadsetDelivery.Text = "Kulaklık Teslim Et";
            this.btnHeadsetDelivery.UseVisualStyleBackColor = false;
            this.btnHeadsetDelivery.Click += new System.EventHandler(this.btnHeadsetDelivery_Click);
            // 
            // btnHeadsetList
            // 
            this.btnHeadsetList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnHeadsetList.FlatAppearance.BorderSize = 0;
            this.btnHeadsetList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeadsetList.Location = new System.Drawing.Point(774, 371);
            this.btnHeadsetList.Name = "btnHeadsetList";
            this.btnHeadsetList.Size = new System.Drawing.Size(108, 23);
            this.btnHeadsetList.TabIndex = 0;
            this.btnHeadsetList.Text = "Listele";
            this.btnHeadsetList.UseVisualStyleBackColor = false;
            this.btnHeadsetList.Click += new System.EventHandler(this.btnHeadsetList_Click);
            // 
            // btnHeadsetSearch
            // 
            this.btnHeadsetSearch.BackgroundImage = global::ControlAppUICore.Properties.Resources.loupe;
            this.btnHeadsetSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHeadsetSearch.FlatAppearance.BorderSize = 0;
            this.btnHeadsetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeadsetSearch.Location = new System.Drawing.Point(569, 265);
            this.btnHeadsetSearch.Name = "btnHeadsetSearch";
            this.btnHeadsetSearch.Size = new System.Drawing.Size(32, 32);
            this.btnHeadsetSearch.TabIndex = 3;
            this.btnHeadsetSearch.UseVisualStyleBackColor = true;
            this.btnHeadsetSearch.Click += new System.EventHandler(this.btnHeadsetSearch_Click);
            // 
            // txtHeadsetSearch
            // 
            this.txtHeadsetSearch.Location = new System.Drawing.Point(474, 238);
            this.txtHeadsetSearch.Name = "txtHeadsetSearch";
            this.txtHeadsetSearch.Size = new System.Drawing.Size(239, 22);
            this.txtHeadsetSearch.TabIndex = 2;
            this.txtHeadsetSearch.Text = "Kulaklık Ara...";
            this.txtHeadsetSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtHeadsetSearch_MouseClick);
            // 
            // rbHeadsetSeriNo
            // 
            this.rbHeadsetSeriNo.AutoSize = true;
            this.rbHeadsetSeriNo.Location = new System.Drawing.Point(35, 56);
            this.rbHeadsetSeriNo.Name = "rbHeadsetSeriNo";
            this.rbHeadsetSeriNo.Size = new System.Drawing.Size(189, 20);
            this.rbHeadsetSeriNo.TabIndex = 7;
            this.rbHeadsetSeriNo.TabStop = true;
            this.rbHeadsetSeriNo.Text = "Kulaklık Seri No\'ya Göre Ara";
            this.rbHeadsetSeriNo.UseVisualStyleBackColor = true;
            this.rbHeadsetSeriNo.CheckedChanged += new System.EventHandler(this.rbHeadsetSeriNo_CheckedChanged);
            // 
            // rbDeliveryEmployee
            // 
            this.rbDeliveryEmployee.AutoSize = true;
            this.rbDeliveryEmployee.Location = new System.Drawing.Point(35, 79);
            this.rbDeliveryEmployee.Name = "rbDeliveryEmployee";
            this.rbDeliveryEmployee.Size = new System.Drawing.Size(211, 20);
            this.rbDeliveryEmployee.TabIndex = 8;
            this.rbDeliveryEmployee.TabStop = true;
            this.rbDeliveryEmployee.Text = "Teslim Eden Personele Göre Ara";
            this.rbDeliveryEmployee.UseVisualStyleBackColor = true;
            this.rbDeliveryEmployee.CheckedChanged += new System.EventHandler(this.rbDeliveryEmployee_CheckedChanged);
            // 
            // gbSearchInfo
            // 
            this.gbSearchInfo.Controls.Add(this.rbReciverEmployee);
            this.gbSearchInfo.Controls.Add(this.rbHeadsetSeriNo);
            this.gbSearchInfo.Controls.Add(this.rbDeliveryEmployee);
            this.gbSearchInfo.Location = new System.Drawing.Point(465, 99);
            this.gbSearchInfo.Name = "gbSearchInfo";
            this.gbSearchInfo.Size = new System.Drawing.Size(333, 127);
            this.gbSearchInfo.TabIndex = 9;
            this.gbSearchInfo.TabStop = false;
            this.gbSearchInfo.Text = "Arama Seçeneği";
            // 
            // rbReciverEmployee
            // 
            this.rbReciverEmployee.AutoSize = true;
            this.rbReciverEmployee.Location = new System.Drawing.Point(35, 31);
            this.rbReciverEmployee.Name = "rbReciverEmployee";
            this.rbReciverEmployee.Size = new System.Drawing.Size(170, 20);
            this.rbReciverEmployee.TabIndex = 9;
            this.rbReciverEmployee.TabStop = true;
            this.rbReciverEmployee.Text = "AlanPersonel\'e Göre Ara";
            this.rbReciverEmployee.UseVisualStyleBackColor = true;
            this.rbReciverEmployee.CheckedChanged += new System.EventHandler(this.rbReciverEmployee_CheckedChanged);
            // 
            // HeadsetForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.btnHeadsetList);
            this.Controls.Add(this.gbSearchInfo);
            this.Controls.Add(this.txtHeadsetSearch);
            this.Controls.Add(this.btnHeadsetSearch);
            this.Controls.Add(this.btnHeadsetDelivery);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.gbHeadset);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeadsetForm";
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.HeadsetForm_Load);
            this.gbHeadset.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHeadset)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.gbSearchInfo.ResumeLayout(false);
            this.gbSearchInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbHeadset;
        private System.Windows.Forms.DataGridView dgvHeadset;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblHeadsetSeriNo;
        private System.Windows.Forms.Label lblDeliveryPerson;
        private System.Windows.Forms.Label lblReceiverPerson;
        private System.Windows.Forms.Label lblDeliveryPersonInfo;
        private System.Windows.Forms.Label lblReceiverPersonInfo;
        private System.Windows.Forms.Label lblHeadsetSeriNoInfo;
        private System.Windows.Forms.Button btnHeadsetDelivery;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem returnDeliveryToolStripMenuItem;
        private System.Windows.Forms.Button btnHeadsetList;
        private System.Windows.Forms.Button btnHeadsetSearch;
        private System.Windows.Forms.TextBox txtHeadsetSearch;
        private System.Windows.Forms.RadioButton rbHeadsetSeriNo;
        private System.Windows.Forms.RadioButton rbDeliveryEmployee;
        private System.Windows.Forms.GroupBox gbSearchInfo;
        private System.Windows.Forms.RadioButton rbReciverEmployee;
        private System.Windows.Forms.Label headsetstatus;
        private System.Windows.Forms.Label lblHeadsetStatusInfo;
    }
}