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
    public class GeneratorUsedTimeConfigurations : IEntityTypeConfiguration<GeneratorUsedTime>
    {
        public void Configure(EntityTypeBuilder<GeneratorUsedTime> builder)
        {
            builder.Property(x => x.GeneratorWorkedTime).IsRequired();
            builder.Property(x => x.AddedTime).IsRequired().HasMaxLength(80);
            builder.Property(x => x.AddedTime).IsRequired().HasColumnType("Date");



        }
    }
}
