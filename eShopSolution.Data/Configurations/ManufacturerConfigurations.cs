using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ManufacturerConfigurations : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.ToTable("Manufacturers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.ManufactureName).IsRequired().HasMaxLength(500);

            builder.Property(x => x.Address).IsRequired().HasMaxLength(1000);

            builder.Property(x => x.Email).IsRequired().HasMaxLength(500);

            builder.Property(x => x.NumberPhone).IsRequired();
        }
    }
}
