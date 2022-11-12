namespace ControlAppDesktop.Forms
{
    public partial class SentryForm : Form
    {


        public SentryForm()
        {
            InitializeComponent();


        }

        void DataGridSettings(DataGridView dataGridView)
        {
            dataGridView.BorderStyle=BorderStyle.None;
            dataGridView.BackgroundColor=Color.LightGray;
            dataGridView.DefaultCellStyle.SelectionBackColor=Color.FromArgb(26, 110, 145);
            dataGridView.EnableHeadersVisualStyles=false;


        }
        private void btnSentryListDone_Click(object sender, EventArgs e)
        {
            if (dgvSentry.Visible == true)
            {
                dgvSentryTodo.Visible = false;
            }
            dgvSentry.Visible = true;

         

        }
        private void btnSentryDoneAdd_Click(object sender, EventArgs e)
        {

        }
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {




        }
        private void btnSentryDoneUpdate_Click(object sender, EventArgs e)
        {



        }
        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        private void btnSentryListToDo_Click(object sender, EventArgs e)
        {


        }


        private void gToolStripMenuItem_Click(object sender, EventArgs e)
        {



        }
        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void yenileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private void btnSentryToDoUpdate_Click(object sender, EventArgs e)
        {

        }
        private void SentryForm_Load(object sender, EventArgs e)
        {

        }
        private void btnSentryToDoAdd_Click(object sender, EventArgs e)
        {

        }


        private void rtbxSentry_MouseClick(object sender, MouseEventArgs e)
        {
            rtbxSentry.Text = "";
        }

        private void rtbxSentryToDo_MouseClick(object sender, MouseEventArgs e)
        {
            rtbxSentryToDo.Text = "";
            btnSentryToDoAdd.Enabled = true;
        }




        private void dgvSentry_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void dgvSentryTodo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}

