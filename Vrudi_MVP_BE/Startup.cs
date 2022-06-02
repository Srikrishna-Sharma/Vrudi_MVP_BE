using System;
using Vrudi_MVP_BE.Services.Interfaces;
using Vrudi_MVP_BE.Services.Classes;
using Vrudi_MVP_BE.Extensions;

namespace Vrudi_MVP_API
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
            services.AddJwtAuthenticate();
            services.AddControllers();
            services.AddSwagger();
            services.AddDependencies();

           

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
            app.UseSwagger();
            app.UseSwaggerUI(swag =>
            {
                swag.SwaggerEndpoint("/swagger/v1/swagger.json", "Vrudi_MVP_BE_API");
                swag.RoutePrefix = "";
            });
        }
    }
}
