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
    public class InventoryConfigurations : IEntityTypeConfiguration<Inventory>
    {
        public void Configure(EntityTypeBuilder<Inventory> builder)
        {
            builder.Property(x => x.SerialNumber).IsRequired().HasMaxLength(80);
            builder.Property(x => x.CreatedDate).HasColumnType("date");
            builder.Property(x => x.Name).HasMaxLength(80);
            builder.Property(x => x.Info).HasMaxLength(256);



        }
    }
}
