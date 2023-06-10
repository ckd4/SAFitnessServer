using System.Text;

namespace Server.Presentation.API.Logging
{
    public sealed class ServerLogger : ILogger
    {
        public IDisposable BeginScope<TState>(TState state)
        {
            return null;
        }
        public bool IsEnabled(LogLevel logLevel)
        {
            return true;
        }
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            switch (logLevel)
            {
                case LogLevel.Trace: Console.ForegroundColor = ConsoleColor.White; break;
                case LogLevel.Debug: Console.ForegroundColor = ConsoleColor.Blue; break;
                case LogLevel.Information: Console.ForegroundColor = ConsoleColor.Green; break;
                case LogLevel.Warning: Console.ForegroundColor = ConsoleColor.Yellow; break;
                case LogLevel.Error: Console.ForegroundColor = ConsoleColor.Red; break;
                case LogLevel.Critical: Console.ForegroundColor = ConsoleColor.DarkRed; break;
            }
            Console.Write($" \x1b[1m{logLevel.ToString().ToUpper()[0..3]}");
            Console.ResetColor();
            Console.Write($" | {DateTime.Now.Hour.ToString().PadLeft(2, '0')}:");
            Console.Write($"{DateTime.Now.Minute.ToString().PadLeft(2, '0')}:");
            Console.Write($"{DateTime.Now.Second.ToString().PadLeft(2, '0')}\x1b[0m | ");
            Console.WriteLine($"{formatter(state, exception)}");
        }
    }
}
