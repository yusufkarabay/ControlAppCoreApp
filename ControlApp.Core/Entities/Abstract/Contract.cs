using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Contract : BaseEntity, ICreatedEmployee
    {
        public string ContractName { get; set; }
        public DateTime ContractStart { get; set; }
        public DateTime ContractEnd { get; set; }
        public string Company { get; set; }
        public string? CompanyAdress { get; set; }
        public string? CompanyTel { get; set; }
        public string? Notes { get; set; }
        public string CreatedEmployee { get; set; }
        public DateTime CreatedTime { get; set; }
        


    }
}
