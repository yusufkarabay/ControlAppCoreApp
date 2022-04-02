using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.DTOs
{
    public class GeneratorUsedTimeDto:BaseDto
    {
        public int GeneratorWorkedTime { get; set; }
        public string AddedEmployee { get; set; }
        public DateTime AddedTime { get; set; }
    }
}
