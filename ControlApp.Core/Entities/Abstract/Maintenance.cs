using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Maintenance : BaseEntity, ICreatedEmployee
    {
        public int AgainMonth { get; set; }
        public DateTime FirstTime { get; set; }      
        public string CreatedEmployee { get; set; }
        public DateTime CreatedTime { get; set; }

        public Guid? ContractId { get; set; }
        public Contract? Contract { get; set; }
    }
}
