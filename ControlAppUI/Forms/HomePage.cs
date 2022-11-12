using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ControlAppDesktop.Forms
{
    public partial class HomePage : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
      (
          int nLeftRect,
          int nTopRect,
          int nRightRect,
          int nBottomRect,
          int nWidthEllipse,
          int nHeightEllipse
      );
        public object[] infos;
        public HomePage()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);
        void panelActiveVisible()
        {
            pnlActive.Visible = true;
        }
        public void homePage_Load(object sender, EventArgs e)
        {
            pnlActive.Visible = false;
            lblTime.Text = DateTime.Now.ToString("f");
            btnUserName.Text = "yusuf".ToString();

            btnAdminForm.Visible=true;

        }
        public void FormGet(Form form)
        {
            form.MdiParent = this;
            pnlCenter.Controls.Add(form);
            form.Show();
        }
        void LeftWhitePanel(Button button)
        {
            pnlActive.Visible = true;
            pnlActive.Height = button.Height;
            pnlActive.Top = button.Top;
        }
        public void btnSentry_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnSentry);
            pnlCenter.Controls.Clear();
            SentryForm sentryForm = new SentryForm();
            FormGet(sentryForm);
        }

        public void btnInventory_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnInventory);
            pnlCenter.Controls.Clear();
            InventoryForm inventoryForm = new InventoryForm();
            FormGet(inventoryForm);

        }
        public void btnEmployee_Click(object sender, EventArgs e)
        {

            LeftWhitePanel(btnEmployee);
            pnlCenter.Controls.Clear();
            EmployeeForm employeeForm = new EmployeeForm();
            FormGet(employeeForm);

        }
        private void btnRequest_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnRequest);
            pnlCenter.Controls.Clear();
            RequestForm requestForm = new RequestForm();
            FormGet(requestForm);

        }
        private void btnMaintenance_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnMaintenance);
            pnlCenter.Controls.Clear();
            MaintenanceForm maintenanceForm = new MaintenanceForm();
            FormGet(maintenanceForm);

        }

        private void btnHeadset_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnHeadset);
            pnlCenter.Controls.Clear();
            HeadsetForm headsetForm = new HeadsetForm();
            FormGet(headsetForm);
        }

        private void btnIdCard_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnIdCard);
            pnlCenter.Controls.Clear();
            EntranceCardForm entranceCardForm = new EntranceCardForm();
            FormGet(entranceCardForm);

        }

        private void btnDrawer_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnDrawer);
            pnlCenter.Controls.Clear();

            DrawerForm drawerForm = new DrawerForm();

            FormGet(drawerForm);

        }

        private void btnCabinet_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnCabinet); pnlCenter.Controls.Clear();
            CabinetForm cabinetForm = new CabinetForm();

            FormGet(cabinetForm);
        }

        private void btnGuestCard_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnGuestCard);
            pnlCenter.Controls.Clear();
            GuestCardForm guestCardForm = new GuestCardForm();

            FormGet(guestCardForm);


        }

        private void btnGenarator_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnGenarator);
            pnlCenter.Controls.Clear();
            GeneratorForm generatorForm = new GeneratorForm();

            FormGet(generatorForm);

        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnDirectory);
            pnlCenter.Controls.Clear();
            DirectoryForm directoryForm = new DirectoryForm();
            FormGet(directoryForm);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTopMenu_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }



        private void btnAdminForm_Click(object sender, EventArgs e)
        {

            pnlCenter.Controls.Clear();
            AdminForm adminForm = new AdminForm();

            FormGet(adminForm);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPasswordNote_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnPasswordNote);
            pnlCenter.Controls.Clear();
            PasswordNotesForm passwordNotesForm = new PasswordNotesForm();

            FormGet(passwordNotesForm);
        }

        private void btnWorkSteps_Click(object sender, EventArgs e)
        {
            LeftWhitePanel(btnWorkSteps);
            pnlCenter.Controls.Clear();
            WorkStepsForm workStepsForm = new WorkStepsForm();

            FormGet(workStepsForm);
        }
    }
}
