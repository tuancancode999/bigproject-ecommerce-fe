﻿using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class CartConfigurations : IEntityTypeConfiguration<Cart>
    {

        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");
            
            builder.HasKey("Id");

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.UserId).IsRequired();

            builder.Property(x => x.ProductId).IsRequired();

            builder.HasOne(x => x.AppUser).WithMany(x => x.Carts).HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Product).WithMany(x => x.Carts).HasForeignKey(x => x.ProductId);
        }
    }
}
