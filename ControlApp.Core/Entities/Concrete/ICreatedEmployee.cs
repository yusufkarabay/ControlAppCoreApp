using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Concrete
{
    public interface ICreatedEmployee
    {
        string CreatedEmployee { get; set; }
        DateTime CreatedTime { get; set; }
    }
}
