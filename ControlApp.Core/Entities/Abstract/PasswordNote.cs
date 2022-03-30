using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class PasswordNote : BaseEntity, ICreatedEmployee
    {
        public string Title { get; set; }
        public string Password { get; set; }
        public string? ThisPasswordNote { get; set; }
        public string CreatedEmployee { get; set; }
        public DateTime CreatedTime { get; set; }
        public Guid DepartmentId { get; set; }
        public virtual Department Department { get; set; }
    }
}
