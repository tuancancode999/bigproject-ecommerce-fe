using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace eShopSolution.Data.Configurations
{
    public class TransactionConfigurations : IEntityTypeConfiguration<Transactions>
    { 
        public void Configure(EntityTypeBuilder<Transactions> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.UserId).IsRequired();

            builder.Property(x => x.Amount).IsRequired();

            builder.Property(x => x.Payment).IsRequired().HasMaxLength(600);

            builder.Property(x => x.PaymentInfo).IsRequired().HasMaxLength(600);

            builder.HasOne(x => x.AppUser).WithMany(x => x.Transactions).HasForeignKey(x => x.UserId);

            builder.HasOne(x => x.Order).WithMany(x => x.Transactions).HasForeignKey(x => x.OrderId);
        }
    }
}
