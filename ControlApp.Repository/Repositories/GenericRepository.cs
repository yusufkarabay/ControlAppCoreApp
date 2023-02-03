using ControlApp.Core.Repositories;
using ControlApp.Core.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Repository.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        protected readonly ControlAppDbContext _dbContext;
        protected readonly DbSet<T> _dbSet;
        protected readonly IUnitOfWork unitOfWork;

        // protected virtual IQueryable<T> _dbSet => _dbContext.Set<T>().AsNoTracking();

        public GenericRepository(ControlAppDbContext dbContext, IUnitOfWork unitOfWork)
        {
            _dbContext=dbContext;
            _dbSet=_dbContext.Set<T>();
            this.unitOfWork=unitOfWork;
        }

        public async Task AddAsync(T entity)
        {
            await _dbContext.AddAsync(entity);
        }



        public async Task<T> ByEmployee(string name)
        {
            return await _dbSet.FindAsync(name);

        }

        public void Delete(T entity)
        {
            _dbContext.Remove(entity);
            unitOfWork.Commit();
        }


        public IQueryable<T> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);

        }

        public void Update(T entity)
        {
            _dbContext.Update(entity);
            unitOfWork.Commit();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }
    }
}
