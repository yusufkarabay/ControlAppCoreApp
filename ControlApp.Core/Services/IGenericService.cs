using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Services
{
    public interface IGenericService<T> where T : class
    {
        Task<T> GetByIdAsync(Guid id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<(T,Exception?)> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
      
    }
}
