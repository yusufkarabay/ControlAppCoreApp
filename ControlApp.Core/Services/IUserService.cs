using ControlApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Services
{
    public interface IUserService
    {
        Task<(User ,Exception?)> GetByIdAsync(Guid id);
        Task<IEnumerable<User>> GetAllAsync();
        IQueryable<User> Where(Expression<Func<User, bool>> expression);
        Task<(User, Exception?)> AddAsync(User entity);
        Task UpdateAsync(User entity);
        Task DeleteAsync(User entity);
    }
}
