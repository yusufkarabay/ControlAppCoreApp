namespace ControlAppUICore.Forms
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();         

        }
        
       
       

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
           
           
           this.Close();

        }
       
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
           
         
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbIsUser_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void chebUser_CheckedChanged(object sender, EventArgs e)
        {
            if (chebUser.Checked==true)
            {
                lblPassword.Visible = true;
                txtPassword.Visible = true;
                lblRePassword.Visible = true;
                txtRepassword.Visible = true;
                lblAuthority.Visible = true;
                cmbAuthority.Visible = true;
            }
            else
            {
                lblPassword.Visible=false;  
                txtPassword.Visible = false;
                lblRePassword.Visible = false;
                txtRepassword.Visible = false;
                lblAuthority.Visible = false;
                cmbAuthority.Visible = false;

                txtPassword.Text = "";
                txtRepassword.Text = "";
            }


        }
    }
}
