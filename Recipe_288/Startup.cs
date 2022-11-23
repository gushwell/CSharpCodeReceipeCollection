using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;


// ASP.NET CoreのStartup.csに似せたクラス
// ConfigureServicesメソッドで利用するサービスを登録する（DIを利用できる)る)
public class Startup
{
	public Startup(IConfiguration configuration)
	{
		Configuration = configuration;
	}

	public IConfiguration Configuration { get; }
	public void ConfigureServices(IServiceCollection services)
	{
		services.AddSingleton<IConsoleWorker, MyWorker>();
		services.AddHostedService<ConsoleService>();
	}
}



