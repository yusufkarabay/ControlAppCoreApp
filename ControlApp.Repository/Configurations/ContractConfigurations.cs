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
    public class ContractConfigurations : IEntityTypeConfiguration<Contract>
    {
        public void Configure(EntityTypeBuilder<Contract> builder)
        {
            builder.Property(x => x.ContractName).IsRequired().HasMaxLength(80);
            builder.Property(x => x.ContractStart).HasColumnType("Date").IsRequired();
            builder.Property(x => x.ContractEnd).HasColumnType("Date").IsRequired();
            builder.Property(x => x.Company).IsRequired().HasMaxLength(80);
            builder.Property(x => x.CompanyAdress).HasMaxLength(256);
            builder.Property(x => x.CompanyTel).HasMaxLength(24);
            builder.Property(x => x.CreatedTime).IsRequired().HasColumnType("Date");





        }
    }
}
