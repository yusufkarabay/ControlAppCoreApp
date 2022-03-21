using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<PasswordNote> PasswordNotes { get; set; }
        public virtual ICollection<Request> Requests { get; set; }  
        
        public virtual ICollection<SentryDone> SentryDones { get; set; }
        public virtual ICollection<SentryToDo> SentryToDos { get; set; }




    }
}
