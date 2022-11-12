namespace ControlAppDesktop.Forms
{
    public partial class DrawerForm : Form
    {
       
        public DrawerForm()
        {
            InitializeComponent();
         
        }
      
        private void btnDrawerSearch_Click(object sender, EventArgs e)
        {
           

          
        }
        private void btnDrawerList_Click(object sender, EventArgs e)
        {
            
        }
        private void dgvDrawer_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
        private void teslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rbReciverEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawerSearch.Text = "Personel Adı Giriniz...";

        }

        private void rbDrawerNo_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawerSearch.Text = "Çekmece No Giriniz...";
        }

        private void rbDeliveryEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawerSearch.Text = "Personel Adı Giriniz...";
        }

        private void txtDrawerSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtDrawerSearch.Text = "";
        }

        private void btnDrawerDelivery_Click(object sender, EventArgs e)
        {
            DrawerDeliveryForm drawerDeliveryForm = new DrawerDeliveryForm();
          
            drawerDeliveryForm.Show();
        }

        private void DrawerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
