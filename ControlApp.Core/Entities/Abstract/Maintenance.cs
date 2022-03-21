using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Maintenance : BaseEntity
    {
        public int AgainMonth { get; set; } 
        public DateTime FirstTime { get; set; } 
        public virtual Contract Contract { get; set; }  
    }
}
