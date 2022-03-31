using ControlApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Headset : BaseEntity, IGiveAndTake
    {
        public string SpecialNo { get ; set ; }
        public string DeliveryEmployee { get ; set ; }
        public string ReceiverEmployee { get ; set ; }
        public DateTime DeliveryDate { get ; set ; }
    }
}
