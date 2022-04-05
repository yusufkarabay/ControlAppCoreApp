using AutoMapper;
using ControlApp.Core.Entities.Abstract;
using ControlApp.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ControlApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IMapper mapper, IGenericService<Employee> service, IEmployeeService employeeService)
        {
            _mapper=mapper;
            _employeeService=employeeService;
        }

        /// <summary>
        /// Aktif Personelleri Getirir
        /// </summary>
        /// <returns></returns>
        //[HttpGet("[action]")]
        //public async Task<IActionResult> IsActive()
        //{
        //   // return CreateActionResult(await _employeeService.IsActive());
        //}
    }
}
