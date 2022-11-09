using ControlApp.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Repository.UnitofWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ControlAppDbContext _controlAppDbContext;   

        public UnitOfWork(ControlAppDbContext controlAppDbContext)
        {
            _controlAppDbContext = controlAppDbContext; 
        }
        public void Commit()
        {
            _controlAppDbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
         await _controlAppDbContext.SaveChangesAsync();
        }
    }
}
