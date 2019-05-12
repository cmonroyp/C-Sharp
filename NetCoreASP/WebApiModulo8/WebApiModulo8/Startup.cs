using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Swashbuckle.AspNetCore.Swagger;
using WebApiModulo8.Contexts;
using WebApiModulo8.Entities;
using WebApiModulo8.Helpers;
using WebApiModulo8.Models;
//permite por convencion retornar cada uno de las respuestas de los controladores en la configuracion de swagger
[assembly: ApiConventionType(typeof(DefaultApiConventions))]

namespace WebApiModulo8
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
            services.AddAutoMapper(options =>
            {
                options.CreateMap<AutorCreacionDTO, Autor>();
                options.CreateMap<Autor, AutorDTO>();
            });

            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("defaultConnection")));
            services.AddMvc(config =>
            {
                config.Conventions.Add(new ApiExplorerGroupPerVersionConvention());
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
                .AddJsonOptions(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);

            services
    .AddSingleton<IActionContextAccessor, ActionContextAccessor>()
    .AddScoped<IUrlHelper>(x => x
        .GetRequiredService<IUrlHelperFactory>()
        .GetUrlHelper(x.GetRequiredService<IActionContextAccessor>().ActionContext));

            services.AddScoped<HATEOASAuthorFilterAttribute>();
            services.AddScoped<HATEOASAuthorsFilterAttribute>();
            services.AddScoped<GeneradorEnlaces>();

            //crea documentacion de mi API, instalar Install-Package Swashbuckle.AspNetCore y configurar
            services.AddSwaggerGen(config =>
            {
                //https://localhost:44394/swagger/index.html
                config.SwaggerDoc("v1", new Info
                {
                    Version = "V1",
                    Title = "Mi Web API",
                    Description = "API Generada para Estudio",
                    TermsOfService = "https://stackblitz.com/@cmonroyp",
                    License = new License()
                    {
                        Name = "MIT",
                        Url = "https://stackblitz.com/@cmonroyp"
                    },
                    Contact = new Contact()
                    {
                        Name = "Carlos Mario Monroy",
                        Email = "cm2019@hotmail.com",
                        Url = "https://gavilan.blog/"
                    }
                });

                config.SwaggerDoc("v2", new Info { Title = "Mi Web API", Version = "v2" });

                //se tiene que editar el archivo .csproj y clocar  <NoWarn>$(NoWarn);1591</NoWarn>
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                config.IncludeXmlComments(xmlPath);

            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //configuracion para generar documentacion
            app.UseSwagger();

            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API V1");
                config.SwaggerEndpoint("/swagger/v2/swagger.json", "Mi API V2");
            });

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
            app.UseMvc();
        }

        public class ApiExplorerGroupPerVersionConvention : IControllerModelConvention
        {
            public void Apply(ControllerModel controller)
            {
                // Ejemplo: "Controllers.V1"
                var controllerNamespace = controller.ControllerType.Namespace;
                var apiVersion = controllerNamespace.Split('.').Last().ToLower();
                controller.ApiExplorer.GroupName = apiVersion;
            }
        }

    }
}
