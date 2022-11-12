namespace ControlAppDesktop.Forms
{

    public partial class EmployeeForm : Form
    {
      

        public EmployeeForm()
        {
            InitializeComponent();
           
        }
        private void Employee_Load(object sender, EventArgs e)
        {
           
            cbDepartment.Visible = false;
          
        }
       
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void dgvEmployee_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void btnEmployeeAdd_Click(object sender, EventArgs e)
        {
           
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }
        private void rbTc_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void rbName_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void rbSurname_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void rbDepartment_CheckedChanged(object sender, EventArgs e)
        {
            

        }
        private void rbTel_CheckedChanged(object sender, EventArgs e)
        {
           
        }
        private void rbMail_CheckedChanged(object sender, EventArgs e)
        {
          
        }
        private void rbBdate_CheckedChanged(object sender, EventArgs e)
        {

            if (cbDepartment.Visible == true)
            {
                cbDepartment.Visible = false;
            }

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
         
        }
        private void btnSearchEmployee_Click(object sender, EventArgs e)
        {
        }

        private void txtbxSearchEmloyee_MouseClick(object sender, MouseEventArgs e)
        {
            txtbxSearchEmloyee.Text = "";
        }
       

        private void btnPassiveEmploye_Click(object sender, EventArgs e)
        {
           EmployeePassiveForm  employeePassiveForm = new EmployeePassiveForm();
           
            employeePassiveForm.Show();
        }

        private void btnActiveEmployee_Click(object sender, EventArgs e)
        {
            
            
        }
        void PassiveEmployee()
        {
        }
        private void passiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
