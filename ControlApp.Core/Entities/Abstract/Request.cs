using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Request : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsSend { get; set; }=false;
        public bool IsEnd { get; set; }=false ;
        public string RequestingEmployee { get; set; }
        public string RequestedEmployee { get; set; }
        public DateTime CreatedTime { get; set; }
        public string? RequestEndText { get; set; }

        public Guid EmployeeId { get; set; }
        public Guid DepartmentId { get; set; }

        public Employee Employee { get; set; }  
        public Department Department { get; set; }
       

    }
}
