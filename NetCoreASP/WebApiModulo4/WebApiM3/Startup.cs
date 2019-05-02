using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApiM3.Contexts;
using WebApimodulo4.Helpers;
using WebApimodulo4.Services;

namespace WebApiM3
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
            //filtro personalizado
            services.AddScoped<MiFiltroDeAccion>();
            //habilita servicios para guardar informacion en cache
            services.AddResponseCaching();
            //servicio de seguridad
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer();
            //trabajar inyeccion de dependencias
            services.AddTransient<ClaseB>();

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc(opt =>
            {
                opt.Filters.Add(new MiFiltroDeExcepcion());//filtro personalizado para errores
                //opt.Filters.Add(typeof(MiFiltroDeExcepcion));//si ubiese inyeccion de dependencias en el filtro
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                    .AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);//ignora el error de referencias ciclicas
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            //middleware de cache
            app.UseResponseCaching();
            //autenticacion validada antes de en trar al controlaor MVC
            app.UseAuthentication();
            app.UseMvc();
        }
    }
}
