using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ControlApp.Core.Entities.Abstract
{
    public class Department : BaseEntity
    {
        public string? Name { get; set; }
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual List<Employee> Employees { get; set; } = new List<Employee>();
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual List<SentryDone>? SentryDones { get; set; } = new List<SentryDone>();
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual List<SentryToDo>? SentryToDos { get; set; } = new List<SentryToDo>();
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual List<Request>? Requests { get; set; } = new List<Request>();
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual List<PasswordNote>? PasswordNotes { get; set; } = new List<PasswordNote>();
        [JsonIgnore]
        [IgnoreDataMember]
        public virtual List<Inventory>? Inventories { get; set; } = new List<Inventory>();


    }
}
