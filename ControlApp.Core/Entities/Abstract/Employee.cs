using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TC { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Adress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Mail { get; set; }
        public bool IsDeleted { get; set; } = false;
        public bool IsUser { get; set; } = false;
        public Guid DepartmentId { get; set; }

        public Department? Department;
        public ICollection<Authority>? Authorities { get; set; }

        public ICollection<Request>? Requests { get; set; }
    }
}
