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
    public class PasswordNoteConfigurations : IEntityTypeConfiguration<PasswordNote>
    {
        public void Configure(EntityTypeBuilder<PasswordNote> builder)
        {
            //builder.Property(x => x.Title).IsRequired().HasMaxLength(80);
            //builder.Property(x => x.Password).IsRequired().HasMaxLength(80);
            //builder.Property(x => x.CreatedEmployee).IsRequired().HasMaxLength(80);
            //builder.Property(x => x.CreatedTime).IsRequired().HasColumnType("Date");
            //builder.Property(x => x.ThisPasswordNote).HasMaxLength(256);
          

        }
    }
}
