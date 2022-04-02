using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.DTOs
{
    public class CabinetDto:BaseDto
    {
        public string SpecialNo { get; set; }
        public string DeliveryEmployee { get; set; }
        public string ReceiverEmployee { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
