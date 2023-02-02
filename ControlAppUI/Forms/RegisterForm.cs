using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.Services;
using ControlApp.Core.UnitOfWorks;
using ControlApp.Repository;
using ControlApp.Repository.Repositories;
using ControlApp.Repository.UnitofWorks;
using ControlApp.Service.Services;
using Microsoft.EntityFrameworkCore;

namespace ControlAppDesktop.Forms
{
    public partial class RegisterForm : Form
    {

        private readonly IUserRepository userRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IUserService userService;

        public RegisterForm()
        {
            var db = new ControlAppDbContext();
            userRepository = new UserRepoistory(db, unitOfWork);
            unitOfWork = new UnitOfWork(db);
            userService = new UserService(userRepository, unitOfWork);
            InitializeComponent();

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (mtxbTC.Text==""&& mtxbTC.Text.Length!=11)
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalıdır",
                    "T.C. Kimlik Numarası Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (txtName.Text==""|| txtSurname.Text==""|| txtMail.Text==""||
                txtPassword.Text==""|| txtRepassword.Text=="")
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurunuz",
                    "Zorunlu Alanlar Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (mtxtPhone.Text=="(   )    -"||mtxtPhone.Text.Length!=14)
            {
                MessageBox.Show("Lütfen telefon numarasını 10 haneli olarak giriniz",
                    "Telefon Numarası Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var phoneStartWith = "(5".ToString();
            var startWith = mtxtPhone.Text.StartsWith("(5");
            if (startWith==false)
            {
                MessageBox.Show("Lütfen telefon numarasını 5 ile başlayacak şekilde giriniz",
                    "Telefon Numarası Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            if (txtPassword.Text!=txtRepassword.Text)
            {
                MessageBox.Show("Parolalar Uyuşmamaktadır. Lütfen Kontrol Ediniz",
                    "Parola Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }


            var user = new User();
            user.TC= mtxbTC.Text;
            user.Name= txtName.Text;
            user.Surname= txtSurname.Text;
            user.PhoneNumber= mtxtPhone.Text;
            user.Email= txtMail.Text;
            user.Password= txtPassword.Text;
            user.RePassword= txtRepassword.Text;

            var existUser = await userService.Where(x => x.TC == user.TC).FirstOrDefaultAsync();
            if (existUser!=null)
            {
                MessageBox.Show("Bu TC Kimlik Numarası ile daha önce kayıt olunmuştur",
                    "Kayıt Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                var createUser = await userService.AddAsync(user);
                if (createUser.Item2==null)
                {
                    MessageBox.Show("Kayıt Başarlılı. Giriş Ekranına Yönlendiriliyorsunuz",
                        "Kayıt Başarılı",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Kayıt Başarısız. Lütfen Tekrar Deneyiniz",
                        "Kayıt Başarısız",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }

            Login frmLogin = new Login();
            frmLogin.Show();
            this.Hide();
        }

        private void mtxbTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mtxtBDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void mtxtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }

        private void mtxbTC_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
