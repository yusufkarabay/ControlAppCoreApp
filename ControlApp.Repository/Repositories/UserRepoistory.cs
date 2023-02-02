using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.UnitOfWorks;
using ControlApp.Repository.UnitofWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Repository.Repositories
{
    public class UserRepoistory : GenericRepository<User>, IUserRepository
    {
        private readonly IUnitOfWork unitOfWork;
        public UserRepoistory(ControlAppDbContext dbContext,IUnitOfWork unitOfWork) : base(dbContext,unitOfWork)
        {
        }
    }
}
