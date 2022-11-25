using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Repository.Repositories
{
    public class UserRepoistory : GenericRepository<User>, IUserRepository
    {
        public UserRepoistory(ControlAppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
