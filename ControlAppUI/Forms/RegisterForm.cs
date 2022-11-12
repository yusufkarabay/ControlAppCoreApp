namespace ControlAppDesktop.Forms
{
    public partial class RegisterForm : Form
    {
       

        public RegisterForm()
        {
            InitializeComponent();
           
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
       
        private void btnRegister_Click(object sender, EventArgs e)
        {
         
            Login frmLogin = new Login();
            frmLogin.Show();
            this.Close();
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
