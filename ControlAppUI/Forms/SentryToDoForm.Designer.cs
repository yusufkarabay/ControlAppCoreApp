namespace ControlAppUICore.Forms
{
    partial class SentryToDoForm
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
            this.gbSentry = new System.Windows.Forms.GroupBox();
            this.dgvSentryTodo = new System.Windows.Forms.DataGridView();
            this.rightMenuDone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpSentry = new System.Windows.Forms.DateTimePicker();
            this.rtbxSentryToDo = new System.Windows.Forms.RichTextBox();
            this.btnSentryListToDo = new System.Windows.Forms.Button();
            this.btnSentryToDoAdd = new System.Windows.Forms.Button();
            this.gbSentry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentryTodo)).BeginInit();
            this.rightMenuDone.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSentry
            // 
            this.gbSentry.BackColor = System.Drawing.Color.LightGray;
            this.gbSentry.Controls.Add(this.dgvSentryTodo);
            this.gbSentry.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbSentry.Location = new System.Drawing.Point(73, 429);
            this.gbSentry.Name = "gbSentry";
            this.gbSentry.Size = new System.Drawing.Size(1039, 266);
            this.gbSentry.TabIndex = 10;
            this.gbSentry.TabStop = false;
            this.gbSentry.Text = "Nöbet İşlemleri";
            // 
            // dgvSentryTodo
            // 
            this.dgvSentryTodo.AllowUserToAddRows = false;
            this.dgvSentryTodo.AllowUserToDeleteRows = false;
            this.dgvSentryTodo.AllowUserToResizeColumns = false;
            this.dgvSentryTodo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvSentryTodo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSentryTodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSentryTodo.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvSentryTodo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSentryTodo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSentryTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSentryTodo.ContextMenuStrip = this.rightMenuDone;
            this.dgvSentryTodo.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvSentryTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSentryTodo.Location = new System.Drawing.Point(3, 17);
            this.dgvSentryTodo.MultiSelect = false;
            this.dgvSentryTodo.Name = "dgvSentryTodo";
            this.dgvSentryTodo.ReadOnly = true;
            this.dgvSentryTodo.RowHeadersVisible = false;
            this.dgvSentryTodo.RowHeadersWidth = 51;
            this.dgvSentryTodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSentryTodo.Size = new System.Drawing.Size(1033, 246);
            this.dgvSentryTodo.TabIndex = 1;
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
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.deleteToolStripMenuItem.Text = "Sil";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.refreshToolStripMenuItem.Text = "Yenile";
            // 
            // dtpSentry
            // 
            this.dtpSentry.Location = new System.Drawing.Point(485, 36);
            this.dtpSentry.Name = "dtpSentry";
            this.dtpSentry.Size = new System.Drawing.Size(200, 21);
            this.dtpSentry.TabIndex = 9;
            // 
            // rtbxSentryToDo
            // 
            this.rtbxSentryToDo.Location = new System.Drawing.Point(334, 117);
            this.rtbxSentryToDo.Name = "rtbxSentryToDo";
            this.rtbxSentryToDo.Size = new System.Drawing.Size(472, 149);
            this.rtbxSentryToDo.TabIndex = 13;
            this.rtbxSentryToDo.Text = "Takip edilecek işlemler...";
            // 
            // btnSentryListToDo
            // 
            this.btnSentryListToDo.BackColor = System.Drawing.Color.Transparent;
            this.btnSentryListToDo.BackgroundImage = global::ControlAppUICore.Properties.Resources.loupe;
            this.btnSentryListToDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSentryListToDo.FlatAppearance.BorderSize = 0;
            this.btnSentryListToDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentryListToDo.Location = new System.Drawing.Point(765, 304);
            this.btnSentryListToDo.Name = "btnSentryListToDo";
            this.btnSentryListToDo.Size = new System.Drawing.Size(32, 32);
            this.btnSentryListToDo.TabIndex = 12;
            this.btnSentryListToDo.UseVisualStyleBackColor = false;
            this.btnSentryListToDo.Click += new System.EventHandler(this.btnSentryListToDo_Click);
            // 
            // btnSentryToDoAdd
            // 
            this.btnSentryToDoAdd.BackgroundImage = global::ControlAppUICore.Properties.Resources.plus;
            this.btnSentryToDoAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSentryToDoAdd.FlatAppearance.BorderSize = 0;
            this.btnSentryToDoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentryToDoAdd.Location = new System.Drawing.Point(351, 304);
            this.btnSentryToDoAdd.Name = "btnSentryToDoAdd";
            this.btnSentryToDoAdd.Size = new System.Drawing.Size(32, 32);
            this.btnSentryToDoAdd.TabIndex = 11;
            this.btnSentryToDoAdd.UseVisualStyleBackColor = true;
            this.btnSentryToDoAdd.Click += new System.EventHandler(this.btnSentryToDoAdd_Click);
            // 
            // SentryToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.gbSentry);
            this.Controls.Add(this.dtpSentry);
            this.Controls.Add(this.rtbxSentryToDo);
            this.Controls.Add(this.btnSentryListToDo);
            this.Controls.Add(this.btnSentryToDoAdd);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SentryToDoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SentryToDoForm";
            this.gbSentry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentryTodo)).EndInit();
            this.rightMenuDone.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbSentry;
        private DataGridView dgvSentryTodo;
        private ContextMenuStrip rightMenuDone;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;
        private DateTimePicker dtpSentry;
        private RichTextBox rtbxSentryToDo;
        private Button btnSentryListToDo;
        private Button btnSentryToDoAdd;
    }
}