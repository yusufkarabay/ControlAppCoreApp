namespace ControlAppDesktop.Forms
{
    partial class CabinetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CabinetForm));
            this.btnCabinetList = new System.Windows.Forms.Button();
            this.rbReciverEmployee = new System.Windows.Forms.RadioButton();
            this.rbCabinetNo = new System.Windows.Forms.RadioButton();
            this.rbDeliveryEmployee = new System.Windows.Forms.RadioButton();
            this.txtDrawerSearch = new System.Windows.Forms.TextBox();
            this.btnCabinetSearch = new System.Windows.Forms.Button();
            this.lblCabinetNo = new System.Windows.Forms.Label();
            this.lblDeliveryPerson = new System.Windows.Forms.Label();
            this.lblReceiverPerson = new System.Windows.Forms.Label();
            this.lblDeliveryPersonInfo = new System.Windows.Forms.Label();
            this.lblReceiverPersonInfo = new System.Windows.Forms.Label();
            this.lblCabinetNoInfo = new System.Windows.Forms.Label();
            this.gbCabinet = new System.Windows.Forms.GroupBox();
            this.dgvCabinet = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.teslimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCabinetDelivery = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.gbSearchInfo = new System.Windows.Forms.GroupBox();
            this.gbCabinet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabinet)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.gbSearchInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCabinetList
            // 
            this.btnCabinetList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCabinetList.FlatAppearance.BorderSize = 0;
            this.btnCabinetList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCabinetList.Location = new System.Drawing.Point(774, 371);
            this.btnCabinetList.Name = "btnCabinetList";
            this.btnCabinetList.Size = new System.Drawing.Size(108, 23);
            this.btnCabinetList.TabIndex = 0;
            this.btnCabinetList.Text = "Listele";
            this.btnCabinetList.UseVisualStyleBackColor = false;
            this.btnCabinetList.Click += new System.EventHandler(this.btnCabinetList_Click);
            // 
            // rbReciverEmployee
            // 
            this.rbReciverEmployee.AutoSize = true;
            this.rbReciverEmployee.Location = new System.Drawing.Point(29, 27);
            this.rbReciverEmployee.Name = "rbReciverEmployee";
            this.rbReciverEmployee.Size = new System.Drawing.Size(170, 20);
            this.rbReciverEmployee.TabIndex = 9;
            this.rbReciverEmployee.TabStop = true;
            this.rbReciverEmployee.Text = "AlanPersonel\'e Göre Ara";
            this.rbReciverEmployee.UseVisualStyleBackColor = true;
            this.rbReciverEmployee.CheckedChanged += new System.EventHandler(this.rbReciverEmployee_CheckedChanged);
            // 
            // rbCabinetNo
            // 
            this.rbCabinetNo.AutoSize = true;
            this.rbCabinetNo.Location = new System.Drawing.Point(29, 52);
            this.rbCabinetNo.Name = "rbCabinetNo";
            this.rbCabinetNo.Size = new System.Drawing.Size(158, 20);
            this.rbCabinetNo.TabIndex = 7;
            this.rbCabinetNo.TabStop = true;
            this.rbCabinetNo.Text = "Dolap  No\'ya Göre Ara";
            this.rbCabinetNo.UseVisualStyleBackColor = true;
            this.rbCabinetNo.CheckedChanged += new System.EventHandler(this.rbCabinetNo_CheckedChanged);
            // 
            // rbDeliveryEmployee
            // 
            this.rbDeliveryEmployee.AutoSize = true;
            this.rbDeliveryEmployee.Location = new System.Drawing.Point(29, 75);
            this.rbDeliveryEmployee.Name = "rbDeliveryEmployee";
            this.rbDeliveryEmployee.Size = new System.Drawing.Size(211, 20);
            this.rbDeliveryEmployee.TabIndex = 8;
            this.rbDeliveryEmployee.TabStop = true;
            this.rbDeliveryEmployee.Text = "Teslim Eden Personele Göre Ara";
            this.rbDeliveryEmployee.UseVisualStyleBackColor = true;
            this.rbDeliveryEmployee.CheckedChanged += new System.EventHandler(this.rbDeliveryEmployee_CheckedChanged);
            // 
            // txtDrawerSearch
            // 
            this.txtDrawerSearch.Location = new System.Drawing.Point(474, 238);
            this.txtDrawerSearch.Name = "txtDrawerSearch";
            this.txtDrawerSearch.Size = new System.Drawing.Size(239, 22);
            this.txtDrawerSearch.TabIndex = 3;
            this.txtDrawerSearch.Text = "Dolap Ara...";
            this.txtDrawerSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDrawerSearch_MouseClick);
            // 
            // btnCabinetSearch
            // 
            this.btnCabinetSearch.BackgroundImage = global::ControlAppUICore.Properties.Resources.loupe;
            this.btnCabinetSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCabinetSearch.FlatAppearance.BorderSize = 0;
            this.btnCabinetSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCabinetSearch.Location = new System.Drawing.Point(569, 265);
            this.btnCabinetSearch.Name = "btnCabinetSearch";
            this.btnCabinetSearch.Size = new System.Drawing.Size(32, 32);
            this.btnCabinetSearch.TabIndex = 4;
            this.btnCabinetSearch.UseVisualStyleBackColor = true;
            this.btnCabinetSearch.Click += new System.EventHandler(this.btnDrawerSearch_Click);
            // 
            // lblCabinetNo
            // 
            this.lblCabinetNo.AutoSize = true;
            this.lblCabinetNo.Location = new System.Drawing.Point(27, 27);
            this.lblCabinetNo.Name = "lblCabinetNo";
            this.lblCabinetNo.Size = new System.Drawing.Size(65, 16);
            this.lblCabinetNo.TabIndex = 10;
            this.lblCabinetNo.Text = "Dolap No:";
            // 
            // lblDeliveryPerson
            // 
            this.lblDeliveryPerson.AutoSize = true;
            this.lblDeliveryPerson.Location = new System.Drawing.Point(27, 79);
            this.lblDeliveryPerson.Name = "lblDeliveryPerson";
            this.lblDeliveryPerson.Size = new System.Drawing.Size(78, 16);
            this.lblDeliveryPerson.TabIndex = 3;
            this.lblDeliveryPerson.Text = "Teslim Eden:";
            // 
            // lblReceiverPerson
            // 
            this.lblReceiverPerson.AutoSize = true;
            this.lblReceiverPerson.Location = new System.Drawing.Point(27, 53);
            this.lblReceiverPerson.Name = "lblReceiverPerson";
            this.lblReceiverPerson.Size = new System.Drawing.Size(76, 16);
            this.lblReceiverPerson.TabIndex = 2;
            this.lblReceiverPerson.Text = "Teslim Alan:";
            // 
            // lblDeliveryPersonInfo
            // 
            this.lblDeliveryPersonInfo.AutoSize = true;
            this.lblDeliveryPersonInfo.Location = new System.Drawing.Point(121, 79);
            this.lblDeliveryPersonInfo.Name = "lblDeliveryPersonInfo";
            this.lblDeliveryPersonInfo.Size = new System.Drawing.Size(21, 16);
            this.lblDeliveryPersonInfo.TabIndex = 5;
            this.lblDeliveryPersonInfo.Text = "00";
            // 
            // lblReceiverPersonInfo
            // 
            this.lblReceiverPersonInfo.AutoSize = true;
            this.lblReceiverPersonInfo.Location = new System.Drawing.Point(121, 53);
            this.lblReceiverPersonInfo.Name = "lblReceiverPersonInfo";
            this.lblReceiverPersonInfo.Size = new System.Drawing.Size(21, 16);
            this.lblReceiverPersonInfo.TabIndex = 4;
            this.lblReceiverPersonInfo.Text = "00";
            // 
            // lblCabinetNoInfo
            // 
            this.lblCabinetNoInfo.AutoSize = true;
            this.lblCabinetNoInfo.Location = new System.Drawing.Point(121, 27);
            this.lblCabinetNoInfo.Name = "lblCabinetNoInfo";
            this.lblCabinetNoInfo.Size = new System.Drawing.Size(21, 16);
            this.lblCabinetNoInfo.TabIndex = 1;
            this.lblCabinetNoInfo.Text = "00";
            // 
            // gbCabinet
            // 
            this.gbCabinet.Controls.Add(this.dgvCabinet);
            this.gbCabinet.Location = new System.Drawing.Point(115, 391);
            this.gbCabinet.Name = "gbCabinet";
            this.gbCabinet.Size = new System.Drawing.Size(767, 255);
            this.gbCabinet.TabIndex = 24;
            this.gbCabinet.TabStop = false;
            this.gbCabinet.Text = "Teslim Edilmiş Dolaplar";
            // 
            // dgvCabinet
            // 
            this.dgvCabinet.AllowUserToAddRows = false;
            this.dgvCabinet.AllowUserToDeleteRows = false;
            this.dgvCabinet.AllowUserToResizeColumns = false;
            this.dgvCabinet.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvCabinet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCabinet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCabinet.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvCabinet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCabinet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCabinet.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCabinet.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvCabinet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCabinet.Location = new System.Drawing.Point(3, 18);
            this.dgvCabinet.MultiSelect = false;
            this.dgvCabinet.Name = "dgvCabinet";
            this.dgvCabinet.ReadOnly = true;
            this.dgvCabinet.RowHeadersVisible = false;
            this.dgvCabinet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCabinet.Size = new System.Drawing.Size(761, 234);
            this.dgvCabinet.TabIndex = 1;
            this.dgvCabinet.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCabinet_CellMouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teslimAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // teslimAlToolStripMenuItem
            // 
            this.teslimAlToolStripMenuItem.Name = "teslimAlToolStripMenuItem";
            this.teslimAlToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.teslimAlToolStripMenuItem.Text = "Teslim Al";
            this.teslimAlToolStripMenuItem.Click += new System.EventHandler(this.teslimAlToolStripMenuItem_Click);
            // 
            // btnCabinetDelivery
            // 
            this.btnCabinetDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCabinetDelivery.Location = new System.Drawing.Point(902, 29);
            this.btnCabinetDelivery.Name = "btnCabinetDelivery";
            this.btnCabinetDelivery.Size = new System.Drawing.Size(144, 30);
            this.btnCabinetDelivery.TabIndex = 2;
            this.btnCabinetDelivery.Text = "Dolap Teslim Et";
            this.btnCabinetDelivery.UseVisualStyleBackColor = true;
            this.btnCabinetDelivery.Click += new System.EventHandler(this.btnCabinetDelivery_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblCabinetNo);
            this.grpInfo.Controls.Add(this.lblDeliveryPerson);
            this.grpInfo.Controls.Add(this.lblReceiverPerson);
            this.grpInfo.Controls.Add(this.lblDeliveryPersonInfo);
            this.grpInfo.Controls.Add(this.lblReceiverPersonInfo);
            this.grpInfo.Controls.Add(this.lblCabinetNoInfo);
            this.grpInfo.Location = new System.Drawing.Point(109, 99);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(328, 159);
            this.grpInfo.TabIndex = 25;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Dolap Bilgileri";
            // 
            // gbSearchInfo
            // 
            this.gbSearchInfo.Controls.Add(this.rbReciverEmployee);
            this.gbSearchInfo.Controls.Add(this.rbCabinetNo);
            this.gbSearchInfo.Controls.Add(this.rbDeliveryEmployee);
            this.gbSearchInfo.Location = new System.Drawing.Point(465, 99);
            this.gbSearchInfo.Name = "gbSearchInfo";
            this.gbSearchInfo.Size = new System.Drawing.Size(333, 127);
            this.gbSearchInfo.TabIndex = 30;
            this.gbSearchInfo.TabStop = false;
            this.gbSearchInfo.Text = "Arama Seçeneği";
            // 
            // CabinetForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.ControlBox = false;
            this.Controls.Add(this.btnCabinetList);
            this.Controls.Add(this.txtDrawerSearch);
            this.Controls.Add(this.btnCabinetSearch);
            this.Controls.Add(this.gbCabinet);
            this.Controls.Add(this.btnCabinetDelivery);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.gbSearchInfo);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CabinetForm";
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.CabinetForm_Load);
            this.gbCabinet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCabinet)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.gbSearchInfo.ResumeLayout(false);
            this.gbSearchInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCabinetList;
        private System.Windows.Forms.RadioButton rbReciverEmployee;
        private System.Windows.Forms.RadioButton rbCabinetNo;
        private System.Windows.Forms.RadioButton rbDeliveryEmployee;
        private System.Windows.Forms.TextBox txtDrawerSearch;
        private System.Windows.Forms.Button btnCabinetSearch;
        private System.Windows.Forms.Label lblCabinetNo;
        private System.Windows.Forms.Label lblDeliveryPerson;
        private System.Windows.Forms.Label lblReceiverPerson;
        private System.Windows.Forms.Label lblDeliveryPersonInfo;
        private System.Windows.Forms.Label lblReceiverPersonInfo;
        private System.Windows.Forms.Label lblCabinetNoInfo;
        private System.Windows.Forms.GroupBox gbCabinet;
        private System.Windows.Forms.DataGridView dgvCabinet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teslimAlToolStripMenuItem;
        private System.Windows.Forms.Button btnCabinetDelivery;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.GroupBox gbSearchInfo;
    }
}