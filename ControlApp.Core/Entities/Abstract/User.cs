using ControlApp.Core.Entities.Concrete;
using Microsoft.AspNetCore.Identity;

namespace ControlApp.Core.Entities.Abstract
{
    public class User :BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool Deleted { get; set; }
        public bool Enabled { get; set; }

    }
}
