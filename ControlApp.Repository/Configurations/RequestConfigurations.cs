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
    public class RequestConfigurations : IEntityTypeConfiguration<Request>
    {
        public void Configure(EntityTypeBuilder<Request> builder)
        {
            builder.Property(x => x.Title).IsRequired().HasMaxLength(80);
            builder.Property(x => x.CreatedTime).IsRequired().HasColumnType("Date");
            builder.Property(x => x.RequestedEmployee).IsRequired().HasMaxLength(80);
            builder.Property(x => x.RequestingEmployee).IsRequired().HasMaxLength(80);
            
        }
    }
}
