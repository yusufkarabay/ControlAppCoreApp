
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlApp.Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControlApp.Repository.Configurations
{
    public class DirectoryConfigurations : IEntityTypeConfiguration<Core.Entities.Abstract.Directory>
    {
        public void Configure(EntityTypeBuilder<Core.Entities.Abstract.Directory> builder)
        {
            throw new NotImplementedException();
        }

        
    }
}
