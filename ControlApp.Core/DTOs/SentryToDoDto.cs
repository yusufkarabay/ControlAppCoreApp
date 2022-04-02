using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.DTOs
{
    public class SentryToDoDto:BaseDto
    {
        public string ToDo { get; set; }
        public string CreatedEmployee { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
