using System.Net.Mail;

namespace ControlAppDesktop.Forms
{
    public partial class MailCheckedCodeForm : Form
    {
      
        public static string checkCode;
        public MailCheckedCodeForm()
        {
            InitializeComponent();
           
        }
        string CreateCode()
        {
            Random random = new Random();
            string letters = "ABCDEFGHIJKLMNOPRSTUVYZWX";
            checkCode = "";
            for (int i = 0; i < 6; i++)
            {
                checkCode += letters[random.Next(letters.Length)];
            }
            return checkCode;
        }
       
        private void btnSend_Click(object sender, EventArgs e)

        {
           
           PasswordForgotForm passwordForgotForm = new PasswordForgotForm();
            passwordForgotForm.Show();
            this.Hide();
           

        }
        bool MailSend()
        {
            MailMessage ePosta = new MailMessage();
            ePosta.From = new MailAddress("duzce112tekniktakip@hotmail.com", "ControlApp");

            ePosta.To.Add(txtMail.Text);


            ePosta.Subject = "ControlApp-Onay Kodu ";

            ePosta.Body = "ControlApp Şifre Değişikliği İçin Onay Kodu  " + checkCode + "  || Lütfen Bu İletiyi Cevaplamayınız";

            SmtpClient smtp = new SmtpClient();

            smtp.Credentials = new System.Net.NetworkCredential("duzce112tekniktakip@hotmail.com", "duzce112");


            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            object userState = ePosta;

            bool kontrol = true;
            try
            {
                smtp.SendAsync(ePosta, (object)ePosta);
            }
            catch (SmtpException ex)
            {
                kontrol = false;
                System.Windows.Forms.MessageBox.Show(ex.Message, "Mail Gönderme Hatasi");
            }
            return kontrol;

        }
        private void MailCheckedCodeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            PasswordForgotForm passwordForgotForm = new PasswordForgotForm();
            passwordForgotForm.Show();
            this.Close();
        }
    }
}
