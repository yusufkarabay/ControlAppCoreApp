namespace ControlAppDesktop.Forms
{
    public partial class MaintenanceForm : Form
    {

        public MaintenanceForm()
        {
            InitializeComponent();

        }

        private void btnContractAdd_Click(object sender, EventArgs e)
        {
        }
        private void btnContractList_Click(object sender, EventArgs e)
        {

        }
        private void txtContractName_MouseClick(object sender, MouseEventArgs e)
        {
            txtContractName.Text = "";
        }
        private void txtContractCompany_MouseClick(object sender, MouseEventArgs e)
        {
            txtContractCompany.Text = "";
        }
        private void txtCompanyAdress_MouseClick(object sender, MouseEventArgs e)
        {
            txtCompanyAdress.Text = "";
        }
        private void txtCompanyTel_MouseClick(object sender, MouseEventArgs e)
        {
            txtCompanyTel.Text = "";
        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void btnContractUpdate_Click(object sender, EventArgs e)
        {


        }
        private void MaintenanceForm_Load(object sender, EventArgs e)
        {
        }

        private void btnMaintananceAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnMaintananceList_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaintenanceMailAddForm maintenanceMailAddForm = new MaintenanceMailAddForm();

            maintenanceMailAddForm.Show();
        }

        private void btnMaintananceUpdate_Click(object sender, EventArgs e)
        {
          
        }

        private void updateMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void deleteMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
