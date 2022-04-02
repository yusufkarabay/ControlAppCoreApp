using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.DTOs
{
    public class PasswordNoteDto:BaseDto
    {
        public string Title { get; set; }
        public string Password { get; set; }
        public string? ThisPasswordNote { get; set; }
        public string CreatedEmployee { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
