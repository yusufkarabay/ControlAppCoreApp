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
    public class PasswordNoteConfigurations : IEntityTypeConfiguration<PasswordNote>
    {
        public void Configure(EntityTypeBuilder<PasswordNote> builder)
        {
            throw new NotImplementedException();
        }
    }
}
