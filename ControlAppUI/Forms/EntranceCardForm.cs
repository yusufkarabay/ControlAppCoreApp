namespace ControlAppDesktop.Forms
{
    public partial class EntranceCardForm : Form
    {
       
        public EntranceCardForm()
        {
            InitializeComponent();
         
        }
       
        private void btnEntranceCardSearch_Click(object sender, EventArgs e)
        {
               

        }
        private void btnEntranceCardList_Click(object sender, EventArgs e)
        {
          
        }
        private void dgvEntranceCard_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
        private void btnEntranceCardDelivery_Click(object sender, EventArgs e)
        {
            EntranceCardDeliveryForm entranceCardDeliveryForm = new EntranceCardDeliveryForm();
           
            entranceCardDeliveryForm.Show();
        }
        private void teslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        private void txtEntranceCardSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtEntranceCardSearch.Text = "";
        }
        private void rbReciverEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtEntranceCardSearch.Text = "Personel Adı Giriniz..";
        }
        private void rbDeliveryEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtEntranceCardSearch.Text = "Personel Adı Giriniz..";
        }
        private void rbEntranceCardSeriNo_CheckedChanged(object sender, EventArgs e)
        {
            txtEntranceCardSearch.Text = "Giriş Kartı Seri No Giriniz..";
        }
    }
}
