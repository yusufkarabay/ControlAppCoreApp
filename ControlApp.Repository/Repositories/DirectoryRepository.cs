using ControlApp.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Repository.Repositories
{
    public class DirectoryRepository : GenericRepository<Core.Entities.Abstract.Directory>, IDirectoryRepository
    {
        public DirectoryRepository(ControlAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
