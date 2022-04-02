using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.DTOs
{
    public class InventoryDto:BaseDto
    {
        public string SerialNumber { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string? Info { get; set; }
        public string CreatedEmployee { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
