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
    public class MaintenanceConfigurations : IEntityTypeConfiguration<Maintenance>
    {
        public void Configure(EntityTypeBuilder<Maintenance> builder)
        {

            builder.Property(x => x.FirstTime).IsRequired().HasColumnType("Date");

        }
    }
}
