using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWebApplication.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CarWebApplication
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
            
            services.AddControllersWithViews();
            services.AddSingleton<ISingletonOperation, SingletonOperation>();
            services.AddTransient<ITransientOperation, TransientOperation>();
            services.AddScoped<IScopedOperation, ScopedOperation>();
            services.AddTransient<IMyService, MyService>();
            services.AddTransient<IUserData, UserData>();
            services.AddTransient<IDataSource, JsonDataSource>();
            services.AddTransient<IDataSource, XmlDataSource>();


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
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            

            ////app.UseMvc(rout=> {
            ////    rout.MapRoute(
            ////        name:"Default",
            ////        template: "{controller}/{action}",
            ////        defaults: new{controler="Home", action="Login"});
            ////});
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Login}/{id?}");
            });
        }
    }
}
