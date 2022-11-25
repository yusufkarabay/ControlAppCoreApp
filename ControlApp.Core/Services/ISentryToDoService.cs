using ControlApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Services
{
    public interface ISentryToDoService
    {
        Task<SentryToDo> GetByIdAsync(Guid id);
        Task<IEnumerable<SentryToDo>> GetAllAsync();
        IQueryable<SentryToDo> Where(Expression<Func<SentryToDo, bool>> expression);
        Task<(SentryToDo, Exception?)> AddAsync(SentryToDo entity);
        Task UpdateAsync(SentryToDo entity);
        Task DeleteAsync(SentryToDo entity);
        IQueryable<SentryToDo> GetSentryToDoByDate(DateTime dateTime, Guid departmentId);
    }
}
