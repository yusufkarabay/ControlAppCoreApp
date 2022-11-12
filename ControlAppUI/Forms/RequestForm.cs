using System.Text;

namespace ControlAppDesktop.Forms
{
    public partial class RequestForm : Form
    {
       
        public RequestForm()
        {
            InitializeComponent();
           

        }
       
        private void dgvRequest_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }
        private void btnRequestRefresh_Click(object sender, EventArgs e)
        {
           
        }
        private void btnWeb_Click(object sender, EventArgs e)
        {
          



        }
       
        private void btnMyRequest_Click(object sender, EventArgs e)
        {
            

        }
        private void txtRequestTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void txtRequested_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void richTxtRequestContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void richTxtRequestContent_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
        private void txtRequested_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
        private void txtRequestTitle_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
        }
        private void btnCreateRequest_Click(object sender, EventArgs e)
        {
            RequestCreateForm requestCreateForm = new RequestCreateForm();
           
            requestCreateForm.Show();
        }
        private void btnDepartmentRequest_Click(object sender, EventArgs e)
        {
            DepartmentRequestForm departmentRequestForm = new DepartmentRequestForm();
           
            departmentRequestForm.Show();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
          
        }
        private void requestEndToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
       

        private void btnEndRequest_Click(object sender, EventArgs e)
        {
           

        }

        private void btnCompleteRequest_Click(object sender, EventArgs e)
        {
           
           

        }

        private void dgvRequest_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

           
        }
    }
}
