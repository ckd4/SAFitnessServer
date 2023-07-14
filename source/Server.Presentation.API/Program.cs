using Microsoft.AspNetCore.Mvc;
using Server.Service.Logging;
using Server.Core.Application;
using Server.Core.Infrastructure;

namespace Server.Application.API
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            {
                builder.Services.Configure<MvcOptions>(options => options.Filters.Add(new RequireHttpsAttribute()));
                builder.Services.AddApplication().AddInfrastructure();
                builder.Services.AddControllers();
                builder.Services.AddEndpointsApiExplorer();
                builder.Services.AddSwaggerGen();
                builder.Services.AddLogging(
                    logger =>
                    {
                        logger.ClearProviders();
                        logger.AddProvider(new ServerLoggerProvider());
                    });
            }
            

            var app = builder.Build();
            {
                if (app.Environment.IsDevelopment())
                {
                    app.UseSwagger();
                    app.UseSwaggerUI();
                }

                app.UseHttpsRedirection();
                app.MapControllers();
                app.Run();
            }
        }
    }
}