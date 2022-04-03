using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Repository.Repositories
{
    public class FuelRpository : GenericRepository<Fuel>, IFuelRepository
    {
        public FuelRpository(ControlAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
