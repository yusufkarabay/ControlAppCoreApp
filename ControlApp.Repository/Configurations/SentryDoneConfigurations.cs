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
    public class SentryDoneConfigurations : IEntityTypeConfiguration<SentryDone>
    {
        public void Configure(EntityTypeBuilder<SentryDone> builder)
        {
            //builder.Property(x => x.CreatedEmployee).IsRequired().HasMaxLength(80);
            //builder.Property(x => x.CreatedTime).IsRequired().HasColumnType("Date");

        }
    }
}
