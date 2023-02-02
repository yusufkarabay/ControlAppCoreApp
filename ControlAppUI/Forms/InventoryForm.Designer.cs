namespace ControlAppDesktop.Forms
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.grpInventory = new System.Windows.Forms.GroupBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpInventoryInfo = new System.Windows.Forms.GroupBox();
            this.rtxbxInventoryInfo = new System.Windows.Forms.RichTextBox();
            this.txtbxAmount = new System.Windows.Forms.TextBox();
            this.txtbxInventoryName = new System.Windows.Forms.TextBox();
            this.txtbxInventorySeriNo = new System.Windows.Forms.TextBox();
            this.lblInventoryInfo = new System.Windows.Forms.Label();
            this.lblInventoryAmount = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInventoryName = new System.Windows.Forms.Label();
            this.lblInventorySeriNo = new System.Windows.Forms.Label();
            this.dtpInventory = new System.Windows.Forms.DateTimePicker();
            this.btnList = new System.Windows.Forms.Button();
            this.btnInventoryWeb = new System.Windows.Forms.Button();
            this.btnAllList = new System.Windows.Forms.Button();
            this.txtbxtSearchInventoryName = new System.Windows.Forms.TextBox();
            this.txtInventorySearchSeriNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.grpInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.grpInventoryInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInventory
            // 
            this.grpInventory.Controls.Add(this.dgvInventory);
            this.grpInventory.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpInventory.Location = new System.Drawing.Point(69, 310);
            this.grpInventory.Name = "grpInventory";
            this.grpInventory.Size = new System.Drawing.Size(1014, 272);
            this.grpInventory.TabIndex = 4;
            this.grpInventory.TabStop = false;
            this.grpInventory.Text = "Envanter Listesi";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvInventory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvInventory.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInventory.Location = new System.Drawing.Point(3, 17);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventory.Size = new System.Drawing.Size(1008, 252);
            this.dgvInventory.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateInventoryToolStripMenuItem,
            this.deleteInventoryToolStripMenuItem,
            this.refreshInventoryToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 70);
            // 
            // updateInventoryToolStripMenuItem
            // 
            this.updateInventoryToolStripMenuItem.Name = "updateInventoryToolStripMenuItem";
            this.updateInventoryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.updateInventoryToolStripMenuItem.Text = "Güncellenecek Envanteri Seç";
            this.updateInventoryToolStripMenuItem.Click += new System.EventHandler(this.updateInventoryToolStripMenuItem_Click);
            // 
            // deleteInventoryToolStripMenuItem
            // 
            this.deleteInventoryToolStripMenuItem.Name = "deleteInventoryToolStripMenuItem";
            this.deleteInventoryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.deleteInventoryToolStripMenuItem.Text = "Sil";
            this.deleteInventoryToolStripMenuItem.Click += new System.EventHandler(this.deleteInventoryToolStripMenuItem_Click);
            // 
            // refreshInventoryToolStripMenuItem
            // 
            this.refreshInventoryToolStripMenuItem.Name = "refreshInventoryToolStripMenuItem";
            this.refreshInventoryToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.refreshInventoryToolStripMenuItem.Text = "Yenile";
            this.refreshInventoryToolStripMenuItem.Click += new System.EventHandler(this.refreshInventoryToolStripMenuItem_Click);
            // 
            // grpInventoryInfo
            // 
            this.grpInventoryInfo.Controls.Add(this.rtxbxInventoryInfo);
            this.grpInventoryInfo.Controls.Add(this.txtbxAmount);
            this.grpInventoryInfo.Controls.Add(this.txtbxInventoryName);
            this.grpInventoryInfo.Controls.Add(this.txtbxInventorySeriNo);
            this.grpInventoryInfo.Controls.Add(this.lblInventoryInfo);
            this.grpInventoryInfo.Controls.Add(this.lblInventoryAmount);
            this.grpInventoryInfo.Controls.Add(this.btnUpdate);
            this.grpInventoryInfo.Controls.Add(this.btnAdd);
            this.grpInventoryInfo.Controls.Add(this.lblInventoryName);
            this.grpInventoryInfo.Controls.Add(this.lblInventorySeriNo);
            this.grpInventoryInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpInventoryInfo.Location = new System.Drawing.Point(72, 38);
            this.grpInventoryInfo.Name = "grpInventoryInfo";
            this.grpInventoryInfo.Size = new System.Drawing.Size(345, 227);
            this.grpInventoryInfo.TabIndex = 5;
            this.grpInventoryInfo.TabStop = false;
            this.grpInventoryInfo.Text = "Envanter Bilgileri";
            // 
            // rtxbxInventoryInfo
            // 
            this.rtxbxInventoryInfo.Location = new System.Drawing.Point(105, 124);
            this.rtxbxInventoryInfo.Name = "rtxbxInventoryInfo";
            this.rtxbxInventoryInfo.Size = new System.Drawing.Size(206, 55);
            this.rtxbxInventoryInfo.TabIndex = 5;
            this.rtxbxInventoryInfo.Text = "";
            // 
            // txtbxAmount
            // 
            this.txtbxAmount.Location = new System.Drawing.Point(105, 96);
            this.txtbxAmount.MaxLength = 9;
            this.txtbxAmount.Name = "txtbxAmount";
            this.txtbxAmount.Size = new System.Drawing.Size(206, 21);
            this.txtbxAmount.TabIndex = 4;
            this.txtbxAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAmount_KeyPress);
            // 
            // txtbxInventoryName
            // 
            this.txtbxInventoryName.Location = new System.Drawing.Point(105, 59);
            this.txtbxInventoryName.Name = "txtbxInventoryName";
            this.txtbxInventoryName.Size = new System.Drawing.Size(206, 21);
            this.txtbxInventoryName.TabIndex = 3;
            // 
            // txtbxInventorySeriNo
            // 
            this.txtbxInventorySeriNo.Location = new System.Drawing.Point(105, 22);
            this.txtbxInventorySeriNo.Name = "txtbxInventorySeriNo";
            this.txtbxInventorySeriNo.Size = new System.Drawing.Size(206, 21);
            this.txtbxInventorySeriNo.TabIndex = 2;
            // 
            // lblInventoryInfo
            // 
            this.lblInventoryInfo.AutoSize = true;
            this.lblInventoryInfo.Location = new System.Drawing.Point(19, 135);
            this.lblInventoryInfo.Name = "lblInventoryInfo";
            this.lblInventoryInfo.Size = new System.Drawing.Size(63, 15);
            this.lblInventoryInfo.TabIndex = 3;
            this.lblInventoryInfo.Text = "Açıklama :";
            // 
            // lblInventoryAmount
            // 
            this.lblInventoryAmount.AutoSize = true;
            this.lblInventoryAmount.Location = new System.Drawing.Point(19, 96);
            this.lblInventoryAmount.Name = "lblInventoryAmount";
            this.lblInventoryAmount.Size = new System.Drawing.Size(46, 15);
            this.lblInventoryAmount.TabIndex = 2;
            this.lblInventoryAmount.Text = "Miktar :";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::ControlAppUICore.Properties.Resources.upload;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(267, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(32, 32);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::ControlAppUICore.Properties.Resources.plus;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(175, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInventoryName
            // 
            this.lblInventoryName.AutoSize = true;
            this.lblInventoryName.Location = new System.Drawing.Point(19, 62);
            this.lblInventoryName.Name = "lblInventoryName";
            this.lblInventoryName.Size = new System.Drawing.Size(81, 15);
            this.lblInventoryName.TabIndex = 1;
            this.lblInventoryName.Text = "Envanter Adı :";
            // 
            // lblInventorySeriNo
            // 
            this.lblInventorySeriNo.AutoSize = true;
            this.lblInventorySeriNo.Location = new System.Drawing.Point(19, 30);
            this.lblInventorySeriNo.Name = "lblInventorySeriNo";
            this.lblInventorySeriNo.Size = new System.Drawing.Size(52, 15);
            this.lblInventorySeriNo.TabIndex = 0;
            this.lblInventorySeriNo.Text = "Seri No :";
            // 
            // dtpInventory
            // 
            this.dtpInventory.Location = new System.Drawing.Point(638, 41);
            this.dtpInventory.Name = "dtpInventory";
            this.dtpInventory.Size = new System.Drawing.Size(200, 21);
            this.dtpInventory.TabIndex = 6;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnList.Location = new System.Drawing.Point(703, 68);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 1;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnInventoryWeb
            // 
            this.btnInventoryWeb.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnInventoryWeb.FlatAppearance.BorderSize = 0;
            this.btnInventoryWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryWeb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInventoryWeb.Location = new System.Drawing.Point(1033, 12);
            this.btnInventoryWeb.Name = "btnInventoryWeb";
            this.btnInventoryWeb.Size = new System.Drawing.Size(124, 23);
            this.btnInventoryWeb.TabIndex = 10;
            this.btnInventoryWeb.Text = "Web\'de Görüntüle";
            this.btnInventoryWeb.UseVisualStyleBackColor = false;
            this.btnInventoryWeb.Click += new System.EventHandler(this.btnInventoryWeb_Click);
            // 
            // btnAllList
            // 
            this.btnAllList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAllList.FlatAppearance.BorderSize = 0;
            this.btnAllList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllList.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAllList.Location = new System.Drawing.Point(969, 281);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(111, 23);
            this.btnAllList.TabIndex = 0;
            this.btnAllList.Text = "Tümünü Listele";
            this.btnAllList.UseVisualStyleBackColor = false;
            this.btnAllList.Click += new System.EventHandler(this.btnAllList_Click);
            // 
            // txtbxtSearchInventoryName
            // 
            this.txtbxtSearchInventoryName.Location = new System.Drawing.Point(804, 238);
            this.txtbxtSearchInventoryName.Multiline = true;
            this.txtbxtSearchInventoryName.Name = "txtbxtSearchInventoryName";
            this.txtbxtSearchInventoryName.Size = new System.Drawing.Size(276, 30);
            this.txtbxtSearchInventoryName.TabIndex = 8;
            this.txtbxtSearchInventoryName.Text = "Envanter Adına Göre Ara...";
            this.txtbxtSearchInventoryName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtbzxSearchInventory_MouseClick);
            this.txtbxtSearchInventoryName.TextChanged += new System.EventHandler(this.txtbxtSearchInventory_TextChanged);
            // 
            // txtInventorySearchSeriNo
            // 
            this.txtInventorySearchSeriNo.Location = new System.Drawing.Point(463, 238);
            this.txtInventorySearchSeriNo.Multiline = true;
            this.txtInventorySearchSeriNo.Name = "txtInventorySearchSeriNo";
            this.txtInventorySearchSeriNo.Size = new System.Drawing.Size(276, 30);
            this.txtInventorySearchSeriNo.TabIndex = 7;
            this.txtInventorySearchSeriNo.Text = "Seri No\'ya Göre Ara...";
            this.txtInventorySearchSeriNo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtInventorySearchSeriNo_MouseClick);
            this.txtInventorySearchSeriNo.TextChanged += new System.EventHandler(this.txtInventorySearchSeriNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(460, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Seri No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(805, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Envanter Adı";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InventoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInventorySearchSeriNo);
            this.Controls.Add(this.txtbxtSearchInventoryName);
            this.Controls.Add(this.btnAllList);
            this.Controls.Add(this.btnInventoryWeb);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.dtpInventory);
            this.Controls.Add(this.grpInventoryInfo);
            this.Controls.Add(this.grpInventory);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InventoryForm";
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.grpInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpInventoryInfo.ResumeLayout(false);
            this.grpInventoryInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInventory;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.GroupBox grpInventoryInfo;
        private System.Windows.Forms.Label lblInventoryInfo;
        private System.Windows.Forms.Label lblInventoryAmount;
        private System.Windows.Forms.Label lblInventoryName;
        private System.Windows.Forms.Label lblInventorySeriNo;
        private System.Windows.Forms.RichTextBox rtxbxInventoryInfo;
        private System.Windows.Forms.TextBox txtbxAmount;
        private System.Windows.Forms.TextBox txtbxInventoryName;
        private System.Windows.Forms.TextBox txtbxInventorySeriNo;
        private System.Windows.Forms.DateTimePicker dtpInventory;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnInventoryWeb;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteInventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshInventoryToolStripMenuItem;
        private System.Windows.Forms.TextBox txtbxtSearchInventoryName;
        private System.Windows.Forms.TextBox txtInventorySearchSeriNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}