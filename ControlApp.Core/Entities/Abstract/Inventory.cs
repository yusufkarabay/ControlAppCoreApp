﻿using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Inventory : BaseEntity
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string? Info { get; set; }
        public Guid DepartmentId { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public Department Department { get; set; }
        
    }
}
