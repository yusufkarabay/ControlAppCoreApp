using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Authority : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
