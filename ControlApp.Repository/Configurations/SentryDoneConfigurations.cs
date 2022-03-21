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
            throw new NotImplementedException();
        }
    }
}
