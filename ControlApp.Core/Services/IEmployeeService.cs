using ControlApp.Core.DTOs;
using ControlApp.Core.DTOs.EmployeeDtos;
using ControlApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Services
{
    public interface IEmployeeService:IGenericService<Employee>
    {
        Task<CustomResponseDto<List<EmployeeActiveDto>>> IsActive();
    }
}
