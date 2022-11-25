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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository=userRepository;
            _unitOfWork=unitOfWork;
        }

        public async Task<(User, Exception?)> AddAsync(User entity)
        {
            try
            {
                await _userRepository.AddAsync(entity);
                await _unitOfWork.CommitAsync();
                return (entity, null);
            }
            catch (Exception ex)
            {
                return (null, ex);
            }
        }

        public Task DeleteAsync(User entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<(User, Exception?)> GetByIdAsync(Guid id)
        {
            try
            {
                var user = await _userRepository.GetByIdAsync(id);

                return (user, null);
            }
            catch (Exception ex)
            {
                return (null, ex);
            }
        }

        public async Task UpdateAsync(User entity)
        {

            _userRepository.Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public IQueryable<User> Where(Expression<Func<User, bool>> expression)
        {
            return _userRepository.Where(expression);
        }
    }
}
