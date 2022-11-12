namespace ControlAppDesktop.Forms
{
    public partial class GuestCardForm : Form
    {
      
        public GuestCardForm()
        {
            InitializeComponent();
       
        }

        private void btnGuestCardDelivery_Click(object sender, EventArgs e)
        {
            GuestCardDeliveryForm guestCardDeliveryForm=new GuestCardDeliveryForm();              
            guestCardDeliveryForm.Show();
        }
      
        private void btnGuestCardSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnGuestCardList_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvGuestCard_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void teslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void rbReciverEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtGuestCardearch.Text = "Personel Adı Giriniz...";
        }

        private void rbDeliveryEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtGuestCardearch.Text = "Personel Adı Giriniz...";
        }

        private void rbGuestCardNo_CheckedChanged(object sender, EventArgs e)
        {
            txtGuestCardearch.Text = "Misafir Kart No Giriniz...";
        }

        private void txtGuestCardearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtGuestCardearch.Text = "";
        }

        private void grpInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
