using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Concrete
{
    public interface IGiveAndTake
    {
        string SpecialNo { get; set; }
         string DeliveryEmployee { get; set; }
         string ReceiverEmployee { get; set; }
         DateTime DeliveryDate { get; set; }
    }
}
