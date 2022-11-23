using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using log4net;

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
                    logging.ClearProviders();
                    logging.SetMinimumLevel(LogLevel.Trace);
                    logging.AddLog4Net();
                })
                .ConfigureServices((context, services) =>
                {
                    new Startup(context.Configuration).ConfigureServices(services);
                });
    }
}


