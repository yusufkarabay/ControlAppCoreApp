using AutoMapper;
using ControlApp.Core.DTOs;
using ControlApp.Core.DTOs.EmployeeDtos;
using ControlApp.Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Authority, AuthorityDto>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Fuel, FuelDto>().ReverseMap();
            CreateMap<GeneratorUsedTime, GeneratorUsedTimeDto>().ReverseMap();
            CreateMap<Inventory, InventoryDto>().ReverseMap();
            CreateMap<Maintenance, MaintenanceDto>().ReverseMap();
            CreateMap<PasswordNote, PasswordNoteDto>().ReverseMap();
            CreateMap<Request, RequestDto>().ReverseMap();
            CreateMap<SentryDone, SentryDoneDto>().ReverseMap();
            CreateMap<SentryToDo, SentryToDoDto>().ReverseMap();
            CreateMap<Cabinet, CabinetDto>().ReverseMap();
            CreateMap<Employee, EmployeeActiveDto>();



        }
    }
}
