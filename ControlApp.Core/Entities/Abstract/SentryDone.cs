using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class SentryDone : BaseEntity, ICreatedEmployee
    {
        public string Done { get; set; }
        public string CreatedEmployee { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid DepartmentId { get; set; }

        public virtual Department Department { get; set; }
    }
}
