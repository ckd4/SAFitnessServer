using Microsoft.Extensions.Logging;

namespace Service.Logging
{
    public sealed class LoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new Service.Logging.Logger();
        }

        public void Dispose()
        {

        }
    }
}