namespace Server.Presentation.API.Logging
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
