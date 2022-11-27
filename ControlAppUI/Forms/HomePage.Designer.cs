namespace ControlAppDesktop.Forms
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.pnlSentry = new System.Windows.Forms.Panel();
            this.btnSentrySub = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnUserName = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnPasswordNote = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.btnMaintenance = new System.Windows.Forms.Button();
            this.btnGenarator = new System.Windows.Forms.Button();
            this.btnHeadset = new System.Windows.Forms.Button();
            this.btnGuestCard = new System.Windows.Forms.Button();
            this.btnIdCard = new System.Windows.Forms.Button();
            this.btnCabinet = new System.Windows.Forms.Button();
            this.btnDrawer = new System.Windows.Forms.Button();
            this.btnSentry = new System.Windows.Forms.Button();
            this.pnlTopMenu = new System.Windows.Forms.Panel();
            this.btnAdminForm = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlCenter = new System.Windows.Forms.Panel();
            this.timerSentry = new System.Windows.Forms.Timer(this.components);
            this.pnlLeftMenu.SuspendLayout();
            this.pnlSentry.SuspendLayout();
            this.pnlTopMenu.SuspendLayout();
            this.pnlCenter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.pnlLeftMenu.Controls.Add(this.pnlSentry);
            this.pnlLeftMenu.Controls.Add(this.btnInventory);
            this.pnlLeftMenu.Controls.Add(this.btnEmployee);
            this.pnlLeftMenu.Controls.Add(this.btnPasswordNote);
            this.pnlLeftMenu.Controls.Add(this.btnRequest);
            this.pnlLeftMenu.Controls.Add(this.btnDirectory);
            this.pnlLeftMenu.Controls.Add(this.btnMaintenance);
            this.pnlLeftMenu.Controls.Add(this.btnGenarator);
            this.pnlLeftMenu.Controls.Add(this.btnHeadset);
            this.pnlLeftMenu.Controls.Add(this.btnGuestCard);
            this.pnlLeftMenu.Controls.Add(this.btnIdCard);
            this.pnlLeftMenu.Controls.Add(this.btnCabinet);
            this.pnlLeftMenu.Controls.Add(this.btnDrawer);
            this.pnlLeftMenu.Controls.Add(this.pnlActive);
            this.pnlLeftMenu.Controls.Add(this.btnUserName);
            this.pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(180, 768);
            this.pnlLeftMenu.TabIndex = 0;
            this.pnlLeftMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLeftMenu_Paint);
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlActive.Location = new System.Drawing.Point(0, 55);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(12, 34);
            this.pnlActive.TabIndex = 2;
            // 
            // pnlSentry
            // 
            this.pnlSentry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.pnlSentry.Controls.Add(this.btnSentrySub);
            this.pnlSentry.Controls.Add(this.button1);
            this.pnlSentry.Controls.Add(this.button2);
            this.pnlSentry.Location = new System.Drawing.Point(12, 55);
            this.pnlSentry.MaximumSize = new System.Drawing.Size(168, 120);
            this.pnlSentry.MinimumSize = new System.Drawing.Size(168, 36);
            this.pnlSentry.Name = "pnlSentry";
            this.pnlSentry.Size = new System.Drawing.Size(168, 36);
            this.pnlSentry.TabIndex = 3;
            // 
            // btnSentrySub
            // 
            this.btnSentrySub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.btnSentrySub.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSentrySub.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSentrySub.FlatAppearance.BorderSize = 0;
            this.btnSentrySub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentrySub.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSentrySub.ForeColor = System.Drawing.Color.LightGray;
            this.btnSentrySub.Image = global::ControlAppUICore.Properties.Resources.rotation;
            this.btnSentrySub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSentrySub.Location = new System.Drawing.Point(0, 0);
            this.btnSentrySub.Name = "btnSentrySub";
            this.btnSentrySub.Size = new System.Drawing.Size(168, 34);
            this.btnSentrySub.TabIndex = 3;
            this.btnSentrySub.Text = "Nöbet";
            this.btnSentrySub.UseVisualStyleBackColor = false;
            this.btnSentrySub.Click += new System.EventHandler(this.btnSentrySub_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Image = global::ControlAppUICore.Properties.Resources.rotation;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(4, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "       Yapılan İşlemler";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.LightGray;
            this.button2.Image = global::ControlAppUICore.Properties.Resources.rotation;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "       Yapılacak İşlemler";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnInventory
            // 
            this.btnInventory.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnInventory.ForeColor = System.Drawing.Color.LightGray;
            this.btnInventory.Image = global::ControlAppUICore.Properties.Resources.inventory;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(16, 106);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(164, 36);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "     Envanter";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnUserName
            // 
            this.btnUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUserName.Location = new System.Drawing.Point(0, 733);
            this.btnUserName.Name = "btnUserName";
            this.btnUserName.Size = new System.Drawing.Size(180, 23);
            this.btnUserName.TabIndex = 3;
            this.btnUserName.Text = "Personel Adı";
            this.btnUserName.UseVisualStyleBackColor = true;
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmployee.ForeColor = System.Drawing.Color.LightGray;
            this.btnEmployee.Image = global::ControlAppUICore.Properties.Resources.employee;
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(16, 146);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(164, 36);
            this.btnEmployee.TabIndex = 2;
            this.btnEmployee.Text = "     Personel";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnPasswordNote
            // 
            this.btnPasswordNote.FlatAppearance.BorderSize = 0;
            this.btnPasswordNote.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPasswordNote.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPasswordNote.ForeColor = System.Drawing.Color.LightGray;
            this.btnPasswordNote.Image = global::ControlAppUICore.Properties.Resources.lock__2___1_;
            this.btnPasswordNote.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPasswordNote.Location = new System.Drawing.Point(16, 546);
            this.btnPasswordNote.Name = "btnPasswordNote";
            this.btnPasswordNote.Size = new System.Drawing.Size(164, 36);
            this.btnPasswordNote.TabIndex = 12;
            this.btnPasswordNote.Text = "      Şifre Notları";
            this.btnPasswordNote.UseVisualStyleBackColor = true;
            this.btnPasswordNote.Click += new System.EventHandler(this.btnPasswordNote_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRequest.FlatAppearance.BorderSize = 0;
            this.btnRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRequest.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRequest.ForeColor = System.Drawing.Color.LightGray;
            this.btnRequest.Image = global::ControlAppUICore.Properties.Resources.clipboard;
            this.btnRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRequest.Location = new System.Drawing.Point(16, 186);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(164, 36);
            this.btnRequest.TabIndex = 3;
            this.btnRequest.Text = " Talep";
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnDirectory
            // 
            this.btnDirectory.FlatAppearance.BorderSize = 0;
            this.btnDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectory.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDirectory.ForeColor = System.Drawing.Color.LightGray;
            this.btnDirectory.Image = global::ControlAppUICore.Properties.Resources._001_phonebook;
            this.btnDirectory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDirectory.Location = new System.Drawing.Point(16, 506);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(164, 36);
            this.btnDirectory.TabIndex = 11;
            this.btnDirectory.Text = "            Telefon Rehberi";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // btnMaintenance
            // 
            this.btnMaintenance.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnMaintenance.FlatAppearance.BorderSize = 0;
            this.btnMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaintenance.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMaintenance.ForeColor = System.Drawing.Color.LightGray;
            this.btnMaintenance.Image = global::ControlAppUICore.Properties.Resources.schedule;
            this.btnMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaintenance.Location = new System.Drawing.Point(16, 226);
            this.btnMaintenance.Name = "btnMaintenance";
            this.btnMaintenance.Size = new System.Drawing.Size(164, 36);
            this.btnMaintenance.TabIndex = 4;
            this.btnMaintenance.Text = "   Bakım";
            this.btnMaintenance.UseVisualStyleBackColor = true;
            this.btnMaintenance.Click += new System.EventHandler(this.btnMaintenance_Click);
            // 
            // btnGenarator
            // 
            this.btnGenarator.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGenarator.FlatAppearance.BorderSize = 0;
            this.btnGenarator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenarator.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenarator.ForeColor = System.Drawing.Color.LightGray;
            this.btnGenarator.Image = global::ControlAppUICore.Properties.Resources.electric_generator;
            this.btnGenarator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenarator.Location = new System.Drawing.Point(16, 466);
            this.btnGenarator.Name = "btnGenarator";
            this.btnGenarator.Size = new System.Drawing.Size(164, 36);
            this.btnGenarator.TabIndex = 10;
            this.btnGenarator.Text = "    Jeneratör";
            this.btnGenarator.UseVisualStyleBackColor = true;
            this.btnGenarator.Click += new System.EventHandler(this.btnGenarator_Click);
            // 
            // btnHeadset
            // 
            this.btnHeadset.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnHeadset.FlatAppearance.BorderSize = 0;
            this.btnHeadset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeadset.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHeadset.ForeColor = System.Drawing.Color.LightGray;
            this.btnHeadset.Image = global::ControlAppUICore.Properties.Resources.headphone;
            this.btnHeadset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeadset.Location = new System.Drawing.Point(16, 266);
            this.btnHeadset.Name = "btnHeadset";
            this.btnHeadset.Size = new System.Drawing.Size(164, 36);
            this.btnHeadset.TabIndex = 5;
            this.btnHeadset.Text = "      Kulaklık";
            this.btnHeadset.UseVisualStyleBackColor = true;
            this.btnHeadset.Click += new System.EventHandler(this.btnHeadset_Click);
            // 
            // btnGuestCard
            // 
            this.btnGuestCard.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnGuestCard.FlatAppearance.BorderSize = 0;
            this.btnGuestCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuestCard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuestCard.ForeColor = System.Drawing.Color.LightGray;
            this.btnGuestCard.Image = global::ControlAppUICore.Properties.Resources.id;
            this.btnGuestCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuestCard.Location = new System.Drawing.Point(16, 426);
            this.btnGuestCard.Name = "btnGuestCard";
            this.btnGuestCard.Size = new System.Drawing.Size(164, 36);
            this.btnGuestCard.TabIndex = 9;
            this.btnGuestCard.Text = "         Misafir Kart";
            this.btnGuestCard.UseVisualStyleBackColor = true;
            this.btnGuestCard.Click += new System.EventHandler(this.btnGuestCard_Click);
            // 
            // btnIdCard
            // 
            this.btnIdCard.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnIdCard.FlatAppearance.BorderSize = 0;
            this.btnIdCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdCard.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIdCard.ForeColor = System.Drawing.Color.LightGray;
            this.btnIdCard.Image = global::ControlAppUICore.Properties.Resources.name;
            this.btnIdCard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIdCard.Location = new System.Drawing.Point(16, 306);
            this.btnIdCard.Name = "btnIdCard";
            this.btnIdCard.Size = new System.Drawing.Size(164, 36);
            this.btnIdCard.TabIndex = 6;
            this.btnIdCard.Text = "       Giriş Kartı";
            this.btnIdCard.UseVisualStyleBackColor = true;
            this.btnIdCard.Click += new System.EventHandler(this.btnIdCard_Click);
            // 
            // btnCabinet
            // 
            this.btnCabinet.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCabinet.FlatAppearance.BorderSize = 0;
            this.btnCabinet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCabinet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCabinet.ForeColor = System.Drawing.Color.LightGray;
            this.btnCabinet.Image = global::ControlAppUICore.Properties.Resources.locker;
            this.btnCabinet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCabinet.Location = new System.Drawing.Point(16, 386);
            this.btnCabinet.Name = "btnCabinet";
            this.btnCabinet.Size = new System.Drawing.Size(164, 36);
            this.btnCabinet.TabIndex = 8;
            this.btnCabinet.Text = " Dolap";
            this.btnCabinet.UseVisualStyleBackColor = true;
            this.btnCabinet.Click += new System.EventHandler(this.btnCabinet_Click);
            // 
            // btnDrawer
            // 
            this.btnDrawer.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnDrawer.FlatAppearance.BorderSize = 0;
            this.btnDrawer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrawer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDrawer.ForeColor = System.Drawing.Color.LightGray;
            this.btnDrawer.Image = global::ControlAppUICore.Properties.Resources.dresser;
            this.btnDrawer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDrawer.Location = new System.Drawing.Point(16, 346);
            this.btnDrawer.Name = "btnDrawer";
            this.btnDrawer.Size = new System.Drawing.Size(164, 36);
            this.btnDrawer.TabIndex = 7;
            this.btnDrawer.Text = "      Çekmece";
            this.btnDrawer.UseVisualStyleBackColor = true;
            this.btnDrawer.Click += new System.EventHandler(this.btnDrawer_Click);
            // 
            // btnSentry
            // 
            this.btnSentry.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSentry.FlatAppearance.BorderSize = 0;
            this.btnSentry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSentry.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSentry.ForeColor = System.Drawing.Color.LightGray;
            this.btnSentry.Image = global::ControlAppUICore.Properties.Resources.rotation;
            this.btnSentry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSentry.Location = new System.Drawing.Point(481, 336);
            this.btnSentry.Name = "btnSentry";
            this.btnSentry.Size = new System.Drawing.Size(164, 34);
            this.btnSentry.TabIndex = 0;
            this.btnSentry.Text = "Nöbet";
            this.btnSentry.UseVisualStyleBackColor = true;
            this.btnSentry.Click += new System.EventHandler(this.btnSentry_Click);
            // 
            // pnlTopMenu
            // 
            this.pnlTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.pnlTopMenu.Controls.Add(this.btnAdminForm);
            this.pnlTopMenu.Controls.Add(this.btnMinimize);
            this.pnlTopMenu.Controls.Add(this.lblTime);
            this.pnlTopMenu.Controls.Add(this.btnExit);
            this.pnlTopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopMenu.Location = new System.Drawing.Point(180, 0);
            this.pnlTopMenu.Name = "pnlTopMenu";
            this.pnlTopMenu.Size = new System.Drawing.Size(1186, 35);
            this.pnlTopMenu.TabIndex = 1;
            this.pnlTopMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopMenu_MouseDown);
            // 
            // btnAdminForm
            // 
            this.btnAdminForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.btnAdminForm.FlatAppearance.BorderSize = 0;
            this.btnAdminForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdminForm.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdminForm.Image = global::ControlAppUICore.Properties.Resources.admin;
            this.btnAdminForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminForm.Location = new System.Drawing.Point(892, 3);
            this.btnAdminForm.Name = "btnAdminForm";
            this.btnAdminForm.Size = new System.Drawing.Size(164, 33);
            this.btnAdminForm.TabIndex = 14;
            this.btnAdminForm.Text = " Yönetici Ekranı";
            this.btnAdminForm.UseVisualStyleBackColor = false;
            this.btnAdminForm.Visible = false;
            this.btnAdminForm.Click += new System.EventHandler(this.btnAdminForm_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::ControlAppUICore.Properties.Resources.minimize;
            this.btnMinimize.Location = new System.Drawing.Point(1123, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 15;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTime.Location = new System.Drawing.Point(15, 8);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 19);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Zaman";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(110)))), ((int)(((byte)(145)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::ControlAppUICore.Properties.Resources.cancel_red;
            this.btnExit.Location = new System.Drawing.Point(1153, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 16;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlCenter
            // 
            this.pnlCenter.BackColor = System.Drawing.Color.LightGray;
            this.pnlCenter.Controls.Add(this.btnSentry);
            this.pnlCenter.Location = new System.Drawing.Point(182, 38);
            this.pnlCenter.Name = "pnlCenter";
            this.pnlCenter.Size = new System.Drawing.Size(1184, 730);
            this.pnlCenter.TabIndex = 3;
            // 
            // timerSentry
            // 
            this.timerSentry.Interval = 15;
            this.timerSentry.Tick += new System.EventHandler(this.timerSentry_Tick);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlCenter);
            this.Controls.Add(this.pnlTopMenu);
            this.Controls.Add(this.pnlLeftMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control App";
            this.Load += new System.EventHandler(this.homePage_Load);
            this.pnlLeftMenu.ResumeLayout(false);
            this.pnlSentry.ResumeLayout(false);
            this.pnlTopMenu.ResumeLayout(false);
            this.pnlTopMenu.PerformLayout();
            this.pnlCenter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTopMenu;
        private System.Windows.Forms.Button btnSentry;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnGenarator;
        private System.Windows.Forms.Button btnGuestCard;
        private System.Windows.Forms.Button btnCabinet;
        private System.Windows.Forms.Button btnDrawer;
        private System.Windows.Forms.Button btnIdCard;
        private System.Windows.Forms.Button btnHeadset;
        private System.Windows.Forms.Button btnMaintenance;
        private System.Windows.Forms.Button btnUserName;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.Button btnAdminForm;
        public System.Windows.Forms.Panel pnlCenter;
        public System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPasswordNote;
        private Button button2;
        private Button button1;
        private Panel pnlSentry;
        private Button btnSentrySub;
        private System.Windows.Forms.Timer timerSentry;
    }
}