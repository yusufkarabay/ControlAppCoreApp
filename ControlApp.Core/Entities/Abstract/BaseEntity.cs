using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class BaseEntity : IBaseEntity
    {
        public Guid Id { get ; set ; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get ; set ; }
        public bool Deleted { get ; set ; }= false;
        public bool Enabled { get ; set ; }= false;
    }
}

