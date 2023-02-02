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
    public class GeneratorUsedTimeRepository : GenericRepository<GeneratorUsedTime>, IGeneratorUsedTimeRepository
    {
        private readonly IUnitOfWork unitOfWork;
        public GeneratorUsedTimeRepository(ControlAppDbContext dbContext, IUnitOfWork unitOfWork) : base(dbContext, unitOfWork)
        {
        }
    }
}
