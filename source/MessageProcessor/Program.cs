using Module.Business;
using Module.Streaming;
using Service.Logging;

namespace MessageProcessor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args).ConfigureServices(services =>
            {
                services.AddLogging(
                    logger =>
                    {
                        logger.ClearProviders();
                        logger.AddProvider(new LoggerProvider());
                    });

                services.AddBusinessModule();
                services.AddStreamingModule();
                services.AddHostedService<Processor>();
            });
    }
}