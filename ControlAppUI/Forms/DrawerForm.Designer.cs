namespace ControlAppDesktop.Forms
{
    partial class DrawerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawerForm));
            this.teslimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDrawer = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbHeadset = new System.Windows.Forms.GroupBox();
            this.btnDrawerDelivery = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.lblDrawerNo = new System.Windows.Forms.Label();
            this.lblDeliveryPerson = new System.Windows.Forms.Label();
            this.lblReceiverPerson = new System.Windows.Forms.Label();
            this.lblDeliveryPersonInfo = new System.Windows.Forms.Label();
            this.lblReceiverPersonInfo = new System.Windows.Forms.Label();
            this.lblDrawerNoInfo = new System.Windows.Forms.Label();
            this.txtDrawerSearch = new System.Windows.Forms.TextBox();
            this.btnDrawerSearch = new System.Windows.Forms.Button();
            this.rbDeliveryEmployee = new System.Windows.Forms.RadioButton();
            this.rbReciverEmployee = new System.Windows.Forms.RadioButton();
            this.rbDrawerNo = new System.Windows.Forms.RadioButton();
            this.gbSearchInfo = new System.Windows.Forms.GroupBox();
            this.btnDrawerList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrawer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbHeadset.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.gbSearchInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // teslimAlToolStripMenuItem
            // 
            this.teslimAlToolStripMenuItem.Name = "teslimAlToolStripMenuItem";
            this.teslimAlToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.teslimAlToolStripMenuItem.Text = "Teslim Al";
            this.teslimAlToolStripMenuItem.Click += new System.EventHandler(this.teslimAlToolStripMenuItem_Click);
            // 
            // dgvDrawer
            // 
            this.dgvDrawer.AllowUserToAddRows = false;
            this.dgvDrawer.AllowUserToDeleteRows = false;
            this.dgvDrawer.AllowUserToResizeColumns = false;
            this.dgvDrawer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvDrawer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrawer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrawer.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDrawer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrawer.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvDrawer.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvDrawer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrawer.Location = new System.Drawing.Point(3, 17);
            this.dgvDrawer.MultiSelect = false;
            this.dgvDrawer.Name = "dgvDrawer";
            this.dgvDrawer.ReadOnly = true;
            this.dgvDrawer.RowHeadersVisible = false;
            this.dgvDrawer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrawer.Size = new System.Drawing.Size(761, 235);
            this.dgvDrawer.TabIndex = 1;
            this.dgvDrawer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDrawer_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teslimAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // gbHeadset
            // 
            this.gbHeadset.Controls.Add(this.dgvDrawer);
            this.gbHeadset.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbHeadset.Location = new System.Drawing.Point(118, 391);
            this.gbHeadset.Name = "gbHeadset";
            this.gbHeadset.Size = new System.Drawing.Size(767, 255);
            this.gbHeadset.TabIndex = 17;
            this.gbHeadset.TabStop = false;
            this.gbHeadset.Text = "Teslim Edilmiş Çekmeceler";
            // 
            // btnDrawerDelivery
            // 
            this.btnDrawerDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawerDelivery.Location = new System.Drawing.Point(902, 29);
            this.btnDrawerDelivery.Name = "btnDrawerDelivery";
            this.btnDrawerDelivery.Size = new System.Drawing.Size(158, 28);
            this.btnDrawerDelivery.TabIndex = 1;
            this.btnDrawerDelivery.Text = "Çekmece Teslim Et";
            this.btnDrawerDelivery.UseVisualStyleBackColor = true;
            this.btnDrawerDelivery.Click += new System.EventHandler(this.btnDrawerDelivery_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblDrawerNo);
            this.grpInfo.Controls.Add(this.lblDeliveryPerson);
            this.grpInfo.Controls.Add(this.lblReceiverPerson);
            this.grpInfo.Controls.Add(this.lblDeliveryPersonInfo);
            this.grpInfo.Controls.Add(this.lblReceiverPersonInfo);
            this.grpInfo.Controls.Add(this.lblDrawerNoInfo);
            this.grpInfo.Location = new System.Drawing.Point(109, 99);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(328, 159);
            this.grpInfo.TabIndex = 18;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Çekmece Bilgileri";
            // 
            // lblDrawerNo
            // 
            this.lblDrawerNo.AutoSize = true;
            this.lblDrawerNo.Location = new System.Drawing.Point(26, 27);
            this.lblDrawerNo.Name = "lblDrawerNo";
            this.lblDrawerNo.Size = new System.Drawing.Size(89, 16);
            this.lblDrawerNo.TabIndex = 10;
            this.lblDrawerNo.Text = "Çekmece No:";
            // 
            // lblDeliveryPerson
            // 
            this.lblDeliveryPerson.AutoSize = true;
            this.lblDeliveryPerson.Location = new System.Drawing.Point(26, 79);
            this.lblDeliveryPerson.Name = "lblDeliveryPerson";
            this.lblDeliveryPerson.Size = new System.Drawing.Size(78, 16);
            this.lblDeliveryPerson.TabIndex = 3;
            this.lblDeliveryPerson.Text = "Teslim Eden:";
            // 
            // lblReceiverPerson
            // 
            this.lblReceiverPerson.AutoSize = true;
            this.lblReceiverPerson.Location = new System.Drawing.Point(26, 53);
            this.lblReceiverPerson.Name = "lblReceiverPerson";
            this.lblReceiverPerson.Size = new System.Drawing.Size(76, 16);
            this.lblReceiverPerson.TabIndex = 2;
            this.lblReceiverPerson.Text = "Teslim Alan:";
            // 
            // lblDeliveryPersonInfo
            // 
            this.lblDeliveryPersonInfo.AutoSize = true;
            this.lblDeliveryPersonInfo.Location = new System.Drawing.Point(149, 81);
            this.lblDeliveryPersonInfo.Name = "lblDeliveryPersonInfo";
            this.lblDeliveryPersonInfo.Size = new System.Drawing.Size(21, 16);
            this.lblDeliveryPersonInfo.TabIndex = 5;
            this.lblDeliveryPersonInfo.Text = "00";
            // 
            // lblReceiverPersonInfo
            // 
            this.lblReceiverPersonInfo.AutoSize = true;
            this.lblReceiverPersonInfo.Location = new System.Drawing.Point(149, 55);
            this.lblReceiverPersonInfo.Name = "lblReceiverPersonInfo";
            this.lblReceiverPersonInfo.Size = new System.Drawing.Size(21, 16);
            this.lblReceiverPersonInfo.TabIndex = 4;
            this.lblReceiverPersonInfo.Text = "00";
            // 
            // lblDrawerNoInfo
            // 
            this.lblDrawerNoInfo.AutoSize = true;
            this.lblDrawerNoInfo.Location = new System.Drawing.Point(149, 29);
            this.lblDrawerNoInfo.Name = "lblDrawerNoInfo";
            this.lblDrawerNoInfo.Size = new System.Drawing.Size(21, 16);
            this.lblDrawerNoInfo.TabIndex = 1;
            this.lblDrawerNoInfo.Text = "00";
            // 
            // txtDrawerSearch
            // 
            this.txtDrawerSearch.Location = new System.Drawing.Point(474, 238);
            this.txtDrawerSearch.Name = "txtDrawerSearch";
            this.txtDrawerSearch.Size = new System.Drawing.Size(239, 22);
            this.txtDrawerSearch.TabIndex = 2;
            this.txtDrawerSearch.Text = "Çekmece Ara...";
            this.txtDrawerSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDrawerSearch_MouseClick);
            // 
            // btnDrawerSearch
            // 
            this.btnDrawerSearch.BackgroundImage = global::ControlAppUICore.Properties.Resources.loupe;
            this.btnDrawerSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrawerSearch.FlatAppearance.BorderSize = 0;
            this.btnDrawerSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawerSearch.Location = new System.Drawing.Point(569, 265);
            this.btnDrawerSearch.Name = "btnDrawerSearch";
            this.btnDrawerSearch.Size = new System.Drawing.Size(32, 32);
            this.btnDrawerSearch.TabIndex = 3;
            this.btnDrawerSearch.UseVisualStyleBackColor = true;
            this.btnDrawerSearch.Click += new System.EventHandler(this.btnDrawerSearch_Click);
            // 
            // rbDeliveryEmployee
            // 
            this.rbDeliveryEmployee.AutoSize = true;
            this.rbDeliveryEmployee.Location = new System.Drawing.Point(35, 75);
            this.rbDeliveryEmployee.Name = "rbDeliveryEmployee";
            this.rbDeliveryEmployee.Size = new System.Drawing.Size(211, 20);
            this.rbDeliveryEmployee.TabIndex = 8;
            this.rbDeliveryEmployee.TabStop = true;
            this.rbDeliveryEmployee.Text = "Teslim Eden Personele Göre Ara";
            this.rbDeliveryEmployee.UseVisualStyleBackColor = true;
            this.rbDeliveryEmployee.CheckedChanged += new System.EventHandler(this.rbDeliveryEmployee_CheckedChanged);
            // 
            // rbReciverEmployee
            // 
            this.rbReciverEmployee.AutoSize = true;
            this.rbReciverEmployee.Location = new System.Drawing.Point(35, 27);
            this.rbReciverEmployee.Name = "rbReciverEmployee";
            this.rbReciverEmployee.Size = new System.Drawing.Size(170, 20);
            this.rbReciverEmployee.TabIndex = 9;
            this.rbReciverEmployee.TabStop = true;
            this.rbReciverEmployee.Text = "AlanPersonel\'e Göre Ara";
            this.rbReciverEmployee.UseVisualStyleBackColor = true;
            this.rbReciverEmployee.CheckedChanged += new System.EventHandler(this.rbReciverEmployee_CheckedChanged);
            // 
            // rbDrawerNo
            // 
            this.rbDrawerNo.AutoSize = true;
            this.rbDrawerNo.Location = new System.Drawing.Point(35, 52);
            this.rbDrawerNo.Name = "rbDrawerNo";
            this.rbDrawerNo.Size = new System.Drawing.Size(179, 20);
            this.rbDrawerNo.TabIndex = 7;
            this.rbDrawerNo.TabStop = true;
            this.rbDrawerNo.Text = "Çekmece No\'ya Göre Ara";
            this.rbDrawerNo.UseVisualStyleBackColor = true;
            this.rbDrawerNo.CheckedChanged += new System.EventHandler(this.rbDrawerNo_CheckedChanged);
            // 
            // gbSearchInfo
            // 
            this.gbSearchInfo.Controls.Add(this.rbReciverEmployee);
            this.gbSearchInfo.Controls.Add(this.rbDrawerNo);
            this.gbSearchInfo.Controls.Add(this.rbDeliveryEmployee);
            this.gbSearchInfo.Location = new System.Drawing.Point(465, 99);
            this.gbSearchInfo.Name = "gbSearchInfo";
            this.gbSearchInfo.Size = new System.Drawing.Size(333, 127);
            this.gbSearchInfo.TabIndex = 23;
            this.gbSearchInfo.TabStop = false;
            this.gbSearchInfo.Text = "Arama Seçeneği";
            // 
            // btnDrawerList
            // 
            this.btnDrawerList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDrawerList.FlatAppearance.BorderSize = 0;
            this.btnDrawerList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawerList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDrawerList.Location = new System.Drawing.Point(774, 371);
            this.btnDrawerList.Name = "btnDrawerList";
            this.btnDrawerList.Size = new System.Drawing.Size(108, 23);
            this.btnDrawerList.TabIndex = 0;
            this.btnDrawerList.Text = "Listele";
            this.btnDrawerList.UseVisualStyleBackColor = false;
            this.btnDrawerList.Click += new System.EventHandler(this.btnDrawerList_Click);
            // 
            // DrawerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.gbHeadset);
            this.Controls.Add(this.btnDrawerDelivery);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.txtDrawerSearch);
            this.Controls.Add(this.btnDrawerSearch);
            this.Controls.Add(this.gbSearchInfo);
            this.Controls.Add(this.btnDrawerList);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DrawerForm";
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.DrawerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrawer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbHeadset.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.gbSearchInfo.ResumeLayout(false);
            this.gbSearchInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem teslimAlToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDrawer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gbHeadset;
        private System.Windows.Forms.Button btnDrawerDelivery;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblDrawerNo;
        private System.Windows.Forms.Label lblDeliveryPerson;
        private System.Windows.Forms.Label lblReceiverPerson;
        private System.Windows.Forms.Label lblDeliveryPersonInfo;
        private System.Windows.Forms.Label lblReceiverPersonInfo;
        private System.Windows.Forms.Label lblDrawerNoInfo;
        private System.Windows.Forms.TextBox txtDrawerSearch;
        private System.Windows.Forms.Button btnDrawerSearch;
        private System.Windows.Forms.RadioButton rbDeliveryEmployee;
        private System.Windows.Forms.RadioButton rbReciverEmployee;
        private System.Windows.Forms.RadioButton rbDrawerNo;
        private System.Windows.Forms.GroupBox gbSearchInfo;
        private System.Windows.Forms.Button btnDrawerList;
    }
}