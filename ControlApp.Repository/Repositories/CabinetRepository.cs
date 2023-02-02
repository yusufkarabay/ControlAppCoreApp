using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Repository.Repositories
{
    public class CabinetRepository : GenericRepository<Cabinet>, ICabinetRepository
    {
        private readonly IUnitOfWork unitOfWork;
        public CabinetRepository(ControlAppDbContext dbContext, IUnitOfWork unitOfWork) : base(dbContext, unitOfWork)
        {
        }


    }
}
