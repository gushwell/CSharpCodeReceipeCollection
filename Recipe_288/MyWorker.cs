using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using ZLogger;


public class MyWorker : IConsoleWorker
{
	private readonly ILogger _logger;
	public MyWorker(ILogger<MyWorker> logger)
	{
		_logger = logger;
	}

	public Task Run()
	{
		_logger.ZLogTrace("LogTrace Example message");
		_logger.ZLogDebug("LogDebug Example message");
		_logger.ZLogInformation("LogInformation Example message");
		_logger.ZLogWarning("LogWarning Example message");
		_logger.ZLogError("LogError Example message");
		_logger.ZLogCritical("LogCritical Example message");
		return Task.CompletedTask;
	}
}
