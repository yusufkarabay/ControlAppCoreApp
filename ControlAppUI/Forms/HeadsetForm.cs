namespace ControlAppDesktop.Forms
{
    public partial class HeadsetForm : Form
    {
       
        public HeadsetForm()
        {
            InitializeComponent();
          
        }
       
        private void HeadsetForm_Load(object sender, EventArgs e)
        {


        }
        private void dgvHeadset_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

           
        }
        private void btnHeadsetList_Click(object sender, EventArgs e)
        {
          
        }
        private void returnDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
        private void btnHeadsetDelivery_Click(object sender, EventArgs e)
        {
            HeadsetDeliveryForm headsetDeliveryForm = new HeadsetDeliveryForm();
           
            headsetDeliveryForm.Show();
        }
        private void rbReciverEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtHeadsetSearch.Text = "Personel Adı Giriniz...";
        }
        private void rbHeadsetSeriNo_CheckedChanged(object sender, EventArgs e)
        {
            txtHeadsetSearch.Text = "Kulaklık Seri No Giriniz...";
        }
        private void rbDeliveryEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtHeadsetSearch.Text = "Personel Adı Giriniz...";
        }
        private void btnHeadsetSearch_Click(object sender, EventArgs e)
        {
        }
        private void txtHeadsetSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtHeadsetSearch.Text = "";
        }
    }
}

