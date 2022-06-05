using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vaccination_app.Context;
using vaccination_app.VaccinationDB;

namespace vaccination_app
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ChildContext>(options => options.UseSqlServer(Configuration.GetConnectionString("VaccConnString")));
            services.AddDbContext<MotherContext>(options => options.UseSqlServer(Configuration.GetConnectionString("VaccConnString")));
            services.AddDbContext<StaffContext>(options => options.UseSqlServer(Configuration.GetConnectionString("VaccConnString")));
            services.AddDbContext<HospitalContext>(options => options.UseSqlServer(Configuration.GetConnectionString("VaccConnString")));
            services.AddDbContext<VaccineContext>(options => options.UseSqlServer(Configuration.GetConnectionString("VaccConnString")));
            services.AddDbContext<VaccinationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("VaccConnString")));
            

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "vaccination_app", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "vaccination_app v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
