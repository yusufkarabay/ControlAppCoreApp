using ControlApp.Core.Repositories;
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
        //readonly'e yalnızca burada ya da constructor'da değer ataması yapılmaktadır
        protected readonly ControlAppDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ControlAppDbContext dbContext)
        {
            _dbContext=dbContext;
            _dbSet=_dbContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
           await _dbSet.AddAsync(entity);   
        }

        public  void Delete(T entity)
        {
           _dbSet.Remove(entity);
        }
        

        public  IQueryable<T> GetAll()
        {
           return _dbSet.AsNoTracking().AsQueryable();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
           return await _dbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
           _dbSet.Update(entity);   
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
           return _dbSet.Where(expression); 
        }
    }
}
