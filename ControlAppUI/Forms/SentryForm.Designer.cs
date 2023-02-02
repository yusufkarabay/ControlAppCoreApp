namespace ControlAppDesktop.Forms
{
    partial class SentryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentryForm));
            this.dtpSentry = new System.Windows.Forms.DateTimePicker();
            this.rtbxSentry = new System.Windows.Forms.RichTextBox();
            this.gbSentry = new System.Windows.Forms.GroupBox();
            this.dgvSentry = new System.Windows.Forms.DataGridView();
            this.rightMenuDone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbxSentryToDo = new System.Windows.Forms.RichTextBox();
            this.btnSentryListToDo = new System.Windows.Forms.Button();
            this.btnSentryToDoAdd = new System.Windows.Forms.Button();
            this.btnSentryDoneAdd = new System.Windows.Forms.Button();
            this.btnSentryListDone = new System.Windows.Forms.Button();
            this.gbSentry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentry)).BeginInit();
            this.rightMenuDone.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpSentry
            // 
            this.dtpSentry.Location = new System.Drawing.Point(467, 13);
            this.dtpSentry.Name = "dtpSentry";
            this.dtpSentry.Size = new System.Drawing.Size(200, 21);
            this.dtpSentry.TabIndex = 0;
            // 
            // rtbxSentry
            // 
            this.rtbxSentry.Location = new System.Drawing.Point(12, 122);
            this.rtbxSentry.Name = "rtbxSentry";
            this.rtbxSentry.Size = new System.Drawing.Size(472, 149);
            this.rtbxSentry.TabIndex = 1;
            this.rtbxSentry.Text = "Nöbet sırasında yapılan işler...";
            this.rtbxSentry.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbxSentry_MouseClick);
            // 
            // gbSentry
            // 
            this.gbSentry.BackColor = System.Drawing.Color.LightGray;
            this.gbSentry.Controls.Add(this.dgvSentry);
            this.gbSentry.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSentry.Location = new System.Drawing.Point(55, 406);
            this.gbSentry.Name = "gbSentry";
            this.gbSentry.Size = new System.Drawing.Size(1039, 266);
            this.gbSentry.TabIndex = 2;
            this.gbSentry.TabStop = false;
            this.gbSentry.Text = "Nöbet İşlemleri";
            // 
            // dgvSentry
            // 
            this.dgvSentry.AllowUserToAddRows = false;
            this.dgvSentry.AllowUserToDeleteRows = false;
            this.dgvSentry.AllowUserToResizeColumns = false;
            this.dgvSentry.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvSentry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSentry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSentry.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvSentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSentry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSentry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSentry.ContextMenuStrip = this.rightMenuDone;
            this.dgvSentry.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvSentry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSentry.Location = new System.Drawing.Point(3, 17);
            this.dgvSentry.MultiSelect = false;
            this.dgvSentry.Name = "dgvSentry";
            this.dgvSentry.ReadOnly = true;
            this.dgvSentry.RowHeadersVisible = false;
            this.dgvSentry.RowHeadersWidth = 51;
            this.dgvSentry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSentry.Size = new System.Drawing.Size(1033, 246);
            this.dgvSentry.TabIndex = 1;
            this.dgvSentry.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSentry_CellMouseClick);
            // 
            // rightMenuDone
            // 
            this.rightMenuDone.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightMenuDone.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.rightMenuDone.Name = "contextMenuStrip1";
            this.rightMenuDone.Size = new System.Drawing.Size(205, 70);
         
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.updateToolStripMenuItem.Text = "Güncellenecek Kaydı Seç";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.deleteToolStripMenuItem.Text = "Sil";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.refreshToolStripMenuItem.Text = "Yenile";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
            // 
            // rtbxSentryToDo
            // 
            this.rtbxSentryToDo.Location = new System.Drawing.Point(622, 122);
            this.rtbxSentryToDo.Name = "rtbxSentryToDo";
            this.rtbxSentryToDo.Size = new System.Drawing.Size(472, 149);
            this.rtbxSentryToDo.TabIndex = 8;
            this.rtbxSentryToDo.Text = "Takip edilecek işlemler...";
            this.rtbxSentryToDo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rtbxSentryToDo_MouseClick);
            // 
            // btnSentryListToDo
            // 
            this.btnSentryListToDo.BackColor = System.Drawing.Color.Transparent;
            this.btnSentryListToDo.BackgroundImage = global::ControlAppUICore.Properties.Resources.loupe;
            this.btnSentryListToDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSentryListToDo.FlatAppearance.BorderSize = 0;
            this.btnSentryListToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentryListToDo.Location = new System.Drawing.Point(832, 281);
            this.btnSentryListToDo.Name = "btnSentryListToDo";
            this.btnSentryListToDo.Size = new System.Drawing.Size(32, 32);
            this.btnSentryListToDo.TabIndex = 7;
            this.btnSentryListToDo.UseVisualStyleBackColor = false;
            this.btnSentryListToDo.Click += new System.EventHandler(this.btnSentryListToDo_Click);
            // 
            // btnSentryToDoAdd
            // 
            this.btnSentryToDoAdd.BackgroundImage = global::ControlAppUICore.Properties.Resources.plus;
            this.btnSentryToDoAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSentryToDoAdd.FlatAppearance.BorderSize = 0;
            this.btnSentryToDoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentryToDoAdd.Location = new System.Drawing.Point(647, 277);
            this.btnSentryToDoAdd.Name = "btnSentryToDoAdd";
            this.btnSentryToDoAdd.Size = new System.Drawing.Size(32, 32);
            this.btnSentryToDoAdd.TabIndex = 6;
            this.btnSentryToDoAdd.UseVisualStyleBackColor = true;
            this.btnSentryToDoAdd.Click += new System.EventHandler(this.btnSentryToDoAdd_Click);
            // 
            // btnSentryDoneAdd
            // 
            this.btnSentryDoneAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnSentryDoneAdd.BackgroundImage = global::ControlAppUICore.Properties.Resources.plus;
            this.btnSentryDoneAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSentryDoneAdd.FlatAppearance.BorderSize = 0;
            this.btnSentryDoneAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentryDoneAdd.Location = new System.Drawing.Point(37, 277);
            this.btnSentryDoneAdd.Name = "btnSentryDoneAdd";
            this.btnSentryDoneAdd.Size = new System.Drawing.Size(32, 32);
            this.btnSentryDoneAdd.TabIndex = 5;
            this.btnSentryDoneAdd.UseVisualStyleBackColor = false;
            this.btnSentryDoneAdd.Click += new System.EventHandler(this.btnSentryDoneAdd_Click);
            // 
            // btnSentryListDone
            // 
            this.btnSentryListDone.BackColor = System.Drawing.Color.Transparent;
            this.btnSentryListDone.BackgroundImage = global::ControlAppUICore.Properties.Resources.loupe;
            this.btnSentryListDone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSentryListDone.FlatAppearance.BorderSize = 0;
            this.btnSentryListDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentryListDone.ForeColor = System.Drawing.Color.Transparent;
            this.btnSentryListDone.Location = new System.Drawing.Point(200, 281);
            this.btnSentryListDone.Name = "btnSentryListDone";
            this.btnSentryListDone.Size = new System.Drawing.Size(32, 32);
            this.btnSentryListDone.TabIndex = 3;
            this.btnSentryListDone.UseVisualStyleBackColor = false;
            this.btnSentryListDone.Click += new System.EventHandler(this.btnSentryListDone_Click);
            // 
            // SentryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.rtbxSentryToDo);
            this.Controls.Add(this.btnSentryListToDo);
            this.Controls.Add(this.btnSentryToDoAdd);
            this.Controls.Add(this.btnSentryDoneAdd);
            this.Controls.Add(this.btnSentryListDone);
            this.Controls.Add(this.gbSentry);
            this.Controls.Add(this.rtbxSentry);
            this.Controls.Add(this.dtpSentry);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SentryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.SentryForm_Load);
            this.gbSentry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentry)).EndInit();
            this.rightMenuDone.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSentry;
        private System.Windows.Forms.RichTextBox rtbxSentry;
        private System.Windows.Forms.GroupBox gbSentry;
        private System.Windows.Forms.DataGridView dgvSentry;
        private System.Windows.Forms.Button btnSentryListDone;
        private System.Windows.Forms.Button btnSentryDoneAdd;
        private System.Windows.Forms.Button btnSentryToDoAdd;
        private System.Windows.Forms.Button btnSentryListToDo;
        private System.Windows.Forms.RichTextBox rtbxSentryToDo;
        private System.Windows.Forms.ContextMenuStrip rightMenuDone;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}