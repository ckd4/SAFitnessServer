using Microsoft.AspNetCore.Mvc;
using Module.Business;
using Module.Streaming;
using Service.Logging;

namespace API
{
    public class Startup
    {
        public IConfiguration configRoot { get; }

        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<MvcOptions>(options => options.Filters.Add(new RequireHttpsAttribute()));
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddLogging(
                logger =>
                {
                    logger.ClearProviders();
                    logger.AddProvider(new LoggerProvider());
                });

            services.AddBusinessModule();
            services.AddStreamingModule();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
        }
    }
}
