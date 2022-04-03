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
    public class DrawerRepository : GenericRepository<Drawer>, IDrawerRepository
    {
        public DrawerRepository(ControlAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
