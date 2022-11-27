using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.Services;
using ControlApp.Core.UnitOfWorks;
using ControlApp.Repository.Repositories;
using ControlApp.Repository.UnitofWorks;
using ControlApp.Repository;
using ControlApp.Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper;
using ControlApp.Core.DTOs;

namespace ControlAppUICore.Forms
{
    public partial class SentryToDoForm : Form
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly ISentryToDoRepository sentryToDoRepository;
        private readonly ISentryToDoService sentryToDoService;
        private readonly IUserRepository userRepository;
        private readonly IUserService userService;
        public Guid userId;
        public SentryToDoForm()
        {
            var db = new ControlAppDbContext();

            sentryToDoRepository= new SentryToDoRepository(db);
            unitOfWork = new UnitOfWork(db);
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
            dgvSentryTodo.Columns["ToDo"].HeaderText="Yapılacak İşler";
            dgvSentryTodo.Columns["CreatedBy"].HeaderText="Oluşturan Personel";
            dgvSentryTodo.Columns["CreatedDate"].HeaderText ="Oluşturma Zamanı";
            dgvSentryTodo.Columns["UserId"].Visible=false;
            dgvSentryTodo.Columns["Id"].Visible=false;
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
                dgvSentryTodo.DataSource =returnSentryTodo;
                dgvSentryTodo.Visible = true;
                await DataGridSentryHeader();
            }


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
        private async void btnSentryListToDo_Click(object sender, EventArgs e)
        {
            await GetSentryTodoByDate();
        }
    }
}
