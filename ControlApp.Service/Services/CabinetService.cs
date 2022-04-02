using AutoMapper;
using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.Services;
using ControlApp.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Service.Services
{
    public class CabinetService : GenericService<Cabinet>, ICabinetService
    {
        private readonly ICabinetRepository _cabinetRepository;
        private readonly IMapper _mapper;

        public CabinetService(IGenericRepository<Cabinet> genericRepository, IUnitOfWork unitOfWork, ICabinetRepository cabinetRepository, IMapper mapper) : base(genericRepository, unitOfWork)
        {
            _cabinetRepository=cabinetRepository;
            _mapper=mapper;
        }
    }
}
