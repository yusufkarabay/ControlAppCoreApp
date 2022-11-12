using AutoMapper;
using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.Services;
using ControlApp.Core.UnitOfWorks;
using ControlApp.Repository.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace ControlApp.Service.Services
{
    public class AuthorityService : IAuthorityService
    {
        private readonly IAuthorityRepository _authorityRepository;
        private readonly IUnitOfWork _unitOfWork;

        public AuthorityService(IAuthorityRepository authorityRepository, IUnitOfWork unitOfWork)
        {
            _authorityRepository=authorityRepository;
            _unitOfWork=unitOfWork;
        }

        public async Task<(Authority, Exception?)> AddAsync(Authority entity)
        {
            try
            {
                await _authorityRepository.AddAsync(entity);
                await _unitOfWork.CommitAsync();
                return (entity, null);
            }
            catch (Exception ex)
            {
                return (null, ex);
            }


        }

        public Task DeleteAsync(Authority entity)
        {
            _authorityRepository.Delete(entity);
            return _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<Authority>> GetAllAsync()
        {
            try
            {
                var allAuth = _authorityRepository.GetAll();
                return allAuth;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<Authority> GetByIdAsync(Guid id)
        {
            return await _authorityRepository.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Authority entity)
        {
            _authorityRepository.Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public IQueryable<Authority> Where(Expression<Func<Authority, bool>> expression)
        {
            return _authorityRepository.Where(expression);
        }
    }
}



