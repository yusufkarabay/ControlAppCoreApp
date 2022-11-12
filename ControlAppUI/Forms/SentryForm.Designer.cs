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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SentryForm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rtbxSentry = new System.Windows.Forms.RichTextBox();
            this.gbSentry = new System.Windows.Forms.GroupBox();
            this.dgvSentryTodo = new System.Windows.Forms.DataGridView();
            this.rightMenuToDo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvSentry = new System.Windows.Forms.DataGridView();
            this.rightMenuDone = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yenileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbxSentryToDo = new System.Windows.Forms.RichTextBox();
            this.btnSentryToDoUpdate = new System.Windows.Forms.Button();
            this.btnSentryDoneUpdate = new System.Windows.Forms.Button();
            this.btnSentryListToDo = new System.Windows.Forms.Button();
            this.btnSentryToDoAdd = new System.Windows.Forms.Button();
            this.btnSentryDoneAdd = new System.Windows.Forms.Button();
            this.btnSentryListDone = new System.Windows.Forms.Button();
            this.gbSentry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentryTodo)).BeginInit();
            this.rightMenuToDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentry)).BeginInit();
            this.rightMenuDone.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(467, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
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
            this.gbSentry.Controls.Add(this.dgvSentryTodo);
            this.gbSentry.Controls.Add(this.dgvSentry);
            this.gbSentry.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbSentry.Location = new System.Drawing.Point(55, 406);
            this.gbSentry.Name = "gbSentry";
            this.gbSentry.Size = new System.Drawing.Size(1039, 266);
            this.gbSentry.TabIndex = 2;
            this.gbSentry.TabStop = false;
            this.gbSentry.Text = "Yapılan İşler";
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSentryTodo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSentryTodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSentryTodo.ContextMenuStrip = this.rightMenuToDo;
            this.dgvSentryTodo.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvSentryTodo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSentryTodo.GridColor = System.Drawing.Color.LightGray;
            this.dgvSentryTodo.Location = new System.Drawing.Point(3, 17);
            this.dgvSentryTodo.MultiSelect = false;
            this.dgvSentryTodo.Name = "dgvSentryTodo";
            this.dgvSentryTodo.ReadOnly = true;
            this.dgvSentryTodo.RowHeadersVisible = false;
            this.dgvSentryTodo.RowHeadersWidth = 51;
            this.dgvSentryTodo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSentryTodo.Size = new System.Drawing.Size(1033, 246);
            this.dgvSentryTodo.TabIndex = 4;
            this.dgvSentryTodo.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSentryTodo_CellMouseClick);
            // 
            // rightMenuToDo
            // 
            this.rightMenuToDo.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.rightMenuToDo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gToolStripMenuItem,
            this.silToolStripMenuItem1,
            this.yenileToolStripMenuItem1});
            this.rightMenuToDo.Name = "rightMenuToDo";
            this.rightMenuToDo.Size = new System.Drawing.Size(205, 70);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.gToolStripMenuItem.Text = "Güncellenecek Kaydı Seç";
            this.gToolStripMenuItem.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // yenileToolStripMenuItem1
            // 
            this.yenileToolStripMenuItem1.Name = "yenileToolStripMenuItem1";
            this.yenileToolStripMenuItem1.Size = new System.Drawing.Size(204, 22);
            this.yenileToolStripMenuItem1.Text = "Yenile";
            this.yenileToolStripMenuItem1.Click += new System.EventHandler(this.yenileToolStripMenuItem1_Click);
            // 
            // dgvSentry
            // 
            this.dgvSentry.AllowUserToAddRows = false;
            this.dgvSentry.AllowUserToDeleteRows = false;
            this.dgvSentry.AllowUserToResizeColumns = false;
            this.dgvSentry.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            this.dgvSentry.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSentry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSentry.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvSentry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSentry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem,
            this.yenileToolStripMenuItem});
            this.rightMenuDone.Name = "contextMenuStrip1";
            this.rightMenuDone.Size = new System.Drawing.Size(205, 70);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.güncelleToolStripMenuItem.Text = "Güncellenecek Kaydı Seç";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // yenileToolStripMenuItem
            // 
            this.yenileToolStripMenuItem.Name = "yenileToolStripMenuItem";
            this.yenileToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.yenileToolStripMenuItem.Text = "Yenile";
            this.yenileToolStripMenuItem.Click += new System.EventHandler(this.yenileToolStripMenuItem_Click);
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
            // btnSentryToDoUpdate
            // 
            this.btnSentryToDoUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnSentryToDoUpdate.BackgroundImage = global::ControlAppUICore.Properties.Resources.upload;
            this.btnSentryToDoUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSentryToDoUpdate.FlatAppearance.BorderSize = 0;
            this.btnSentryToDoUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentryToDoUpdate.Location = new System.Drawing.Point(1021, 277);
            this.btnSentryToDoUpdate.Name = "btnSentryToDoUpdate";
            this.btnSentryToDoUpdate.Size = new System.Drawing.Size(32, 32);
            this.btnSentryToDoUpdate.TabIndex = 11;
            this.btnSentryToDoUpdate.UseVisualStyleBackColor = false;
            this.btnSentryToDoUpdate.Visible = false;
            this.btnSentryToDoUpdate.Click += new System.EventHandler(this.btnSentryToDoUpdate_Click);
            // 
            // btnSentryDoneUpdate
            // 
            this.btnSentryDoneUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnSentryDoneUpdate.BackgroundImage = global::ControlAppUICore.Properties.Resources.upload;
            this.btnSentryDoneUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSentryDoneUpdate.FlatAppearance.BorderSize = 0;
            this.btnSentryDoneUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentryDoneUpdate.Location = new System.Drawing.Point(408, 281);
            this.btnSentryDoneUpdate.Name = "btnSentryDoneUpdate";
            this.btnSentryDoneUpdate.Size = new System.Drawing.Size(32, 32);
            this.btnSentryDoneUpdate.TabIndex = 9;
            this.btnSentryDoneUpdate.UseVisualStyleBackColor = false;
            this.btnSentryDoneUpdate.Click += new System.EventHandler(this.btnSentryDoneUpdate_Click);
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
            this.Controls.Add(this.btnSentryToDoUpdate);
            this.Controls.Add(this.btnSentryDoneUpdate);
            this.Controls.Add(this.rtbxSentryToDo);
            this.Controls.Add(this.btnSentryListToDo);
            this.Controls.Add(this.btnSentryToDoAdd);
            this.Controls.Add(this.btnSentryDoneAdd);
            this.Controls.Add(this.btnSentryListDone);
            this.Controls.Add(this.gbSentry);
            this.Controls.Add(this.rtbxSentry);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SentryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.SentryForm_Load);
            this.gbSentry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentryTodo)).EndInit();
            this.rightMenuToDo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSentry)).EndInit();
            this.rightMenuDone.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RichTextBox rtbxSentry;
        private System.Windows.Forms.GroupBox gbSentry;
        private System.Windows.Forms.DataGridView dgvSentry;
        private System.Windows.Forms.Button btnSentryListDone;
        private System.Windows.Forms.Button btnSentryDoneAdd;
        private System.Windows.Forms.Button btnSentryToDoAdd;
        private System.Windows.Forms.Button btnSentryListToDo;
        private System.Windows.Forms.RichTextBox rtbxSentryToDo;
        private System.Windows.Forms.ContextMenuStrip rightMenuDone;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.Button btnSentryDoneUpdate;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip rightMenuToDo;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yenileToolStripMenuItem1;
        private System.Windows.Forms.Button btnSentryToDoUpdate;
        private System.Windows.Forms.DataGridView dgvSentryTodo;
    }
}