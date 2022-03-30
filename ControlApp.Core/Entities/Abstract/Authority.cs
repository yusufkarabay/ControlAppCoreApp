﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Authority : BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Employee>? Employees { get; set; }
    }
}
