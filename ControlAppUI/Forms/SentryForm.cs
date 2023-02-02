using AutoMapper;
using ControlApp.Core.DTOs;
using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.Services;
using ControlApp.Core.UnitOfWorks;
using ControlApp.Repository;
using ControlApp.Repository.Repositories;
using ControlApp.Repository.UnitofWorks;
using ControlApp.Service.Services;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace ControlAppDesktop.Forms
{
    public partial class SentryForm : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ISentryDoneRepository sentryDoneRepository;
        private readonly ISentryToDoRepository sentryToDoRepository;
        private readonly ISentryDoneService sentryDoneService;
        private readonly ISentryToDoService sentryToDoService;
        private readonly IUserRepository userRepository;
        private readonly IUserService userService;

        public Guid userId;
       
        public SentryForm()
        {
            var db = new ControlAppDbContext();
            sentryDoneRepository = new SentryDoneRepository(db,unitOfWork);
            sentryToDoRepository= new SentryToDoRepository(db, unitOfWork);
            unitOfWork = new UnitOfWork(db);
            userRepository = new UserRepoistory(db, unitOfWork);
            userService = new UserService(userRepository, unitOfWork);
            sentryDoneService = new SentryDoneService(sentryDoneRepository, unitOfWork);
            sentryToDoService=new SentryToDoService(sentryToDoRepository, unitOfWork);
            InitializeComponent();
        }
        public void FormGet(Form form)
        {
            form.MdiParent = this;

            form.Show();
        }
        async Task DataGridSettings(DataGridView dataGridView)
        {
            dataGridView.BorderStyle=BorderStyle.None;
            dataGridView.BackgroundColor=Color.LightGray;
            dataGridView.DefaultCellStyle.SelectionBackColor=Color.FromArgb(26, 110, 145);
            dataGridView.EnableHeadersVisualStyles=false;
        }
        async Task DataGridSentryHeader()
        {
            dgvSentry.Columns["Done"].HeaderText="Yapılan İşler";
            dgvSentry.Columns["CreatedBy"].HeaderText="Oluşturan Personel";
            dgvSentry.Columns["CreatedDate"].HeaderText ="Oluşturma Zamanı";
            dgvSentry.Columns["UserId"].Visible=false;
            dgvSentry.Columns["Id"].Visible=false;
        }
        async Task DataGridSentryToDoHeader()
        {
            dgvSentry.Columns["ToDo"].HeaderText="Yapılacak İşler";
            dgvSentry.Columns["CreatedBy"].HeaderText="Oluşturan Personel";
            dgvSentry.Columns["CreatedDate"].HeaderText ="Oluşturma Zamanı";
            dgvSentry.Columns["UserId"].Visible=false;
            dgvSentry.Columns["Id"].Visible=false;
        }
        async Task GetSentryDoneByDate()
        {
            var userInfo = await userService.GetByIdAsync(userId);
            var departmentId = Guid.Parse(userInfo.Item1.DepartmentId.ToString());
            if (userInfo.Item1!=null)
            {
                var sentryDones = sentryDoneService.GetSentryDoneByDate(dtpSentry.Value.Date, departmentId);
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<SentryDone, SentryDoneDto>()).CreateMapper();
                var returnSentry = mapper.Map<List<SentryDoneDto>>(sentryDones);
                if (returnSentry.Count==0)
                {
                    MessageBox.Show("Seçilen tarihte işlem eklenmedi",
                        "İşlem Yok",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                dgvSentry.DataSource =returnSentry;
                dgvSentry.Visible = true;
                await DataGridSentryHeader();
            }

        }
        async Task GetSentryTodoByDate()
        {
            var userInfo = await userService.GetByIdAsync(userId);
            var departmentId = Guid.Parse(userInfo.Item1.DepartmentId.ToString());
            if (userInfo.Item1!=null)
            {
                var sentryTodoes = sentryToDoService.GetSentryToDoByDate(dtpSentry.Value.Date, departmentId);
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<SentryToDo, SentryToDoDto>()).CreateMapper();
                var returnSentryTodo = mapper.Map<List<SentryToDoDto>>(sentryTodoes);
                if (returnSentryTodo.Count==0)
                {
                    MessageBox.Show("Seçilen tarihte işlem eklenmedi",
                        "İşlem Yok",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                dgvSentry.DataSource =returnSentryTodo;
                dgvSentry.Visible = true;
                await DataGridSentryToDoHeader();
            }


        }
        private async void btnSentryListDone_Click(object sender, EventArgs e)
        {
            await GetSentryDoneByDate();
        }
        private async void btnSentryDoneAdd_Click(object sender, EventArgs e)
        {
            if (rtbxSentry.Text==""|| rtbxSentry.Text==null||
                rtbxSentry.Text=="Nöbet sırasında yapılan işler...")
            {
                MessageBox.Show("Nöbet Sırasında Yapılan İşler Boş Bırakılamaz",
                    "Nöbet Sırasında Yapılan İşler Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var sentryDone = new SentryDone();
            var userInfo = await userService.GetByIdAsync(userId);

            if (userInfo.Item1!=null)
            {
                sentryDone.Done = rtbxSentry.Text;
                sentryDone.DepartmentId=Guid.Parse(userInfo.Item1.DepartmentId.ToString());
                sentryDone.CreatedBy=userInfo.Item1.Name+" "+userInfo.Item1.Surname;
                sentryDone.LastModifiedBy=userInfo.Item1.Name+" "+userInfo.Item1.Surname;
                sentryDone.UserId=userId;
                sentryDone.CreatedDate=dtpSentry.Value;
                await sentryDoneService.AddAsync(sentryDone);
                GetSentryDoneByDate();
                rtbxSentry.Text="Nöbet sırasında yapılan işler...";
            }
            else
            {
                MessageBox.Show("Giriş yapan personel bilgilerine ulaşılamadı.Lüfen sistem yöneticisine başvurunuz",
                     "Personel Bilgisi Hatası",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return;
            }
        }
        private async void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedSentry = await sentryDoneService.GetByIdAsync(Guid.Parse(dgvSentry.SelectedRows[0].Cells["Id"].Value.ToString()));
            var userInfo = await userService.GetByIdAsync(userId);

            if (selectedSentry.UserId!=userInfo.Item1.Id)
            {
                MessageBox.Show("Seçilen işlemi güncelleyebilmek için giriş yapan kullanıcıya ait olmalıdır",
                "Nöbet Sırasında Yapılan İşler Hatası",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            var sentrydone = Interaction.InputBox("Yapılan İşlem Güncellemesi", "İşlem Güncelleme", rtbxSentry.Text=dgvSentry.SelectedRows[0].Cells[0].Value.ToString());

            if (selectedSentry.UserId==userInfo.Item1.Id)
            {
                selectedSentry.Done=sentrydone;
                selectedSentry.CreatedDate=dtpSentry.Value;
                await sentryDoneService.UpdateAsync(selectedSentry);
                await GetSentryDoneByDate();
                rtbxSentry.Text="Nöbet sırasında yapılan işler...";
            }


        }
        private async void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await GetSentryDoneByDate();
        }
        private async void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedSentryDone = await sentryDoneService.GetByIdAsync(Guid.Parse(dgvSentry.SelectedRows[0].Cells["Id"].Value.ToString()));
            var selectedSentryToDo = await sentryToDoService.GetByIdAsync(Guid.Parse(dgvSentry.SelectedRows[0].Cells["Id"].Value.ToString()));
            var userInfo = await userService.GetByIdAsync(userId);
            if (dgvSentry.Columns[0].HeaderText=="Yapılan İşler")
            {
                if (selectedSentryDone.UserId!=userInfo.Item1.Id)
                {
                    MessageBox.Show("Seçilen işlemi silebilmek için giriş yapan kullanıcıya ait olmalıdır",
                    "Nöbet Sırasında Yapılan İşler Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                if (selectedSentryDone.UserId==userInfo.Item1.Id)
                {
                    var result = MessageBox.Show(dgvSentry.SelectedRows[0].Cells[0].Value.ToString()+ " ... işlemini silmek istediğinize eminmisiniz", "Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    switch (result)
                    {
                        case DialogResult.OK:

                            await sentryDoneService.DeleteAsync(selectedSentryDone);
                            break;
                    }
                    rtbxSentry.Text="Nöbet sırasında yapılan işler...";
                }
                GetSentryDoneByDate();
            }
            if (dgvSentry.Columns[0].HeaderText=="Yapılacak İşler")
            {
                if (selectedSentryToDo.UserId!=userInfo.Item1.Id)
                {
                    MessageBox.Show("Seçilen işlemi silebilmek için giriş yapan kullanıcıya ait olmalıdır",
                    "Nöbet Sırasında Yapılan İşler Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    return;
                }

                if (selectedSentryToDo.UserId==userInfo.Item1.Id)
                {
                    var result = MessageBox.Show(dgvSentry.SelectedRows[0].Cells[0].Value.ToString()+ " ... işlemini silmek istediğinize eminmisiniz", "Sil", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    switch (result)
                    {
                        case DialogResult.OK:

                            await sentryToDoService.DeleteAsync(selectedSentryToDo);
                            break;
                    }
                    rtbxSentryToDo.Text="Takip edilecek işlemler...";
                }
                GetSentryTodoByDate();
            }



        }
        private async void btnSentryListToDo_Click(object sender, EventArgs e)
        {
            await GetSentryTodoByDate();

        }
        private async void SentryForm_Load(object sender, EventArgs e)
        {
            await DataGridSettings(dgvSentry);

        }
        private async void btnSentryToDoAdd_Click(object sender, EventArgs e)
        {
            if (rtbxSentryToDo.Text==""|| rtbxSentryToDo.Text==null||
                rtbxSentryToDo.Text=="Takip edilecek işlemler...")
            {
                MessageBox.Show("Yapılacak İş Boş Bırakılamaz",
                    "Yapılacak İş Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            var sentrytodo = new SentryToDo();
            var userInfo = await userService.GetByIdAsync(userId);

            if (userInfo.Item1!=null)
            {
                sentrytodo.ToDo = rtbxSentryToDo.Text;
                sentrytodo.DepartmentId=Guid.Parse(userInfo.Item1.DepartmentId.ToString());
                sentrytodo.CreatedBy=userInfo.Item1.Name+" "+userInfo.Item1.Surname;
                sentrytodo.LastModifiedBy=userInfo.Item1.Name+" "+userInfo.Item1.Surname;
                sentrytodo.UserId=userId;
                sentrytodo.CreatedDate=dtpSentry.Value;
                await sentryToDoService.AddAsync(sentrytodo);
                GetSentryTodoByDate();
                rtbxSentryToDo.Text="Takip edilecek işlemler...";
            }
            else
            {
                MessageBox.Show("Giriş yapan personel bilgilerine ulaşılamadı.Lüfen sistem yöneticisine başvurunuz",
                     "Personel Bilgisi Hatası",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                return;
            }
        }
        private void rtbxSentry_MouseClick(object sender, MouseEventArgs e)
        {
            if (rtbxSentry.Text=="Nöbet sırasında yapılan işler...")
            {
                rtbxSentry.Text = "";
            }

        }
        private void rtbxSentryToDo_MouseClick(object sender, MouseEventArgs e)
        {
            if (rtbxSentryToDo.Text=="Takip edilecek işlemler...")
            {
                rtbxSentryToDo.Text = "";
            }
        }
        private void dgvSentry_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (dgvSentry.Columns[0].HeaderText=="Yapılacak İşler")
            //{
            //    rtbxSentryToDo.Text=dgvSentry.SelectedRows[0].Cells[0].Value.ToString();
            //    rtbxSentry.Text="Nöbet sırasında yapılan işler...";
            //}

            //if (dgvSentry.Columns[0].HeaderText=="Yapılan İşler")
            //{
            //    rtbxSentry.Text=dgvSentry.SelectedRows[0].Cells[0].Value.ToString();
            //    rtbxSentryToDo.Text="Takip edilecek işlemler...";
            //}
        }
    }
}

