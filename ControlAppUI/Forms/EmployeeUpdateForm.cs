namespace ControlAppDesktop.Forms
{
    public partial class EmployeeUpdateForm : Form
    {
       

        public EmployeeUpdateForm()
        {
            InitializeComponent();
          
           
        }

        public EmployeeUpdateForm(Guid employeeId)
        {
            this.InitializeComponent();
         
        }

        private void updateEmployeeFrom_Load(object sender, EventArgs e)
        {
          
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            this.Close();


        }
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
