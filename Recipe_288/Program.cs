using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ZLogger;
using Cysharp.Text;

class Program
{
	static async Task Main(string[] args) =>
		await CreateHostBuilder(args).Build().RunAsync();

	static Action<ZLoggerOptions> logOption = options =>
	{
		options.PrefixFormatter = (writer, info) =>
			ZString.Utf8Format(writer, "[{0}][{1}]", info.LogLevel,
				info.Timestamp.DateTime.ToLocalTime());
		var prefixFormat = ZString.PrepareUtf8<LogLevel, DateTime>("[{0}][{1}]");
		options.PrefixFormatter = (writer, info) =>
			prefixFormat.FormatTo(ref writer, info.LogLevel,
				info.Timestamp.DateTime.ToLocalTime());
	};

	private static IHostBuilder CreateHostBuilder(string[] args) =>
		Host.CreateDefaultBuilder()
			.ConfigureAppConfiguration((context, config) =>
			{
				// CreateDefaultBuilderでappsettings.configの
				// 設定済み。特別な処理の時だけここに記述する。
			})
			.ConfigureLogging((context, logging) =>
			{
				logging.ClearProviders();
				logging.SetMinimumLevel(LogLevel.Trace);
				logging.AddZLoggerConsole(logOption);
				logging.AddZLoggerFile("example.log", logOption);
				logging.AddZLoggerRollingFile(
					fileNameSelector: (dt, x) => $"logs/{dt.ToLocalTime():yyyy-MM-dd}_{x:000}.log",
					timestampPattern: x => x.ToLocalTime().Date,
					rollSizeKB: 1024,
					logOption);
			})
			.ConfigureServices((context, services) =>
			{
				new Startup(context.Configuration).ConfigureServices(services);
			});
}
