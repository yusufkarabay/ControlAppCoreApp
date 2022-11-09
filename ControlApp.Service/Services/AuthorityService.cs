using AutoMapper;
using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.Services;
using ControlApp.Core.UnitOfWorks;
using ControlApp.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Service.Services
{
    public class AuthorityService : GenericService<Authority>, IAuthorityService
    {
        private readonly IAuthorityRepository _authorityRepository;
        private readonly IMapper _mapper;



        public AuthorityService(IGenericRepository<Authority> genericRepository, IUnitOfWork unitOfWork,IMapper mapper,IAuthorityRepository authorityRepository) : base(genericRepository, unitOfWork)
        {
            _mapper = mapper;
            _authorityRepository = authorityRepository;

        }

    }
}
