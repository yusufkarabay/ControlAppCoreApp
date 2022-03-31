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
    public class GuestCardRepository : GenericRepository<GuestCard>, IGuestCardRepository
    {
        public GuestCardRepository(ControlAppDbContext dbContext, DbSet<GuestCard> dbSet) : base(dbContext, dbSet)
        {
        }
    }
}
