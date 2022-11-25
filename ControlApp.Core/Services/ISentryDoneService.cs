using ControlApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Services
{
    public interface ISentryDoneService
    {
        Task<SentryDone> GetByIdAsync(Guid id);
        Task<IEnumerable<SentryDone>> GetAllAsync();
        IQueryable<SentryDone> Where(Expression<Func<SentryDone, bool>> expression);
        Task<(SentryDone, Exception?)> AddAsync(SentryDone entity);
        Task UpdateAsync(SentryDone entity);
        Task DeleteAsync(SentryDone entity);
        IQueryable<SentryDone> GetSentryDoneByDate(DateTime dateTime,Guid departmentId);
    }
}
