using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Repository.Repositories
{
    public class InventoryRepository : GenericRepository<Inventory>, IInventoryRepository
    {
        private readonly IUnitOfWork _unitOfWork;
        public InventoryRepository(ControlAppDbContext dbContext, IUnitOfWork _unitOfWork) : base(dbContext, _unitOfWork)
        {
        }

      
    }
}
