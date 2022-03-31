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
    public class FuelConfigurations : IEntityTypeConfiguration<Fuel>
    {
        public void Configure(EntityTypeBuilder<Fuel> builder)
        {
            //builder.Property(x => x.FuelTime).IsRequired().HasColumnType("Date");
            //builder.Property(x => x.FuelEmployeeName).IsRequired().HasMaxLength(80);

        }
    }
}
