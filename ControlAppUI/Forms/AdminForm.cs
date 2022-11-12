namespace ControlAppDesktop.Forms
{
    public partial class AdminForm : Form
    {
        public object[] infos;
      
        public AdminForm()
        {
            InitializeComponent();            
        }

        private void btnDepartmentForm_Click(object sender, EventArgs e)
        {
            DepartmentForm departmentForm= new DepartmentForm();
            departmentForm.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

      
        private void btnEmployeeChecked_Click(object sender, EventArgs e)
        {
            EmployeeCheckedForm employeeCheckedForm= new EmployeeCheckedForm();
           
            employeeCheckedForm.Show();

        }

        
    }
}
