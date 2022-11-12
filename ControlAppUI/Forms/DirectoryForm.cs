namespace ControlAppDesktop.Forms
{
    public partial class DirectoryForm : Form
    {
       
        public DirectoryForm()
        {
            InitializeComponent();
           
        }
       

        private void btnDirectoryAdd_Click(object sender, EventArgs e)
        {
           
        }

        private void DirectoryForm_Load(object sender, EventArgs e)
        {
           
        }

        private void rbtName_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "Ad Giriniz...";
        }

        private void rbtPhone_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "Telefon Giriniz...";
        }

        private void rbtInfo_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "Bilgi Giriniz...";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            


        }

        private void btnAllList_Click(object sender, EventArgs e)
        {
          
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

           
        }
    }
}
