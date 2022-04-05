using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Repository.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(ControlAppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<Employee>> IsActiveAsync()
        {
           return await _dbContext.Employees.Where(x=>x.IsUser==true).ToListAsync();  
        }
    }
}
