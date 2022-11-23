using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace Gihyo
{
	class Program
	{
		static async Task Main(string[] args) =>
			await CreateHostBuilder(args).Build().RunAsync();

		private static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder()
				.ConfigureAppConfiguration((context, config) =>
				{
					// CreateDefaultBuilderでappsettings.configの設定済み。
					// 特別な処理の時だけ、ここに記述する。
				})
				.ConfigureLogging((context, logging) =>
				{
					// CreateDefaultBuilderでコンソール、デバッグ、およびイベントソース出力に記録するように 
					// ILoggerFactoryを構成済み。
					// 規定値を変更したいときだけここに記述する
				})
				.ConfigureServices((context, services) =>
				{
					new Startup(context.Configuration).ConfigureServices(services);
				});
	}
}