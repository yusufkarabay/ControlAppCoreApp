namespace ControlAppDesktop.Forms
{
    partial class RequestCreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestCreateForm));
            this.lblRequestTitle = new System.Windows.Forms.Label();
            this.lblRequestContent = new System.Windows.Forms.Label();
            this.lblRequestDepartment = new System.Windows.Forms.Label();
            this.txtRequestTitle = new System.Windows.Forms.TextBox();
            this.rtxtRequestContext = new System.Windows.Forms.RichTextBox();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.grpNotRequest = new System.Windows.Forms.GroupBox();
            this.dgvNotRequest = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.requestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRequestlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnRequestCreate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpNotRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotRequest)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRequestTitle
            // 
            this.lblRequestTitle.AutoSize = true;
            this.lblRequestTitle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRequestTitle.Location = new System.Drawing.Point(65, 55);
            this.lblRequestTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestTitle.Name = "lblRequestTitle";
            this.lblRequestTitle.Size = new System.Drawing.Size(79, 15);
            this.lblRequestTitle.TabIndex = 0;
            this.lblRequestTitle.Text = "Talep Konusu";
            // 
            // lblRequestContent
            // 
            this.lblRequestContent.AutoSize = true;
            this.lblRequestContent.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRequestContent.Location = new System.Drawing.Point(65, 105);
            this.lblRequestContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestContent.Name = "lblRequestContent";
            this.lblRequestContent.Size = new System.Drawing.Size(72, 15);
            this.lblRequestContent.TabIndex = 1;
            this.lblRequestContent.Text = "Talep İçeriği";
            // 
            // lblRequestDepartment
            // 
            this.lblRequestDepartment.AutoSize = true;
            this.lblRequestDepartment.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRequestDepartment.Location = new System.Drawing.Point(593, 55);
            this.lblRequestDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestDepartment.Name = "lblRequestDepartment";
            this.lblRequestDepartment.Size = new System.Drawing.Size(107, 15);
            this.lblRequestDepartment.TabIndex = 2;
            this.lblRequestDepartment.Text = "Talep Departmanı :";
            this.lblRequestDepartment.Visible = false;
            // 
            // txtRequestTitle
            // 
            this.txtRequestTitle.Location = new System.Drawing.Point(195, 47);
            this.txtRequestTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtRequestTitle.Name = "txtRequestTitle";
            this.txtRequestTitle.Size = new System.Drawing.Size(354, 21);
            this.txtRequestTitle.TabIndex = 0;
            // 
            // rtxtRequestContext
            // 
            this.rtxtRequestContext.Location = new System.Drawing.Point(195, 105);
            this.rtxtRequestContext.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtRequestContext.Name = "rtxtRequestContext";
            this.rtxtRequestContext.Size = new System.Drawing.Size(354, 106);
            this.rtxtRequestContext.TabIndex = 1;
            this.rtxtRequestContext.Text = "";
            // 
            // cbDepartment
            // 
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(724, 55);
            this.cbDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(184, 24);
            this.cbDepartment.TabIndex = 3;
            this.cbDepartment.Visible = false;
            // 
            // grpNotRequest
            // 
            this.grpNotRequest.Controls.Add(this.dgvNotRequest);
            this.grpNotRequest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpNotRequest.Location = new System.Drawing.Point(68, 340);
            this.grpNotRequest.Margin = new System.Windows.Forms.Padding(4);
            this.grpNotRequest.Name = "grpNotRequest";
            this.grpNotRequest.Padding = new System.Windows.Forms.Padding(4);
            this.grpNotRequest.Size = new System.Drawing.Size(1026, 335);
            this.grpNotRequest.TabIndex = 8;
            this.grpNotRequest.TabStop = false;
            this.grpNotRequest.Text = "Atanmamış İşler Listesi";
            // 
            // dgvNotRequest
            // 
            this.dgvNotRequest.AllowUserToAddRows = false;
            this.dgvNotRequest.AllowUserToDeleteRows = false;
            this.dgvNotRequest.AllowUserToResizeColumns = false;
            this.dgvNotRequest.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvNotRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotRequest.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvNotRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotRequest.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvNotRequest.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvNotRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNotRequest.Location = new System.Drawing.Point(4, 18);
            this.dgvNotRequest.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNotRequest.MultiSelect = false;
            this.dgvNotRequest.Name = "dgvNotRequest";
            this.dgvNotRequest.ReadOnly = true;
            this.dgvNotRequest.RowHeadersVisible = false;
            this.dgvNotRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotRequest.Size = new System.Drawing.Size(1018, 313);
            this.dgvNotRequest.TabIndex = 0;
            this.dgvNotRequest.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvNotRequest_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestToolStripMenuItem,
            this.deleteRequestlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 48);
            // 
            // requestToolStripMenuItem
            // 
            this.requestToolStripMenuItem.Name = "requestToolStripMenuItem";
            this.requestToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.requestToolStripMenuItem.Text = "Talep Et";
            this.requestToolStripMenuItem.Click += new System.EventHandler(this.requestToolStripMenuItem_Click);
            // 
            // deleteRequestlToolStripMenuItem
            // 
            this.deleteRequestlToolStripMenuItem.Name = "deleteRequestlToolStripMenuItem";
            this.deleteRequestlToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.deleteRequestlToolStripMenuItem.Text = "Sil";
            this.deleteRequestlToolStripMenuItem.Click += new System.EventHandler(this.deleteRequestlToolStripMenuItem_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackgroundImage = global::ControlAppUICore.Properties.Resources.send;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(793, 89);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(32, 32);
            this.btnSend.TabIndex = 4;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Visible = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnRequestCreate
            // 
            this.btnRequestCreate.BackgroundImage = global::ControlAppUICore.Properties.Resources.plus;
            this.btnRequestCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRequestCreate.FlatAppearance.BorderSize = 0;
            this.btnRequestCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestCreate.Location = new System.Drawing.Point(355, 237);
            this.btnRequestCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnRequestCreate.Name = "btnRequestCreate";
            this.btnRequestCreate.Size = new System.Drawing.Size(32, 32);
            this.btnRequestCreate.TabIndex = 2;
            this.btnRequestCreate.UseVisualStyleBackColor = true;
            this.btnRequestCreate.Click += new System.EventHandler(this.btnRequestCreate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::ControlAppUICore.Properties.Resources.close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1126, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RequestCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.grpNotRequest);
            this.Controls.Add(this.btnRequestCreate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.cbDepartment);
            this.Controls.Add(this.rtxtRequestContext);
            this.Controls.Add(this.txtRequestTitle);
            this.Controls.Add(this.lblRequestDepartment);
            this.Controls.Add(this.lblRequestContent);
            this.Controls.Add(this.lblRequestTitle);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RequestCreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.RequestCreateForm_Load);
            this.grpNotRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotRequest)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestTitle;
        private System.Windows.Forms.Label lblRequestContent;
        private System.Windows.Forms.Label lblRequestDepartment;
        private System.Windows.Forms.TextBox txtRequestTitle;
        private System.Windows.Forms.RichTextBox rtxtRequestContext;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRequestCreate;
        private System.Windows.Forms.GroupBox grpNotRequest;
        private System.Windows.Forms.DataGridView dgvNotRequest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem requestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteRequestlToolStripMenuItem;
        private System.Windows.Forms.Button btnSend;
    }
}