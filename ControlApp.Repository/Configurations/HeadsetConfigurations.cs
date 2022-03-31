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
    public class HeadsetConfigurations : IEntityTypeConfiguration<Headset>
    {
        public void Configure(EntityTypeBuilder<Headset> builder)
        {
        //    builder.Property(x => x.SpecialNo).IsRequired().HasMaxLength(24);
        //    builder.Property(x => x.DeliveryDate).IsRequired().HasColumnType("Date");

        }
    }
}
