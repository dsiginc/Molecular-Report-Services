using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReportServices
{
    public class Startup
    {
      
        public Startup(IHostingEnvironment env)
        {

            var builder = new ConfigurationBuilder()
               .SetBasePath(env.ContentRootPath)
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
              // .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
               .AddEnvironmentVariables();
            Configuration = builder.Build();

            
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IConfiguration>(Configuration);

            //services.AddSwaggerGen(c =>
            //{
            //    // sepcify our operation filter here.  
            //    c.OperationFilter<AddCommonParameOperationFilter>();

            //    c.SwaggerDoc("v1", new OpenApiInfo
            //    {
            //        Version = "v1.0.0",
            //        Title = $"v1 API"

            //    });

            //    c.CustomSchemaIds(i => i.FullName);
            //});


            services.AddMvc()
           .AddJsonOptions(opt =>
            {
                opt.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;
                opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            });

            services.AddMvcCore();
           

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            // loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            // loggerFactory.AddDebug();


            app.UseCors(builder =>
               builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod()
               );

            //app.UseSwagger(c =>
            //{
            //});
            //app.UseSwaggerUI(c =>
            //{
            //    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1 API");
            //});

            app.UseMvc();
        }

    }

    //public class AddCommonParameOperationFilter : IOperationFilter
    //{
    //    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    //    {
    //        if (operation.Parameters == null) operation.Parameters = new List<OpenApiParameter>();

    //        var descriptor = context.ApiDescription.ActionDescriptor as ControllerActionDescriptor;

    //        if (descriptor != null && !descriptor.ControllerName.StartsWith("Weather"))
    //        {
    //            operation.Parameters.Add(new OpenApiParameter()
    //            {
    //                Name = "Authorization",
    //                In = ParameterLocation.Header,
    //                Description = "access token",
    //                Required = true

    //            });
    //        }
    //    }
    //}
}
