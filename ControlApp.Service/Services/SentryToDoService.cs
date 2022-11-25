using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.Services;
using ControlApp.Core.UnitOfWorks;
using ControlApp.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Service.Services
{
    public class SentryToDoService : ISentryToDoService
    {
        private readonly ISentryToDoRepository _sentryToDoRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SentryToDoService(ISentryToDoRepository sentryToDoRepository, IUnitOfWork unitOfWork)
        {
            _sentryToDoRepository=sentryToDoRepository;
            _unitOfWork=unitOfWork;
        }

        public async Task<(SentryToDo, Exception?)> AddAsync(SentryToDo entity)
        {
            try
            {
                await _sentryToDoRepository.AddAsync(entity);
                await _unitOfWork.CommitAsync();
                return (entity, null);
            }
            catch (Exception ex)
            {
                return (null, ex);
            }
        }

        public async Task DeleteAsync(SentryToDo entity)
        {
            _sentryToDoRepository.Delete(entity);
            await _unitOfWork.CommitAsync();
        }

        public Task<IEnumerable<SentryToDo>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<SentryToDo> GetByIdAsync(Guid id)
        {
            var sentryTodo = await _sentryToDoRepository.GetByIdAsync(id);
            return sentryTodo;
        }

        public Task UpdateAsync(SentryToDo entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<SentryToDo> Where(Expression<Func<SentryToDo, bool>> expression)
        {
            throw new NotImplementedException();
        }
        public IQueryable<SentryToDo> GetSentryToDoByDate(DateTime dateTime, Guid departmentId)
        {
            return _sentryToDoRepository.Where(x => x.CreatedDate.Date==dateTime&&x.DepartmentId==departmentId);
        }
    }
}
