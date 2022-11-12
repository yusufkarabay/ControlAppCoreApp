namespace ControlAppDesktop.Forms
{
    public partial class PasswordForgotForm : Form
    {
      
        public PasswordForgotForm()
        {
            InitializeComponent();
           
        }

        private void btnCheckCode_Click(object sender, EventArgs e)
        {
            MailCheckedCodeForm form = new MailCheckedCodeForm();
            form.Show();
           this.Close();
        }

       

    
        private void btnSave_Click(object sender, EventArgs e)
        {
          
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();
        }
    }
}
