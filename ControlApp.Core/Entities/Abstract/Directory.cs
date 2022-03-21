using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Directory : BaseEntity,ICreatedEmployee
    {
        public string DirectoryName { get; set; }
        public string Phone { get; set; }
        public string? Info { get; set; }
        public string CreatedEmployee { get; set; }
        public DateTime CreatedTime {get ; set; }
    }
}
