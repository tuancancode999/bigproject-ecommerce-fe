using eShopSolution.Data.Configurations;
using eShopSolution.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.EF
{
    public class EShopSolutionDBContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public EShopSolutionDBContext(DbContextOptions<EShopSolutionDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new AppRoleConfigurations());
            builder.ApplyConfiguration(new AppUserConfigurations());
            builder.ApplyConfiguration(new AppRoleConfigurations());
            builder.ApplyConfiguration(new CartConfigurations());
            builder.ApplyConfiguration(new CategoryConfigurations());
            builder.ApplyConfiguration(new FeatBackConfigurations());
            builder.ApplyConfiguration(new ImageConfigurations());
            builder.ApplyConfiguration(new ManufacturerConfigurations());
            builder.ApplyConfiguration(new NotificationConfigurations());
            builder.ApplyConfiguration(new OrderConfigurations());
            builder.ApplyConfiguration(new OrderDetailconfigurations());
            builder.ApplyConfiguration(new OrderStatusConfigurations());
            builder.ApplyConfiguration(new ProductConfigurations());
            builder.ApplyConfiguration(new PromotionConfigurations());
            builder.ApplyConfiguration(new SizeConfigurations());
            builder.ApplyConfiguration(new TransactionConfigurations());

            builder.Entity<IdentityUserClaim<Guid>>().ToTable("AspUserClaims");
            builder.Entity<IdentityUserRole<Guid>>().ToTable("AspUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            builder.Entity<IdentityUserLogin<Guid>>().ToTable("AspUserLogins").HasKey(x => x.UserId);

            builder.Entity<IdentityRoleClaim<Guid>>().ToTable("AspRoleClaims");
            builder.Entity<IdentityUserToken<Guid>>().ToTable("AspUserTokens").HasKey(x => x.UserId);
        }


        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<FeatBack> FeatBacks { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<Sizes> Sizes { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
    }
}
