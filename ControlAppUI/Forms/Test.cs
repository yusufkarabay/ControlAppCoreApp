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


namespace ControlAppUI
{
    public partial class Test : Form
    {
        private readonly IGenericService<Authority> _genericService;
        private readonly IAuthorityService _authorityService;
        private readonly IGenericRepository<Authority> _genericRepository;
        private readonly IAuthorityRepository authorityRepository;
        private readonly IUnitOfWork unitOfWork;
       


        public Test()
        {
            var db = new ControlAppDbContext();
            authorityRepository= new AuthorityRepository(db, unitOfWork);
            unitOfWork = new UnitOfWork(db);
            _authorityService = new AuthorityService(authorityRepository, unitOfWork);
            _genericService= new GenericService<Authority>(authorityRepository, unitOfWork);

            InitializeComponent();

        }
        private void Login_Load(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            var auth = new Authority();
            auth.Name=textBox1.Text;
            if (textBox1.Text=="")
            {
                auth.Name=null;
            }

            var addedAuth = await _genericService.AddAsync(auth);
            if (addedAuth.Item2 == null)
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Authority, AuthorityDto>()).CreateMapper();
                var returnAuth = mapper.Map<AuthorityDto>(addedAuth.Item1);
                dataGridView1.DataSource = returnAuth.Name;

            }
            else
            {
                MessageBox.Show("Kayýt Baþarýsýz");
            }


        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var getDepartment = await _genericService.GetAllAsync();
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Authority, AuthorityDto>()).CreateMapper();
            var returnAuth = mapper.Map<List<AuthorityDto>>(getDepartment);
            dataGridView1.DataSource= returnAuth;

        }
    }
}
