namespace ControlAppDesktop.Forms
{
    public partial class CabinetForm : Form
    {
       
        public CabinetForm()
        {
           
        }

        private void btnCabinetDelivery_Click(object sender, EventArgs e)
        {
            CabinetDeliveryForm cabinetDeliveryForm = new CabinetDeliveryForm();         
            cabinetDeliveryForm.Show();
        }
       
       
        private void btnDrawerSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCabinetList_Click(object sender, EventArgs e)
        {
          
        }

        private void dgvCabinet_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void teslimAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void rbReciverEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawerSearch.Text = "Personel Adı Giriniz...";
        }

        private void rbCabinetNo_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawerSearch.Text = "Dolap No Giriniz...";
        }

        private void rbDeliveryEmployee_CheckedChanged(object sender, EventArgs e)
        {
            txtDrawerSearch.Text = "Personel Adı Giriniz...";
        }

        private void txtDrawerSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtDrawerSearch.Text = "";
        }
    }
}
