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
        public bool IsSend { get; set; }
        public bool IsEnd { get; set; }
        public string RequestingEmployee { get; set; }
        public string? RequestedEmployee { get; set; }
        public DateTime CreatedTime { get; set; }
        public string? RequestEndText { get; set; }

        public virtual ICollection<Employee>? Employees { get; set; }
        public virtual ICollection<Department>? Departments { get; set; }

    }
}
