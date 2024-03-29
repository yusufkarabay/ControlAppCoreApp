﻿using ControlApp.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlApp.Repository.Configurations
{
    public class EntranceCardConfigurations : IEntityTypeConfiguration<EntranceCard>
    {
        public void Configure(EntityTypeBuilder<EntranceCard> builder)
        {
            builder.Property(x => x.SpecialNo).IsRequired().HasMaxLength(40);
            builder.Property(x => x.DeliveryDate).HasColumnType("Date");


        }
    }
}
