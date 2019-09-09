using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using PlantIterationOne.Web.Data;
using PlantIterationOne.Web.Model;
using PlantIterationOne.Web.Services;

namespace PlantIterationOne.Web
{
    public class Startup
    {

        public IConfiguration _configuration; 

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddOptions();
            services.AddMvc();
            //services.Configure<AzureStorageConfig>(_configuration.GetSection("AzureStorageConfig"));
            services.AddDbContext<PlantContext>(options =>
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
            services.BuildServiceProvider().GetService<PlantContext>().Database.Migrate();
            services.AddScoped<IInvasiveService, InvasiveService>();
            services.AddScoped<INativeService, NativeService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseFileServer(); 

            app.UseMvc(builder=>
            {
                builder.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
            }); 
        }
    }
}
