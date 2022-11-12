namespace ControlAppDesktop.Forms
{
    partial class GuestCardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestCardForm));
            this.btnGuestCardDelivery = new System.Windows.Forms.Button();
            this.gbSearchInfo = new System.Windows.Forms.GroupBox();
            this.rbReciverEmployee = new System.Windows.Forms.RadioButton();
            this.rbGuestCardNo = new System.Windows.Forms.RadioButton();
            this.rbDeliveryEmployee = new System.Windows.Forms.RadioButton();
            this.teslimAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvGuestCard = new System.Windows.Forms.DataGridView();
            this.gbCabinet = new System.Windows.Forms.GroupBox();
            this.lblGuestCardNo = new System.Windows.Forms.Label();
            this.lblDeliveryPerson = new System.Windows.Forms.Label();
            this.lblReceiverPerson = new System.Windows.Forms.Label();
            this.lblDeliveryPersonInfo = new System.Windows.Forms.Label();
            this.lblReceiverPersonInfo = new System.Windows.Forms.Label();
            this.lblGuestCardNoInfo = new System.Windows.Forms.Label();
            this.txtGuestCardearch = new System.Windows.Forms.TextBox();
            this.btnGuestCardSearch = new System.Windows.Forms.Button();
            this.btnGuestCardList = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.gbSearchInfo.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestCard)).BeginInit();
            this.gbCabinet.SuspendLayout();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuestCardDelivery
            // 
            this.btnGuestCardDelivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestCardDelivery.Location = new System.Drawing.Point(902, 29);
            this.btnGuestCardDelivery.Name = "btnGuestCardDelivery";
            this.btnGuestCardDelivery.Size = new System.Drawing.Size(184, 27);
            this.btnGuestCardDelivery.TabIndex = 1;
            this.btnGuestCardDelivery.Text = "Misafir Kart Teslim Et";
            this.btnGuestCardDelivery.UseVisualStyleBackColor = true;
            this.btnGuestCardDelivery.Click += new System.EventHandler(this.btnGuestCardDelivery_Click);
            // 
            // gbSearchInfo
            // 
            this.gbSearchInfo.Controls.Add(this.rbReciverEmployee);
            this.gbSearchInfo.Controls.Add(this.rbGuestCardNo);
            this.gbSearchInfo.Controls.Add(this.rbDeliveryEmployee);
            this.gbSearchInfo.Location = new System.Drawing.Point(465, 99);
            this.gbSearchInfo.Name = "gbSearchInfo";
            this.gbSearchInfo.Size = new System.Drawing.Size(333, 127);
            this.gbSearchInfo.TabIndex = 37;
            this.gbSearchInfo.TabStop = false;
            this.gbSearchInfo.Text = "Arama Seçeneği";
            // 
            // rbReciverEmployee
            // 
            this.rbReciverEmployee.AutoSize = true;
            this.rbReciverEmployee.Location = new System.Drawing.Point(16, 27);
            this.rbReciverEmployee.Name = "rbReciverEmployee";
            this.rbReciverEmployee.Size = new System.Drawing.Size(170, 20);
            this.rbReciverEmployee.TabIndex = 9;
            this.rbReciverEmployee.TabStop = true;
            this.rbReciverEmployee.Text = "AlanPersonel\'e Göre Ara";
            this.rbReciverEmployee.UseVisualStyleBackColor = true;
            this.rbReciverEmployee.CheckedChanged += new System.EventHandler(this.rbReciverEmployee_CheckedChanged);
            // 
            // rbGuestCardNo
            // 
            this.rbGuestCardNo.AutoSize = true;
            this.rbGuestCardNo.Location = new System.Drawing.Point(16, 52);
            this.rbGuestCardNo.Name = "rbGuestCardNo";
            this.rbGuestCardNo.Size = new System.Drawing.Size(182, 20);
            this.rbGuestCardNo.TabIndex = 7;
            this.rbGuestCardNo.TabStop = true;
            this.rbGuestCardNo.Text = "Misafir Kart No\'ya Göre Ara";
            this.rbGuestCardNo.UseVisualStyleBackColor = true;
            this.rbGuestCardNo.CheckedChanged += new System.EventHandler(this.rbGuestCardNo_CheckedChanged);
            // 
            // rbDeliveryEmployee
            // 
            this.rbDeliveryEmployee.AutoSize = true;
            this.rbDeliveryEmployee.Location = new System.Drawing.Point(16, 75);
            this.rbDeliveryEmployee.Name = "rbDeliveryEmployee";
            this.rbDeliveryEmployee.Size = new System.Drawing.Size(211, 20);
            this.rbDeliveryEmployee.TabIndex = 8;
            this.rbDeliveryEmployee.TabStop = true;
            this.rbDeliveryEmployee.Text = "Teslim Eden Personele Göre Ara";
            this.rbDeliveryEmployee.UseVisualStyleBackColor = true;
            this.rbDeliveryEmployee.CheckedChanged += new System.EventHandler(this.rbDeliveryEmployee_CheckedChanged);
            // 
            // teslimAlToolStripMenuItem
            // 
            this.teslimAlToolStripMenuItem.Name = "teslimAlToolStripMenuItem";
            this.teslimAlToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.teslimAlToolStripMenuItem.Text = "Teslim Al";
            this.teslimAlToolStripMenuItem.Click += new System.EventHandler(this.teslimAlToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teslimAlToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 26);
            // 
            // dgvGuestCard
            // 
            this.dgvGuestCard.AllowUserToAddRows = false;
            this.dgvGuestCard.AllowUserToDeleteRows = false;
            this.dgvGuestCard.AllowUserToResizeColumns = false;
            this.dgvGuestCard.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dgvGuestCard.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGuestCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGuestCard.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvGuestCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuestCard.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvGuestCard.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.dgvGuestCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGuestCard.Location = new System.Drawing.Point(3, 18);
            this.dgvGuestCard.MultiSelect = false;
            this.dgvGuestCard.Name = "dgvGuestCard";
            this.dgvGuestCard.ReadOnly = true;
            this.dgvGuestCard.RowHeadersVisible = false;
            this.dgvGuestCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGuestCard.Size = new System.Drawing.Size(761, 234);
            this.dgvGuestCard.TabIndex = 1;
            this.dgvGuestCard.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGuestCard_CellMouseClick);
            // 
            // gbCabinet
            // 
            this.gbCabinet.Controls.Add(this.dgvGuestCard);
            this.gbCabinet.Location = new System.Drawing.Point(115, 391);
            this.gbCabinet.Name = "gbCabinet";
            this.gbCabinet.Size = new System.Drawing.Size(767, 255);
            this.gbCabinet.TabIndex = 31;
            this.gbCabinet.TabStop = false;
            this.gbCabinet.Text = "Teslim Edilmiş Kartlar";
            // 
            // lblGuestCardNo
            // 
            this.lblGuestCardNo.AutoSize = true;
            this.lblGuestCardNo.Location = new System.Drawing.Point(37, 29);
            this.lblGuestCardNo.Name = "lblGuestCardNo";
            this.lblGuestCardNo.Size = new System.Drawing.Size(92, 16);
            this.lblGuestCardNo.TabIndex = 10;
            this.lblGuestCardNo.Text = "Misafir Kart No:";
            // 
            // lblDeliveryPerson
            // 
            this.lblDeliveryPerson.AutoSize = true;
            this.lblDeliveryPerson.Location = new System.Drawing.Point(37, 81);
            this.lblDeliveryPerson.Name = "lblDeliveryPerson";
            this.lblDeliveryPerson.Size = new System.Drawing.Size(78, 16);
            this.lblDeliveryPerson.TabIndex = 3;
            this.lblDeliveryPerson.Text = "Teslim Eden:";
            // 
            // lblReceiverPerson
            // 
            this.lblReceiverPerson.AutoSize = true;
            this.lblReceiverPerson.Location = new System.Drawing.Point(37, 55);
            this.lblReceiverPerson.Name = "lblReceiverPerson";
            this.lblReceiverPerson.Size = new System.Drawing.Size(76, 16);
            this.lblReceiverPerson.TabIndex = 2;
            this.lblReceiverPerson.Text = "Teslim Alan:";
            // 
            // lblDeliveryPersonInfo
            // 
            this.lblDeliveryPersonInfo.AutoSize = true;
            this.lblDeliveryPersonInfo.Location = new System.Drawing.Point(151, 81);
            this.lblDeliveryPersonInfo.Name = "lblDeliveryPersonInfo";
            this.lblDeliveryPersonInfo.Size = new System.Drawing.Size(21, 16);
            this.lblDeliveryPersonInfo.TabIndex = 5;
            this.lblDeliveryPersonInfo.Text = "00";
            // 
            // lblReceiverPersonInfo
            // 
            this.lblReceiverPersonInfo.AutoSize = true;
            this.lblReceiverPersonInfo.Location = new System.Drawing.Point(151, 55);
            this.lblReceiverPersonInfo.Name = "lblReceiverPersonInfo";
            this.lblReceiverPersonInfo.Size = new System.Drawing.Size(21, 16);
            this.lblReceiverPersonInfo.TabIndex = 4;
            this.lblReceiverPersonInfo.Text = "00";
            // 
            // lblGuestCardNoInfo
            // 
            this.lblGuestCardNoInfo.AutoSize = true;
            this.lblGuestCardNoInfo.Location = new System.Drawing.Point(151, 29);
            this.lblGuestCardNoInfo.Name = "lblGuestCardNoInfo";
            this.lblGuestCardNoInfo.Size = new System.Drawing.Size(21, 16);
            this.lblGuestCardNoInfo.TabIndex = 1;
            this.lblGuestCardNoInfo.Text = "00";
            // 
            // txtGuestCardearch
            // 
            this.txtGuestCardearch.Location = new System.Drawing.Point(474, 238);
            this.txtGuestCardearch.Name = "txtGuestCardearch";
            this.txtGuestCardearch.Size = new System.Drawing.Size(239, 22);
            this.txtGuestCardearch.TabIndex = 2;
            this.txtGuestCardearch.Text = "Misafir Kart Ara...";
            this.txtGuestCardearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtGuestCardearch_MouseClick);
            // 
            // btnGuestCardSearch
            // 
            this.btnGuestCardSearch.BackgroundImage = global::ControlAppUICore.Properties.Resources.loupe;
            this.btnGuestCardSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuestCardSearch.FlatAppearance.BorderSize = 0;
            this.btnGuestCardSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestCardSearch.Location = new System.Drawing.Point(569, 265);
            this.btnGuestCardSearch.Name = "btnGuestCardSearch";
            this.btnGuestCardSearch.Size = new System.Drawing.Size(32, 32);
            this.btnGuestCardSearch.TabIndex = 3;
            this.btnGuestCardSearch.UseVisualStyleBackColor = true;
            this.btnGuestCardSearch.Click += new System.EventHandler(this.btnGuestCardSearch_Click);
            // 
            // btnGuestCardList
            // 
            this.btnGuestCardList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGuestCardList.FlatAppearance.BorderSize = 0;
            this.btnGuestCardList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestCardList.Location = new System.Drawing.Point(774, 369);
            this.btnGuestCardList.Name = "btnGuestCardList";
            this.btnGuestCardList.Size = new System.Drawing.Size(108, 23);
            this.btnGuestCardList.TabIndex = 0;
            this.btnGuestCardList.Text = "Listele";
            this.btnGuestCardList.UseVisualStyleBackColor = false;
            this.btnGuestCardList.Click += new System.EventHandler(this.btnGuestCardList_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblGuestCardNo);
            this.grpInfo.Controls.Add(this.lblDeliveryPerson);
            this.grpInfo.Controls.Add(this.lblReceiverPerson);
            this.grpInfo.Controls.Add(this.lblDeliveryPersonInfo);
            this.grpInfo.Controls.Add(this.lblReceiverPersonInfo);
            this.grpInfo.Controls.Add(this.lblGuestCardNoInfo);
            this.grpInfo.Location = new System.Drawing.Point(109, 99);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(328, 159);
            this.grpInfo.TabIndex = 32;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Misafir Kart Bilgileri";
            this.grpInfo.Enter += new System.EventHandler(this.grpInfo_Enter);
            // 
            // GuestCardForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1184, 730);
            this.Controls.Add(this.btnGuestCardDelivery);
            this.Controls.Add(this.gbSearchInfo);
            this.Controls.Add(this.gbCabinet);
            this.Controls.Add(this.txtGuestCardearch);
            this.Controls.Add(this.btnGuestCardSearch);
            this.Controls.Add(this.btnGuestCardList);
            this.Controls.Add(this.grpInfo);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GuestCardForm";
            this.Text = "Control App";
            this.gbSearchInfo.ResumeLayout(false);
            this.gbSearchInfo.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuestCard)).EndInit();
            this.gbCabinet.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuestCardDelivery;
        private System.Windows.Forms.GroupBox gbSearchInfo;
        private System.Windows.Forms.RadioButton rbReciverEmployee;
        private System.Windows.Forms.RadioButton rbGuestCardNo;
        private System.Windows.Forms.RadioButton rbDeliveryEmployee;
        private System.Windows.Forms.ToolStripMenuItem teslimAlToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView dgvGuestCard;
        private System.Windows.Forms.GroupBox gbCabinet;
        private System.Windows.Forms.Label lblGuestCardNo;
        private System.Windows.Forms.Label lblDeliveryPerson;
        private System.Windows.Forms.Label lblReceiverPerson;
        private System.Windows.Forms.Label lblDeliveryPersonInfo;
        private System.Windows.Forms.Label lblReceiverPersonInfo;
        private System.Windows.Forms.Label lblGuestCardNoInfo;
        private System.Windows.Forms.TextBox txtGuestCardearch;
        private System.Windows.Forms.Button btnGuestCardSearch;
        private System.Windows.Forms.Button btnGuestCardList;
        private System.Windows.Forms.GroupBox grpInfo;
    }
}