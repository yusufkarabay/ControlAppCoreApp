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
            sentryDoneRepository = new SentryDoneRepository(db);
            sentryToDoRepository= new SentryToDoRepository(db);
            unitOfWork = new UnitOfWork(db);
            sentryDoneService = new SentryDoneService(sentryDoneRepository, unitOfWork);
            userRepository = new UserRepoistory(db);
            userService = new UserService(userRepository, unitOfWork);
            sentryToDoService=new SentryToDoService(sentryToDoRepository, unitOfWork);
            InitializeComponent();
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
            dgvSentry.Columns["Done"].HeaderText="Yapılacak İşler";
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
                await DataGridSentryHeader();
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
            var selectedSentry = await sentryDoneService.GetByIdAsync(Guid.Parse(dgvSentry.SelectedRows[0].Cells["Id"].Value.ToString()));
            var userInfo = await userService.GetByIdAsync(userId);

            if (selectedSentry.UserId!=userInfo.Item1.Id)
            {
                MessageBox.Show("Seçilen işlemi silebilmek için giriş yapan kullanıcıya ait olmalıdır",
                "Nöbet Sırasında Yapılan İşler Hatası",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (selectedSentry.UserId==userInfo.Item1.Id)
            {

                await sentryDoneService.DeleteAsync(selectedSentry);
                await GetSentryDoneByDate();
                rtbxSentry.Text="Nöbet sırasında yapılan işler...";
            }

        }
        private async void btnSentryListToDo_Click(object sender, EventArgs e)
        {
            await GetSentryTodoByDate();

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
                sentrytodo.UserId=userId;
                sentrytodo.CreatedDate=dtpSentry.Value;
                await sentryToDoService.AddAsync(sentrytodo);

                rtbxSentry.Text="Takip edilecek işlemler...";
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

            rtbxSentry.Text=dgvSentry.SelectedRows[0].Cells[0].Value.ToString();
        }
        private void dgvSentryTodo_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        private void rightMenuDone_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}

