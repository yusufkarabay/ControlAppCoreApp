﻿using ControlApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Services
{
    public interface IInventoryService : IGenericService<Inventory>
    {
        Task<List<Inventory>> GetAllInventory(Guid departmentId);
        Task<List<Inventory>> GetAddedDateInventory(Guid departmentId, DateTime dateTime);

    }
}
