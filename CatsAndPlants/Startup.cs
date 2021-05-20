using CatsAndPlants.Models;
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

namespace CatsAndPlants
{
    public class Startup
    {
        //Fields / Props
        private IConfiguration _configuration { get; }

        //Constructor
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        //Methods
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<ICustomerRepository, EfCustomerRepository>();
            services.AddScoped<IOrderRepository, EfOrderRepository>();
            services.AddScoped<IProductRepository, EfProductRepository>();


            services.AddControllersWithViews();
            services.AddRazorPages();
            services.AddDistributedMemoryCache();
            services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(3); });
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
            app.UseStatusCodePages();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("catpage",
                "{category}/Page{productPage:int}",
                new { Controller = "Home", action = "Index" });

                endpoints.MapControllerRoute("page",
                   "Page{productPage:int}",
                   new
                   {
                       Controller = "Home",
                       action = "Index"
                   });

                endpoints.MapControllerRoute("category",
                   "{category}",
                   new
                   {
                       Controller = "Home",
                       action = "Index"
                   });

                endpoints.MapControllerRoute("pagination",
                   "Products/Page{productPage}",
                   new { Controller = "Home", action = "Index" });

                // URL: .../{controller}/{action}     Default: /Home/Index
                endpoints.MapDefaultControllerRoute();

                endpoints.MapRazorPages();
            });
        }
    }
}
