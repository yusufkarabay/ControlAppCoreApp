using ControlApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Services
{
    public interface IAuthorityService
    {
        Task<(Authority, Exception?)> AddAsync(Authority entity);
        Task<IEnumerable<Authority>> GetAllAsync();
        Task<Authority> GetByIdAsync(Guid id);
        IQueryable<Authority> Where(Expression<Func<Authority, bool>> expression);
        Task UpdateAsync(Authority entity);
        Task DeleteAsync(Authority entity);

    }
}
