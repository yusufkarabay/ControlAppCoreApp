using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class GeneratorUsedTime
    {
        public Guid Id { get; set; }= Guid.NewGuid();   
        public int GeneratorWorkedTime { get; set; }
        public string AddedEmployee { get; set; }
        public DateTime AddedTime { get; set; }= DateTime.Now;  

    }
}
