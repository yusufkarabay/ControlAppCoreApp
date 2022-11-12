using System.Text;
namespace ControlAppDesktop.Forms
{

    public partial class InventoryForm : Form
    {
       

        public InventoryForm()
        {
            InitializeComponent();
          
        }
      


        private void btnList_Click(object sender, EventArgs e)
        {
           
        }
        private void btnAllList_Click(object sender, EventArgs e)
        {
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
          

        }
        private void deleteInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        private void refreshInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }
        private void updateInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            



        }
        private void txtbzxSearchInventory_MouseClick(object sender, MouseEventArgs e)
        {
            txtbxtSearchInventoryName.Clear();
           
        }


        public string Html_Out(DataGridView dg)
        {
            StringBuilder strB = new StringBuilder();
            strB.AppendLine("<html><head><meta charset=utf-8><style>table{padding:10px;} th,td{padding:8px;}</style></head><body><center><table border='1' cellpadding='0' cellspacing='0'>");
            strB.AppendLine("<tr>");
            for (int i = 0; i < dg.Columns.Count; i++) { if (dg.Columns[i].Visible == true) { strB.AppendLine("<th align='center' valign='middle'>" + dg.Columns[i].HeaderText + "</th>"); } }
            strB.AppendLine("</tr>");
            for (int i = 0; i < dg.Rows.Count; i++)
            {
                if (dg.Rows[i].Visible)
                {
                    strB.AppendLine("<tr>");
                    foreach (DataGridViewCell dgvc in dg.Rows[i].Cells)
                    {
                        if (dgvc.OwningColumn.Visible == true) { strB.AppendLine("<td align='center' valign='middle'>" + dgvc.Value.ToString() + "</td>"); }
                    }
                    strB.AppendLine("</tr>");
                }
            }
            strB.AppendLine("</table></center>");
            strB.AppendLine("</body></html>");
            return strB.ToString();
        }

        private void btnInventoryWeb_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Envanter Listesini HTML Ortamında Masaüstü'ne Kaydetmek İstiyor Musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
              
                string content = Html_Out(dgvInventory);
                string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.WriteAllText(desktopPath + "\\ Envanter Listesi.html", content);
                MessageBox.Show("Envanter Listesi HTML Formatında Masaüstüne Kaydedildi...");
            }
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void txtbxtSearchInventory_TextChanged(object sender, EventArgs e)
        {

            

        }

        private void txtInventorySearchSeriNo_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void txtInventorySearchSeriNo_MouseClick(object sender, MouseEventArgs e)
        {
            txtInventorySearchSeriNo.Clear();
           
        }

        private void txtbxAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }



    }
}
