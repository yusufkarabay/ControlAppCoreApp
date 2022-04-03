using AutoMapper;
using ControlApp.Core.DTOs;
using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Repositories;
using ControlApp.Core.Services;
using ControlApp.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Service.Services
{
    public class EmployeeService : GenericService<Employee>, IEmployeeService
    {
        
        private readonly IMapper _mapper;
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IGenericRepository<Employee> genericRepository, IUnitOfWork unitOfWork, IMapper mapper, IEmployeeRepository employeeRepository) : base(genericRepository, unitOfWork)
        {

            _mapper=mapper;
            _employeeRepository=employeeRepository;
        }

        public async Task<CustomResponseDto<List<EmployeeActiveDto>>> IsActive()
        {

            var employee = await _employeeRepository.IsActive();
            var employeeActiveDto = _mapper.Map<List<EmployeeActiveDto>>(employee);
            return CustomResponseDto<List<EmployeeActiveDto>>.Success(200, employeeActiveDto);
        }
    }
}
