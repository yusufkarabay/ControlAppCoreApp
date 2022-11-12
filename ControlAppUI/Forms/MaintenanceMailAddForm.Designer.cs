namespace ControlAppDesktop.Forms
{
    partial class MaintenanceMailAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceMailAddForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblMailEmployee = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbMail = new System.Windows.Forms.GroupBox();
            this.dgvMail = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnList = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.gbMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMail)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ControlAppUICore.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1134, 12);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(37, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(143, 103);
            this.lblMail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(73, 15);
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "Mail Adresi :";
            // 
            // lblMailEmployee
            // 
            this.lblMailEmployee.AutoSize = true;
            this.lblMailEmployee.Location = new System.Drawing.Point(143, 142);
            this.lblMailEmployee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMailEmployee.Name = "lblMailEmployee";
            this.lblMailEmployee.Size = new System.Drawing.Size(72, 15);
            this.lblMailEmployee.TabIndex = 2;
            this.lblMailEmployee.Text = "Mail Sahibi :";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(241, 99);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(219, 21);
            this.txtMail.TabIndex = 0;
            // 
            // txtEmployee
            // 
            this.txtEmployee.Location = new System.Drawing.Point(241, 142);
            this.txtEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(219, 21);
            this.txtEmployee.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::ControlAppUICore.Properties.Resources.plus;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(484, 118);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbMail
            // 
            this.gbMail.Controls.Add(this.dgvMail);
            this.gbMail.Location = new System.Drawing.Point(53, 253);
            this.gbMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbMail.Name = "gbMail";
            this.gbMail.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbMail.Size = new System.Drawing.Size(1066, 310);
            this.gbMail.TabIndex = 27;
            this.gbMail.TabStop = false;
            this.gbMail.Text = "Mail Listesi";
            // 
            // dgvMail
            // 
            this.dgvMail.AllowUserToAddRows = false;
            this.dgvMail.AllowUserToDeleteRows = false;
            this.dgvMail.AllowUserToResizeColumns = false;
            this.dgvMail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvMail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMail.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMail.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMail.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMail.Location = new System.Drawing.Point(4, 17);
            this.dgvMail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvMail.MultiSelect = false;
            this.dgvMail.Name = "dgvMail";
            this.dgvMail.ReadOnly = true;
            this.dgvMail.RowHeadersVisible = false;
            this.dgvMail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMail.Size = new System.Drawing.Size(1058, 290);
            this.dgvMail.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
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
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Location = new System.Drawing.Point(1008, 228);
            this.btnList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(108, 23);
            this.btnList.TabIndex = 3;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::ControlAppUICore.Properties.Resources.upload;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(549, 118);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(32, 32);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MaintenanceMailAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.gbMail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lblMailEmployee);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MaintenanceMailAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App";
            this.gbMail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMail)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblMailEmployee;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbMail;
        private System.Windows.Forms.DataGridView dgvMail;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}