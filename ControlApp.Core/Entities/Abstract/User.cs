using ControlApp.Core.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace ControlApp.Core.Entities.Abstract
{
    public class User :BaseEntity
    {
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
        public bool Enabled { get; set; }

    }
}
