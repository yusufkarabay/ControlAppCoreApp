using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.DTOs
{
    public class RequestDto:BaseDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsSend { get; set; } = false;
        public bool IsEnd { get; set; } = false;
        public string RequestingEmployee { get; set; }
        public string RequestedEmployee { get; set; }
        public DateTime CreatedTime { get; set; }
        public string? RequestEndText { get; set; }
    }
}
