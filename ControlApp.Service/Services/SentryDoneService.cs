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
    public class SentryDoneService : ISentryDoneService
    {
        private readonly ISentryDoneRepository _sentryDoneRepository;
        private readonly IUnitOfWork _unitOfWork;

        public SentryDoneService(ISentryDoneRepository sentryDoneRepository, IUnitOfWork unitOfWork)
        {
            _sentryDoneRepository=sentryDoneRepository;
            _unitOfWork=unitOfWork;
        }

        public async Task<(SentryDone, Exception?)> AddAsync(SentryDone entity)
        {
            try
            {
                await _sentryDoneRepository.AddAsync(entity);
                await _unitOfWork.CommitAsync();
                return (entity, null);
            }
            catch (Exception ex)
            {
                return (null, ex);
            }
        }

        public async Task DeleteAsync(SentryDone entity)
        {
             _sentryDoneRepository.Delete(entity);
            await _unitOfWork.CommitAsync();
        }

        public Task<IEnumerable<SentryDone>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<SentryDone> GetByIdAsync(Guid id)
        {
            var sentryDone = await _sentryDoneRepository.GetByIdAsync(id);
            return sentryDone;
        }

        public IQueryable<SentryDone> GetSentryDoneByDate(DateTime dateTime,Guid departmentId)
        {
            return _sentryDoneRepository.Where(x => x.CreatedDate.Date==dateTime&&x.DepartmentId==departmentId);
        }

        public async Task UpdateAsync(SentryDone entity)
        {

            _sentryDoneRepository.Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public IQueryable<SentryDone> Where(Expression<Func<SentryDone, bool>> expression)
        {
            throw new NotImplementedException();
        }
    }
}
