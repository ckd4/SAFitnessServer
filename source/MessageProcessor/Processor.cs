namespace MessageProcessor
{
    public class Processor : BackgroundService
    {
        private readonly ILogger<Processor> logger;

        public Processor(ILogger<Processor> logger)
        {
            this.logger = logger;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return Task.CompletedTask;
        }
    }
}