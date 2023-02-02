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
    public class InventoryService : IInventoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IInventoryRepository _inventoryRepository;

        public InventoryService(IUnitOfWork unitOfWork, IInventoryRepository inventoryRepository)
        {
            _unitOfWork=unitOfWork;
            _inventoryRepository=inventoryRepository;
        }

        public async Task<(Inventory, Exception?)> AddAsync(Inventory entity)
        {
            try
            {
                await _inventoryRepository.AddAsync(entity);
                await _unitOfWork.CommitAsync();
                return (entity, null);
            }
            catch (Exception ex)
            {
                return (null, ex);
            }
        }

        public async Task DeleteAsync(Inventory entity)
        {
            _inventoryRepository.Delete(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<Inventory>> GetAddedDateInventory(Guid departmentId, DateTime dateTime)
        {
            var date = dateTime.ToString("yyyy-MM-dd");
            var parsedDate = Convert.ToDateTime(date);
            var getAddedDateInventory = _inventoryRepository.Where(x => x.DepartmentId==departmentId&&x.CreatedDate==parsedDate).ToList();
            return getAddedDateInventory;
        }

        public Task<IEnumerable<Inventory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<List<Inventory>> GetAllInventory(Guid departmentId)
        {
            var allInventories = _inventoryRepository.Where(x => x.DepartmentId==departmentId).ToList();
            return allInventories;
        }

        public async Task<Inventory> GetByIdAsync(Guid id)
        {
            var inventoryById = await _inventoryRepository.GetByIdAsync(id);
            return inventoryById;
        }

      

        public async Task UpdateAsync(Inventory entity)
        {
            _inventoryRepository.Update(entity);
        }

        public  IQueryable<Inventory> Where(Expression<Func<Inventory, bool>> expression)
        {
            return _inventoryRepository.Where(expression);
        }
    }
}
