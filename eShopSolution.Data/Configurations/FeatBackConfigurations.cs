using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class FeatBackConfigurations : IEntityTypeConfiguration<FeatBack>
    {
        public void Configure(EntityTypeBuilder<FeatBack> builder)
        {
            builder.ToTable("FeatBacks");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Content).IsRequired().HasMaxLength(255);

            builder.HasOne(x => x.appUser).WithMany(x => x.featBacks).HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Product).WithMany(x => x.FeatBacks).HasForeignKey(x => x.ProductId);
        }
    }
}
