using Microsoft.Extensions.Logging;

namespace Server.Service.Logging
{
    public sealed class ServerLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(string categoryName)
        {
            return new ServerLogger();
        }

        public void Dispose()
        {
            
        }
    }
}
