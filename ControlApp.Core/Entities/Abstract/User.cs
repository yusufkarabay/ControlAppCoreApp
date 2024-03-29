﻿using ControlApp.Core.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace ControlApp.Core.Entities.Abstract
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string RePassword { get; set; }
        public string TC { get; set; }
        public string PhoneNumber { get; set; }
        public Guid? DepartmentId { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public Department? Department { get; set; }

        public Guid? AuthorityId { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public Authority? Authority { get; set; }
    }
}
