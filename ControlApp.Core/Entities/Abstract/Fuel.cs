using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Fuel
    {
        public Guid Id { get; set; }= Guid.NewGuid();   
        public DateTime FuelTime { get; set; }= DateTime.Now;   
        public string FuelEmployeeName { get; set; }
    }
}
