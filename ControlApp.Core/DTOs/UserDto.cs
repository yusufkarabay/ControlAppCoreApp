using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Core.DTOs
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string TC { get; set; }
        public string PhoneNumber { get; set; }
        public string DepartmentName { get; set; }
        public string AuthorityName { get; set; }
    }
}
