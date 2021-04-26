using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class AppUserConfigurations : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");


            builder.Property(x => x.FirstName).HasMaxLength(255);
            
            builder.Property(x => x.DisplayName).HasMaxLength(255);

            builder.Property(x => x.Address).HasMaxLength(1000);
        }
    }
}
