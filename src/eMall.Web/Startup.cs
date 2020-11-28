using System;
using Microsoft.Extensions.Configuration;
using eMall.Infrastructure;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Hommy.ApiResult;
using MediatR;
using FluentValidation;
using eMall.Application.CQRS.Behaviors;
using eMall.Application;

namespace eMall.Web
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        
        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen();

            services.AddControllers().AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.IgnoreNullValues = true;
                    options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
                    options.JsonSerializerOptions.Converters.Add(new FailureJsonConverter());
                });

            services.AddApiResult();

            services.AddDbContext<EMallDbContext>(options => 
            {
                options.UseMySql(_configuration["ConnectionStrings:DatabaseConnection"],
                    new MySqlServerVersion(new Version(8, 0, 22)));
            });

            services.AddScoped<DbContext, EMallDbContext>();

            services.AddMediatR(typeof(ApplicaitonModule));

            services.AddScoped(typeof(IPipelineBehavior<,>), typeof(ValidationPipelineBehavior<,>));

            services.AddValidatorsFromAssembly(typeof(ApplicaitonModule).Assembly);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "eMall API V1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
