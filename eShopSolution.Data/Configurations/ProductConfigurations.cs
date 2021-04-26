using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.CategoryId).IsRequired();

            builder.Property(x => x.ManufacturerId).IsRequired();

            builder.Property(x => x.Image).IsRequired();

            builder.Property(x => x.NameProduct).IsRequired().HasMaxLength(500);

            builder.Property(x => x.Description).IsRequired().HasMaxLength(50000);

            builder.HasOne(x => x.Category).WithMany(x => x.Products).HasForeignKey(x => x.CategoryId);
            builder.HasOne(x => x.Manufacturer).WithMany(x => x.Products).HasForeignKey(x => x.ManufacturerId);
        }
    }
}
