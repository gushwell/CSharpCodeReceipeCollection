using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Gihyo
{
    public class MyWorker : IConsoleWorker
    {
        private readonly ILogger _logger;
        
        public MyWorker(ILogger<MyWorker> logger)
        {
            _logger = logger;
        }

        public Task Run()
        {
            _logger.LogTrace("LogTrace Example message");
            _logger.LogDebug("LogDebug Example message");
            _logger.LogInformation("LogInformation Example message");
            _logger.LogWarning("LogWarning Example message");
            _logger.LogError("LogError Example message");
            _logger.LogCritical("LogCritical Example message");
            return Task.CompletedTask;
        }
    }
}