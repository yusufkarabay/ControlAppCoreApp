using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Department : BaseEntity
    {
        public string? Name { get; set; }
        public  ICollection<Employee> Employees { get; set; }
        public ICollection<SentryDone>? SentryDones { get; set; }
        public ICollection<SentryToDo>? SentryToDos { get; set; }
        public ICollection<Request>? Requests { get; set; }
        public ICollection<PasswordNote>? PasswordNotes { get; set; }
        public ICollection<Inventory>? Inventories { get; set; }



    }
}
