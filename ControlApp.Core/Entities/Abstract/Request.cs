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
        public string RequestContent { get; set; }
        public bool IsSend { get; set; }=false;
        public bool IsEnd { get; set; }=false ;
        public string RequestingEmployee { get; set; }
        public string RequestedEmployee { get; set; }
        public DateTime CreatedTime { get; set; }
        public string? RequestEndText { get; set; }
        
        public Guid RequestCreatedEmployeeId { get; set; }
        public Guid RequestCreatedDepartmentId { get; set; }

        public Guid? RequestingEmployeeId { get; set; }
        public Guid? RequestingDepartmentId { get; set; }

    }
}
