using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.DTOs
{
    public class SentryDoneDto
    {
        public string Done { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
