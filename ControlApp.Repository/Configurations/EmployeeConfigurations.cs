using ControlApp.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Repository.Configurations
{
    public class EmployeeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
        //    builder.Property(x => x.FirstName).IsRequired().HasMaxLength(40);
        //    builder.Property(x => x.LastName).IsRequired().HasMaxLength(40);
        //    builder.Property(x => x.TC).IsRequired().HasMaxLength(11);
        //    builder.Property(x => x.BirthDate).IsRequired().HasColumnType("Date");
        //    builder.Property(x => x.Adress).HasMaxLength(256);
        //    builder.Property(x => x.PhoneNumber).HasMaxLength(24);
        //    builder.Property(x => x.Mail).HasMaxLength(80);
  



        }
    }
}
