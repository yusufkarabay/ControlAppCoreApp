using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Inventory : BaseEntity, ICreatedEmployee
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string? Info { get; set; }
        public string CreatedEmployee { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
        
    }
}
