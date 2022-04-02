using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.DTOs
{
    public class MaintenanceDto:BaseDto
    {
        public int AgainMonth { get; set; }
        public DateTime FirstTime { get; set; }
    }
}

