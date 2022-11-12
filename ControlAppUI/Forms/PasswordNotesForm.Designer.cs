namespace ControlAppDesktop.Forms
{
    partial class PasswordNotesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordNotesForm));
            this.lblPasswordTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPasswordNotes = new System.Windows.Forms.Label();
            this.txtPasswordTitle = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPasswordNotes = new System.Windows.Forms.TextBox();
            this.gbDepartmentList = new System.Windows.Forms.GroupBox();
            this.dgvPassword = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.gbDepartmentList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassword)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPasswordTitle
            // 
            this.lblPasswordTitle.AutoSize = true;
            this.lblPasswordTitle.Location = new System.Drawing.Point(115, 50);
            this.lblPasswordTitle.Name = "lblPasswordTitle";
            this.lblPasswordTitle.Size = new System.Drawing.Size(74, 15);
            this.lblPasswordTitle.TabIndex = 120;
            this.lblPasswordTitle.Text = "Şifre Başlığı :";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(115, 81);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(36, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Şifre :";
            // 
            // lblPasswordNotes
            // 
            this.lblPasswordNotes.AutoSize = true;
            this.lblPasswordNotes.Location = new System.Drawing.Point(115, 109);
            this.lblPasswordNotes.Name = "lblPasswordNotes";
            this.lblPasswordNotes.Size = new System.Drawing.Size(46, 15);
            this.lblPasswordNotes.TabIndex = 2;
            this.lblPasswordNotes.Text = "Notlar :";
            // 
            // txtPasswordTitle
            // 
            this.txtPasswordTitle.Location = new System.Drawing.Point(217, 50);
            this.txtPasswordTitle.Name = "txtPasswordTitle";
            this.txtPasswordTitle.Size = new System.Drawing.Size(196, 21);
            this.txtPasswordTitle.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(217, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(196, 21);
            this.txtPassword.TabIndex = 1;
            // 
            // txtPasswordNotes
            // 
            this.txtPasswordNotes.Location = new System.Drawing.Point(217, 109);
            this.txtPasswordNotes.Multiline = true;
            this.txtPasswordNotes.Name = "txtPasswordNotes";
            this.txtPasswordNotes.Size = new System.Drawing.Size(196, 73);
            this.txtPasswordNotes.TabIndex = 2;
            // 
            // gbDepartmentList
            // 
            this.gbDepartmentList.Controls.Add(this.dgvPassword);
            this.gbDepartmentList.Location = new System.Drawing.Point(180, 285);
            this.gbDepartmentList.Name = "gbDepartmentList";
            this.gbDepartmentList.Size = new System.Drawing.Size(782, 257);
            this.gbDepartmentList.TabIndex = 25;
            this.gbDepartmentList.TabStop = false;
            this.gbDepartmentList.Text = "Şifreler";
            // 
            // dgvPassword
            // 
            this.dgvPassword.AllowUserToAddRows = false;
            this.dgvPassword.AllowUserToDeleteRows = false;
            this.dgvPassword.AllowUserToResizeColumns = false;
            this.dgvPassword.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvPassword.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPassword.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPassword.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvPassword.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassword.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvPassword.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPassword.Location = new System.Drawing.Point(3, 17);
            this.dgvPassword.MultiSelect = false;
            this.dgvPassword.Name = "dgvPassword";
            this.dgvPassword.ReadOnly = true;
            this.dgvPassword.RowHeadersVisible = false;
            this.dgvPassword.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPassword.Size = new System.Drawing.Size(776, 237);
            this.dgvPassword.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(208, 48);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.updateToolStripMenuItem.Text = "Güncellenecek Şifreyi Seç";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.refreshToolStripMenuItem.Text = "Yenile";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::ControlAppUICore.Properties.Resources.plus;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(289, 188);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::ControlAppUICore.Properties.Resources.upload;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(381, 188);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(32, 32);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::ControlAppUICore.Properties.Resources.loupe;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(868, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(32, 32);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            // 
            // txtSearchTitle
            // 
            this.txtSearchTitle.Location = new System.Drawing.Point(654, 56);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(196, 21);
            this.txtSearchTitle.TabIndex = 5;
            this.txtSearchTitle.Text = "Şifre Başlığına Göre Ara...";
            this.txtSearchTitle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearchTitle_MouseClick);
            this.txtSearchTitle.TextChanged += new System.EventHandler(this.txtSearchTitle_TextChanged);
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Location = new System.Drawing.Point(552, 59);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(74, 15);
            this.lblSearchTitle.TabIndex = 29;
            this.lblSearchTitle.Text = "Şifre Başlığı :";
            // 
            // PasswordNotesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.txtSearchTitle);
            this.Controls.Add(this.lblSearchTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gbDepartmentList);
            this.Controls.Add(this.txtPasswordNotes);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtPasswordTitle);
            this.Controls.Add(this.lblPasswordNotes);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblPasswordTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PasswordNotesForm";
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.PasswordNotesForm_Load);
            this.gbDepartmentList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassword)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPasswordTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPasswordNotes;
        private System.Windows.Forms.TextBox txtPasswordTitle;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPasswordNotes;
        private System.Windows.Forms.GroupBox gbDepartmentList;
        private System.Windows.Forms.DataGridView dgvPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}