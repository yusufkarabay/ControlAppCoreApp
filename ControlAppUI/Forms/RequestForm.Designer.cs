namespace ControlAppDesktop.Forms
{
    partial class RequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RequestForm));
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.Label();
            this.employeeSurname = new System.Windows.Forms.Label();
            this.employeeName = new System.Windows.Forms.Label();
            this.lblDepartmentInfo = new System.Windows.Forms.Label();
            this.lblSurnameInfo = new System.Windows.Forms.Label();
            this.lblNameInfo = new System.Windows.Forms.Label();
            this.lblTcInfo = new System.Windows.Forms.Label();
            this.tlblTime = new System.Windows.Forms.Label();
            this.grpRequest = new System.Windows.Forms.GroupBox();
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.requestEndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbRequestRead = new System.Windows.Forms.GroupBox();
            this.richTxtRequestContent = new System.Windows.Forms.RichTextBox();
            this.txtRequested = new System.Windows.Forms.TextBox();
            this.txtRequestTitle = new System.Windows.Forms.TextBox();
            this.requested = new System.Windows.Forms.Label();
            this.lblrequestDetail = new System.Windows.Forms.Label();
            this.requestName = new System.Windows.Forms.Label();
            this.grpAction = new System.Windows.Forms.GroupBox();
            this.btnCompleteRequest = new System.Windows.Forms.Button();
            this.btnDepartmentRequest = new System.Windows.Forms.Button();
            this.btnMyRequest = new System.Windows.Forms.Button();
            this.btnCreateRequest = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.btnRequestRefresh = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblCountInfo = new System.Windows.Forms.Label();
            this.lblEndText = new System.Windows.Forms.Label();
            this.rtbEndText = new System.Windows.Forms.RichTextBox();
            this.btnEndRequest = new System.Windows.Forms.Button();
            this.rtbEndTextRead = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpInfo.SuspendLayout();
            this.grpRequest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gbRequestRead.SuspendLayout();
            this.grpAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.label1);
            this.grpInfo.Controls.Add(this.department);
            this.grpInfo.Controls.Add(this.employeeSurname);
            this.grpInfo.Controls.Add(this.employeeName);
            this.grpInfo.Controls.Add(this.lblDepartmentInfo);
            this.grpInfo.Controls.Add(this.lblSurnameInfo);
            this.grpInfo.Controls.Add(this.lblNameInfo);
            this.grpInfo.Controls.Add(this.lblTcInfo);
            this.grpInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpInfo.Location = new System.Drawing.Point(82, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(300, 159);
            this.grpInfo.TabIndex = 0;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Kişi Bilgileri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "TC:";
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Location = new System.Drawing.Point(6, 103);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(69, 15);
            this.department.TabIndex = 8;
            this.department.Text = "Departman:";
            // 
            // employeeSurname
            // 
            this.employeeSurname.AutoSize = true;
            this.employeeSurname.Location = new System.Drawing.Point(6, 77);
            this.employeeSurname.Name = "employeeSurname";
            this.employeeSurname.Size = new System.Drawing.Size(43, 15);
            this.employeeSurname.TabIndex = 3;
            this.employeeSurname.Text = "Soyad:";
            // 
            // employeeName
            // 
            this.employeeName.AutoSize = true;
            this.employeeName.Location = new System.Drawing.Point(6, 51);
            this.employeeName.Name = "employeeName";
            this.employeeName.Size = new System.Drawing.Size(25, 15);
            this.employeeName.TabIndex = 2;
            this.employeeName.Text = "Ad:";
            // 
            // lblDepartmentInfo
            // 
            this.lblDepartmentInfo.AutoSize = true;
            this.lblDepartmentInfo.Location = new System.Drawing.Point(100, 103);
            this.lblDepartmentInfo.Name = "lblDepartmentInfo";
            this.lblDepartmentInfo.Size = new System.Drawing.Size(19, 15);
            this.lblDepartmentInfo.TabIndex = 9;
            this.lblDepartmentInfo.Text = "00";
            // 
            // lblSurnameInfo
            // 
            this.lblSurnameInfo.AutoSize = true;
            this.lblSurnameInfo.Location = new System.Drawing.Point(100, 77);
            this.lblSurnameInfo.Name = "lblSurnameInfo";
            this.lblSurnameInfo.Size = new System.Drawing.Size(19, 15);
            this.lblSurnameInfo.TabIndex = 5;
            this.lblSurnameInfo.Text = "00";
            // 
            // lblNameInfo
            // 
            this.lblNameInfo.AutoSize = true;
            this.lblNameInfo.Location = new System.Drawing.Point(100, 51);
            this.lblNameInfo.Name = "lblNameInfo";
            this.lblNameInfo.Size = new System.Drawing.Size(19, 15);
            this.lblNameInfo.TabIndex = 4;
            this.lblNameInfo.Text = "00";
            // 
            // lblTcInfo
            // 
            this.lblTcInfo.AutoSize = true;
            this.lblTcInfo.Location = new System.Drawing.Point(100, 25);
            this.lblTcInfo.Name = "lblTcInfo";
            this.lblTcInfo.Size = new System.Drawing.Size(19, 15);
            this.lblTcInfo.TabIndex = 1;
            this.lblTcInfo.Text = "00";
            // 
            // tlblTime
            // 
            this.tlblTime.AutoSize = true;
            this.tlblTime.Location = new System.Drawing.Point(941, 9);
            this.tlblTime.Name = "tlblTime";
            this.tlblTime.Size = new System.Drawing.Size(46, 16);
            this.tlblTime.TabIndex = 1;
            this.tlblTime.Text = "Zaman";
            // 
            // grpRequest
            // 
            this.grpRequest.Controls.Add(this.dgvRequest);
            this.grpRequest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpRequest.Location = new System.Drawing.Point(82, 229);
            this.grpRequest.Name = "grpRequest";
            this.grpRequest.Size = new System.Drawing.Size(1014, 272);
            this.grpRequest.TabIndex = 2;
            this.grpRequest.TabStop = false;
            this.grpRequest.Text = "Benden Talep Edilenler";
            // 
            // dgvRequest
            // 
            this.dgvRequest.AllowUserToAddRows = false;
            this.dgvRequest.AllowUserToDeleteRows = false;
            this.dgvRequest.AllowUserToResizeColumns = false;
            this.dgvRequest.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvRequest.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRequest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRequest.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvRequest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvRequest.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRequest.Location = new System.Drawing.Point(3, 17);
            this.dgvRequest.MultiSelect = false;
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.ReadOnly = true;
            this.dgvRequest.RowHeadersVisible = false;
            this.dgvRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequest.Size = new System.Drawing.Size(1008, 252);
            this.dgvRequest.TabIndex = 0;
            this.dgvRequest.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRequest_CellMouseClick);
            this.dgvRequest.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRequest_CellMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestEndToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(139, 26);
            // 
            // requestEndToolStripMenuItem
            // 
            this.requestEndToolStripMenuItem.Name = "requestEndToolStripMenuItem";
            this.requestEndToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.requestEndToolStripMenuItem.Text = "İşi Sonlandır";
            this.requestEndToolStripMenuItem.Click += new System.EventHandler(this.requestEndToolStripMenuItem_Click);
            // 
            // gbRequestRead
            // 
            this.gbRequestRead.Controls.Add(this.rtbEndTextRead);
            this.gbRequestRead.Controls.Add(this.label2);
            this.gbRequestRead.Controls.Add(this.richTxtRequestContent);
            this.gbRequestRead.Controls.Add(this.txtRequested);
            this.gbRequestRead.Controls.Add(this.txtRequestTitle);
            this.gbRequestRead.Controls.Add(this.requested);
            this.gbRequestRead.Controls.Add(this.lblrequestDetail);
            this.gbRequestRead.Controls.Add(this.requestName);
            this.gbRequestRead.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbRequestRead.Location = new System.Drawing.Point(85, 520);
            this.gbRequestRead.Name = "gbRequestRead";
            this.gbRequestRead.Size = new System.Drawing.Size(1022, 207);
            this.gbRequestRead.TabIndex = 3;
            this.gbRequestRead.TabStop = false;
            this.gbRequestRead.Text = "Talep Bilgileri";
            // 
            // richTxtRequestContent
            // 
            this.richTxtRequestContent.Location = new System.Drawing.Point(183, 99);
            this.richTxtRequestContent.Name = "richTxtRequestContent";
            this.richTxtRequestContent.ReadOnly = true;
            this.richTxtRequestContent.Size = new System.Drawing.Size(282, 96);
            this.richTxtRequestContent.TabIndex = 10;
            this.richTxtRequestContent.Text = "";
            this.richTxtRequestContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTxtRequestContent_KeyDown);
            this.richTxtRequestContent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTxtRequestContent_KeyPress);
            // 
            // txtRequested
            // 
            this.txtRequested.Location = new System.Drawing.Point(183, 64);
            this.txtRequested.Name = "txtRequested";
            this.txtRequested.ReadOnly = true;
            this.txtRequested.Size = new System.Drawing.Size(282, 21);
            this.txtRequested.TabIndex = 9;
            this.txtRequested.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRequested_KeyDown);
            this.txtRequested.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRequested_KeyPress);
            // 
            // txtRequestTitle
            // 
            this.txtRequestTitle.Location = new System.Drawing.Point(183, 27);
            this.txtRequestTitle.Name = "txtRequestTitle";
            this.txtRequestTitle.ReadOnly = true;
            this.txtRequestTitle.Size = new System.Drawing.Size(282, 21);
            this.txtRequestTitle.TabIndex = 8;
            this.txtRequestTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRequestTitle_KeyDown);
            this.txtRequestTitle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRequestTitle_KeyPress);
            // 
            // requested
            // 
            this.requested.AutoSize = true;
            this.requested.Location = new System.Drawing.Point(16, 71);
            this.requested.Name = "requested";
            this.requested.Size = new System.Drawing.Size(72, 15);
            this.requested.TabIndex = 2;
            this.requested.Text = "Talep Eden :";
            // 
            // lblrequestDetail
            // 
            this.lblrequestDetail.AutoSize = true;
            this.lblrequestDetail.Location = new System.Drawing.Point(16, 102);
            this.lblrequestDetail.Name = "lblrequestDetail";
            this.lblrequestDetail.Size = new System.Drawing.Size(103, 15);
            this.lblrequestDetail.TabIndex = 1;
            this.lblrequestDetail.Text = "Talep Açıklaması :";
            // 
            // requestName
            // 
            this.requestName.AutoSize = true;
            this.requestName.Location = new System.Drawing.Point(16, 35);
            this.requestName.Name = "requestName";
            this.requestName.Size = new System.Drawing.Size(63, 15);
            this.requestName.TabIndex = 0;
            this.requestName.Text = "Talep Adı :";
            // 
            // grpAction
            // 
            this.grpAction.Controls.Add(this.btnCompleteRequest);
            this.grpAction.Controls.Add(this.btnDepartmentRequest);
            this.grpAction.Controls.Add(this.btnMyRequest);
            this.grpAction.Controls.Add(this.btnCreateRequest);
            this.grpAction.Controls.Add(this.btnWeb);
            this.grpAction.Controls.Add(this.btnRequestRefresh);
            this.grpAction.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAction.Location = new System.Drawing.Point(453, 12);
            this.grpAction.Name = "grpAction";
            this.grpAction.Size = new System.Drawing.Size(245, 211);
            this.grpAction.TabIndex = 4;
            this.grpAction.TabStop = false;
            this.grpAction.Text = "Aksiyonlar";
            // 
            // btnCompleteRequest
            // 
            this.btnCompleteRequest.BackColor = System.Drawing.Color.Gray;
            this.btnCompleteRequest.FlatAppearance.BorderSize = 0;
            this.btnCompleteRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteRequest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompleteRequest.Location = new System.Drawing.Point(13, 141);
            this.btnCompleteRequest.Name = "btnCompleteRequest";
            this.btnCompleteRequest.Size = new System.Drawing.Size(176, 23);
            this.btnCompleteRequest.TabIndex = 5;
            this.btnCompleteRequest.Text = "Tamamlanan Talepler";
            this.btnCompleteRequest.UseVisualStyleBackColor = false;
            this.btnCompleteRequest.Click += new System.EventHandler(this.btnCompleteRequest_Click);
            // 
            // btnDepartmentRequest
            // 
            this.btnDepartmentRequest.BackColor = System.Drawing.Color.Gray;
            this.btnDepartmentRequest.FlatAppearance.BorderSize = 0;
            this.btnDepartmentRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartmentRequest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDepartmentRequest.Location = new System.Drawing.Point(13, 83);
            this.btnDepartmentRequest.Name = "btnDepartmentRequest";
            this.btnDepartmentRequest.Size = new System.Drawing.Size(176, 23);
            this.btnDepartmentRequest.TabIndex = 0;
            this.btnDepartmentRequest.Text = "Departmana Gelen Talepler";
            this.btnDepartmentRequest.UseVisualStyleBackColor = false;
            this.btnDepartmentRequest.Click += new System.EventHandler(this.btnDepartmentRequest_Click);
            // 
            // btnMyRequest
            // 
            this.btnMyRequest.BackColor = System.Drawing.Color.Gray;
            this.btnMyRequest.FlatAppearance.BorderSize = 0;
            this.btnMyRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyRequest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMyRequest.Location = new System.Drawing.Point(13, 112);
            this.btnMyRequest.Name = "btnMyRequest";
            this.btnMyRequest.Size = new System.Drawing.Size(176, 23);
            this.btnMyRequest.TabIndex = 4;
            this.btnMyRequest.Text = "Talep Ettiklerim";
            this.btnMyRequest.UseVisualStyleBackColor = false;
            this.btnMyRequest.Click += new System.EventHandler(this.btnMyRequest_Click);
            // 
            // btnCreateRequest
            // 
            this.btnCreateRequest.BackColor = System.Drawing.Color.Gray;
            this.btnCreateRequest.FlatAppearance.BorderSize = 0;
            this.btnCreateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRequest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateRequest.Location = new System.Drawing.Point(13, 20);
            this.btnCreateRequest.Name = "btnCreateRequest";
            this.btnCreateRequest.Size = new System.Drawing.Size(176, 23);
            this.btnCreateRequest.TabIndex = 3;
            this.btnCreateRequest.Text = "Talep Oluştur";
            this.btnCreateRequest.UseVisualStyleBackColor = false;
            this.btnCreateRequest.Click += new System.EventHandler(this.btnCreateRequest_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.BackColor = System.Drawing.Color.Gray;
            this.btnWeb.FlatAppearance.BorderSize = 0;
            this.btnWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeb.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWeb.Location = new System.Drawing.Point(13, 170);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(176, 23);
            this.btnWeb.TabIndex = 2;
            this.btnWeb.Text = "Web\'de Görüntüle";
            this.btnWeb.UseVisualStyleBackColor = false;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // btnRequestRefresh
            // 
            this.btnRequestRefresh.BackColor = System.Drawing.Color.Gray;
            this.btnRequestRefresh.FlatAppearance.BorderSize = 0;
            this.btnRequestRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequestRefresh.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRequestRefresh.Location = new System.Drawing.Point(13, 54);
            this.btnRequestRefresh.Name = "btnRequestRefresh";
            this.btnRequestRefresh.Size = new System.Drawing.Size(176, 23);
            this.btnRequestRefresh.TabIndex = 1;
            this.btnRequestRefresh.Text = "Aktif Talepler";
            this.btnRequestRefresh.UseVisualStyleBackColor = false;
            this.btnRequestRefresh.Click += new System.EventHandler(this.btnRequestRefresh_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCount.Location = new System.Drawing.Point(825, 211);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(142, 15);
            this.lblCount.TabIndex = 11;
            this.lblCount.Text = "Devam Eden Talep Sayısı:";
            // 
            // lblCountInfo
            // 
            this.lblCountInfo.AutoSize = true;
            this.lblCountInfo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCountInfo.Location = new System.Drawing.Point(1052, 211);
            this.lblCountInfo.Name = "lblCountInfo";
            this.lblCountInfo.Size = new System.Drawing.Size(19, 15);
            this.lblCountInfo.TabIndex = 12;
            this.lblCountInfo.Text = "00";
            // 
            // lblEndText
            // 
            this.lblEndText.AutoSize = true;
            this.lblEndText.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEndText.Location = new System.Drawing.Point(721, 54);
            this.lblEndText.Name = "lblEndText";
            this.lblEndText.Size = new System.Drawing.Size(63, 15);
            this.lblEndText.TabIndex = 15;
            this.lblEndText.Text = "Açıklama :";
            this.lblEndText.Visible = false;
            // 
            // rtbEndText
            // 
            this.rtbEndText.Location = new System.Drawing.Point(802, 37);
            this.rtbEndText.Name = "rtbEndText";
            this.rtbEndText.Size = new System.Drawing.Size(236, 81);
            this.rtbEndText.TabIndex = 6;
            this.rtbEndText.Text = "";
            this.rtbEndText.Visible = false;
            // 
            // btnEndRequest
            // 
            this.btnEndRequest.BackColor = System.Drawing.Color.Gray;
            this.btnEndRequest.FlatAppearance.BorderSize = 0;
            this.btnEndRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndRequest.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEndRequest.Location = new System.Drawing.Point(892, 124);
            this.btnEndRequest.Name = "btnEndRequest";
            this.btnEndRequest.Size = new System.Drawing.Size(75, 23);
            this.btnEndRequest.TabIndex = 7;
            this.btnEndRequest.Text = "Bitir";
            this.btnEndRequest.UseVisualStyleBackColor = false;
            this.btnEndRequest.Visible = false;
            this.btnEndRequest.Click += new System.EventHandler(this.btnEndRequest_Click);
            // 
            // rtbEndTextRead
            // 
            this.rtbEndTextRead.Location = new System.Drawing.Point(647, 27);
            this.rtbEndTextRead.Name = "rtbEndTextRead";
            this.rtbEndTextRead.ReadOnly = true;
            this.rtbEndTextRead.Size = new System.Drawing.Size(364, 174);
            this.rtbEndTextRead.TabIndex = 12;
            this.rtbEndTextRead.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sonlandırma Açıklaması :";
            // 
            // RequestForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.btnEndRequest);
            this.Controls.Add(this.rtbEndText);
            this.Controls.Add(this.lblEndText);
            this.Controls.Add(this.lblCountInfo);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.grpAction);
            this.Controls.Add(this.gbRequestRead);
            this.Controls.Add(this.grpRequest);
            this.Controls.Add(this.tlblTime);
            this.Controls.Add(this.grpInfo);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RequestForm";
            this.Text = "Control App";
           // this.Load += new System.EventHandler(this.Request_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpRequest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gbRequestRead.ResumeLayout(false);
            this.gbRequestRead.PerformLayout();
            this.grpAction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label employeeName;
        private System.Windows.Forms.Label lblTcInfo;
      
        private System.Windows.Forms.Label tlblTime;
        private System.Windows.Forms.Label lblSurnameInfo;
        private System.Windows.Forms.Label lblNameInfo;
        private System.Windows.Forms.Label employeeSurname;
        private System.Windows.Forms.Label lblDepartmentInfo;
        private System.Windows.Forms.Label department;
        private System.Windows.Forms.GroupBox grpRequest;
        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.GroupBox gbRequestRead;
        private System.Windows.Forms.Label requested;
        private System.Windows.Forms.Label lblrequestDetail;
        private System.Windows.Forms.Label requestName;
        private System.Windows.Forms.RichTextBox richTxtRequestContent;
        private System.Windows.Forms.TextBox txtRequested;
        private System.Windows.Forms.TextBox txtRequestTitle;
        private System.Windows.Forms.GroupBox grpAction;
        private System.Windows.Forms.Button btnRequestRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.Button btnMyRequest;
        private System.Windows.Forms.Button btnCreateRequest;
        private System.Windows.Forms.Button btnCompleteRequest;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblCountInfo;
        private System.Windows.Forms.Button btnDepartmentRequest;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem requestEndToolStripMenuItem;
        private System.Windows.Forms.Label lblEndText;
        private System.Windows.Forms.RichTextBox rtbEndText;
        private System.Windows.Forms.Button btnEndRequest;
        private System.Windows.Forms.RichTextBox rtbEndTextRead;
        private System.Windows.Forms.Label label2;
    }
}