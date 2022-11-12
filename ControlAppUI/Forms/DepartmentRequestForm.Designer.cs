namespace ControlAppDesktop
{
    partial class DepartmentRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentRequestForm));
            this.btnClose = new System.Windows.Forms.Button();
            this.grpDepartmentRequest = new System.Windows.Forms.GroupBox();
            this.dgvMyDepartmentRequest = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.takeToMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpDepartmentRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyDepartmentRequest)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ControlAppUICore.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1139, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 34);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // grpDepartmentRequest
            // 
            this.grpDepartmentRequest.Controls.Add(this.dgvMyDepartmentRequest);
            this.grpDepartmentRequest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDepartmentRequest.Location = new System.Drawing.Point(80, 204);
            this.grpDepartmentRequest.Margin = new System.Windows.Forms.Padding(4);
            this.grpDepartmentRequest.Name = "grpDepartmentRequest";
            this.grpDepartmentRequest.Padding = new System.Windows.Forms.Padding(4);
            this.grpDepartmentRequest.Size = new System.Drawing.Size(995, 356);
            this.grpDepartmentRequest.TabIndex = 9;
            this.grpDepartmentRequest.TabStop = false;
            this.grpDepartmentRequest.Text = "Departman İşler Listesi";
            // 
            // dgvMyDepartmentRequest
            // 
            this.dgvMyDepartmentRequest.AllowUserToAddRows = false;
            this.dgvMyDepartmentRequest.AllowUserToDeleteRows = false;
            this.dgvMyDepartmentRequest.AllowUserToResizeColumns = false;
            this.dgvMyDepartmentRequest.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvMyDepartmentRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMyDepartmentRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMyDepartmentRequest.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvMyDepartmentRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyDepartmentRequest.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvMyDepartmentRequest.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvMyDepartmentRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyDepartmentRequest.Location = new System.Drawing.Point(4, 20);
            this.dgvMyDepartmentRequest.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMyDepartmentRequest.MultiSelect = false;
            this.dgvMyDepartmentRequest.Name = "dgvMyDepartmentRequest";
            this.dgvMyDepartmentRequest.ReadOnly = true;
            this.dgvMyDepartmentRequest.RowHeadersVisible = false;
            this.dgvMyDepartmentRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyDepartmentRequest.Size = new System.Drawing.Size(987, 332);
            this.dgvMyDepartmentRequest.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.takeToMeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 26);
            // 
            // takeToMeToolStripMenuItem
            // 
            this.takeToMeToolStripMenuItem.Name = "takeToMeToolStripMenuItem";
            this.takeToMeToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.takeToMeToolStripMenuItem.Text = "Üstüne Al";
            this.takeToMeToolStripMenuItem.Click += new System.EventHandler(this.takeToMeToolStripMenuItem_Click);
            // 
            // DepartmentRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.grpDepartmentRequest);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DepartmentRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.DepartmentRequestForm_Load);
            this.grpDepartmentRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyDepartmentRequest)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox grpDepartmentRequest;
        private System.Windows.Forms.DataGridView dgvMyDepartmentRequest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem takeToMeToolStripMenuItem;
    }
}