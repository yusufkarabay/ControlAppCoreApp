using AutoMapper;
using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.Services;
using ControlApp.Core.UnitOfWorks;
using ControlApp.Repository;
using ControlApp.Repository.Repositories;
using ControlApp.Repository.UnitofWorks;
using ControlApp.Service.Services;
using Microsoft.Extensions.Logging;

namespace ControlAppUI
{
    public partial class Test : Form
    {
        private readonly IGenericService<Authority> _genericService;
        private readonly IAuthorityService _authorityService;
        private readonly IGenericRepository<Authority> _genericRepository;
        private readonly IAuthorityRepository authorityRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;


        public Test()
        {
            var db = new ControlAppDbContext();
            authorityRepository= new AuthorityRepository(db);
            unitOfWork = new UnitOfWork(db);
            _authorityService = new AuthorityService(authorityRepository, unitOfWork, mapper, authorityRepository);
            _genericService= new GenericService<Authority>(authorityRepository, unitOfWork);
            InitializeComponent();

        }
        private void Login_Load(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var auth = new Authority();
                auth.Name=textBox1.Text;
                if (textBox1.Text=="")
                {
                    auth.Name=null;
                }
                await _genericService.AddAsync(auth);
            }
            catch (Exception)
            {

                var a= new NullReferenceException("Name cannot be null").Message.ToString();
                MessageBox.Show(a);
            }
        }



    }
}
