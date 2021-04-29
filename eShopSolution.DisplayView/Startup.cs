using AutoMapper;
using eShopSolution.Data.EF;
using eShopSolution.Data.Entities;
using eShopSolution.Repository.Implement;
using eShopSolution.Repository.Interface;
using eShopSolution.Service.Implement;
using eShopSolution.Service.Interface;
using eShopSolution.Utilities.AutoMapper;
using eShopSolution.Utilities.Constants;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShopSolution.DisplayView
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddHttpClient();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    //options.LoginPath = "/User/Login/";
                    options.AccessDeniedPath = "/User/Forbidden/";
                    options.LoginPath = "/account/facebook-login"; // Must be lowercase
                    options.LoginPath = "/account/google-login"; // Must be lowercase
                })  
               .AddFacebook(options =>
                {
                    options.AppId = "267822914972808";
                    options.AppSecret = "1a47c480ec763b5233b4d939f5084261";
                })
               .AddGoogle(options =>
               {
                    options.ClientId = "968585337414-t62d7776i8u0h2hjgvtikoi0kc01avk8.apps.googleusercontent.com";
                    options.ClientSecret = "o7Wux2HtqHxjxHq2gVBS5jyw";
               });
            services.AddControllersWithViews();

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            services.AddDbContext<EShopSolutionDBContext>(options =>
            options.UseMySql(Configuration.GetConnectionString(SystemConstants.MainConnectionString)));

            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);

            services.AddTransient<ICartService, CartService>();
            services.AddTransient<IAppRoleService, AppRoleService>();
            services.AddTransient<IAppUserService, AppUserService>();
            services.AddTransient<INotificationService,NotificationService>();
            services.AddTransient<IFeatBackService, FeatBackService>();
            services.AddTransient<ISizeService, SizeService>();
            services.AddTransient<ITransactionService, TransactionService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IPromotionService, PromotionService>();
            services.AddTransient<IManufacturerService, ManufacturerService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IUserApiService, UserApiService>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<IManufacturerRepository, ManufacturerRepository>();
            services.AddTransient<IPromotionRepository, PromotionRepository>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<ITransactionRepository, TransactionRepository>();
            services.AddTransient<ISizeRepository, SizeRepository>();
            services.AddTransient<IFeatBackRepository, FeatBackRepository>();
            services.AddTransient<INotificationRepository, NotificationRepository>();
            services.AddTransient<IAppUserRepository, AppUserRepository>();
            services.AddTransient<IAppRoleRepository, AppRoleRepository>();
            services.AddTransient<ICartRepository, CartRepository>();

            IMvcBuilder builder = services.AddRazorPages();
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

#if DEBUG
            if (environment == Environments.Development)
            {
                builder.AddRazorRuntimeCompilation();
            }
#endif
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();
            app.UseSession();

           

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                name: "Admin",
                areaName: "Admin",
                pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });


        }
    }
}
