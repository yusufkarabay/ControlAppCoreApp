using ControlApp.Core.Repositories;
using ControlApp.Core.Services;
using ControlApp.Core.UnitOfWorks;
using ControlApp.Repository.Repositories;
using ControlApp.Repository.UnitofWorks;
using ControlApp.Repository;
using ControlApp.Service.Services;
using ControlAppDesktop.Forms;
using System.Runtime.InteropServices;
using AutoMapper;
using ControlApp.Core.DTOs;
using ControlApp.Core.Entities.Abstract;

namespace ControlAppDesktop
{
    public partial class Login : Form
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

        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IUserService userService;
        public Login()
        {
            var db = new ControlAppDbContext();
            userRepository = new UserRepoistory(db);
            unitOfWork = new UnitOfWork(db);
            userService = new UserService(userRepository, unitOfWork);
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int Iparam);
        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("f");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (mtxtTC.Text==""&& mtxtTC.Text.Length!=11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır",
                    "T.C. Kimlik Numarası Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text=="")
            {
                MessageBox.Show("Parola boş girilemez",
                   "Parola Hatası",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                return;
            }

            var login = userRepository.Where(x => x.TC == mtxtTC.Text && x.Password == txtPassword.Text).FirstOrDefault();
            if (login==null)
            {
                MessageBox.Show("TC Kimlik Numarası veya Parola Hatalı",
                    "Kullanıcı Bulunamadı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (login.Enabled==false)
            {
                MessageBox.Show("Kullanıcı aktif edilmemiştir. Sistem yöneticisi ile  görüşünüz",
                    "Kullanıcı Aktif Değil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            var homePage = new HomePage();
            homePage.userId = login.Id;
            homePage.Show();
            this.Hide();

        }

        private void LnkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var forgotPass = new PasswordForgotForm();
            forgotPass.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlLoginTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mtxtTC_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtPassword_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text=="123456".ToString())
            {
                txtPassword.Text="";
            }


        }

        private void cbPassShow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassShow.Checked)
            {
                txtPassword.PasswordChar='\0';
            }
            else
            {
                txtPassword.PasswordChar='*';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void mtxtTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mtxtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
