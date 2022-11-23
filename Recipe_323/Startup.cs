using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace Gihyo
{

	// ASP.NET CoreのStartup.csに似せたクラス
	// ConfigureServicesメソッドで利用するサービスを登録する（DIを利用できる)
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddHttpClient();
			services.AddSingleton<IConsoleWorker, MyWorker>();
			services.AddHostedService<ConsoleService>();
		}
	}
}


