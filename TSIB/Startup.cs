using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
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
using TSIB.Services;

namespace TSIB
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {            
            services.AddRazorPages();
            services.AddServerSideBlazor();

            
            services.AddHttpClient<IEmployeeService, EmployeeService>(client =>
            {
                client.BaseAddress = new Uri(Configuration.GetSection("ApiServiceUrl").Value);
            });
            services.AddHttpClient<IDepartmentService, DepartmentService>(client =>
            {
                client.BaseAddress = new Uri(Configuration.GetSection("ApiServiceUrl").Value);
            });
            services.AddHttpClient<IAttendanceService, AttendanceService>(client =>
            {
                client.BaseAddress = new Uri(Configuration.GetSection("ApiServiceUrl").Value);
            });
            services.AddHttpClient<IAttendanceTypeService, AttendanceTypeService>(client =>
            {
                client.BaseAddress = new Uri(Configuration.GetSection("ApiServiceUrl").Value);
            });
            services.AddHttpClient<ISettingService, SettingService>(client =>
            {
                client.BaseAddress = new Uri(Configuration.GetSection("ApiServiceUrl").Value);
            });
            services.AddHttpClient<IReportService, ReportService>(client =>
            {
                client.BaseAddress = new Uri(Configuration.GetSection("ApiServiceUrl").Value);
            });
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
            app.UseStaticFiles();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
