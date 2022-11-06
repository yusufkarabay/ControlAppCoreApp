using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public abstract class BaseEntity : IBaseEntity
    {
        public Guid Id { get ; set ; }=Guid.NewGuid();  
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public DateTime? UpdatedDate { get ; set ; }
        public bool Deleted { get ; set ; }= false;
        public bool Enabled { get ; set ; }= false;
        public string CreatedBy { get; set; } = "Yusuf";
        public string LastModifiedBy { get; set; } = "Hasan";

        [ConcurrencyCheck]
        public long Version { get; set; } = 0;
    }
}

