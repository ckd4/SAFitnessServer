using Microsoft.AspNetCore.Mvc;
using Server.Presentation.API.Logging;

namespace Server.Application.API
{
    public sealed class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.Configure<MvcOptions>(
                options =>
                {
                    options.Filters.Add(new RequireHttpsAttribute());
                });
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddLogging(logger => logger.ClearProviders());
            builder.Services.AddLogging(logger => logger.AddProvider(new ServerLoggerProvider()));

            var app = builder.Build();

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