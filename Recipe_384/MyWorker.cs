using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Gihyo
{
	public class MyWorker : IConsoleWorker
	{
		private readonly IConfiguration _configuration;

		public MyWorker(IConfiguration configuration)
		{
			_configuration = configuration;
		}
		
		public Task Run()
		{
			var value = _configuration["MySettings:AppName"];
			Console.WriteLine(value);
			var settings = new MyAppSettings();
			// MyAppSettingsにバインドする
			_configuration.GetSection("MySettings").Bind(settings);
			Console.WriteLine($"{settings.Version}|{settings.AppName}|{settings.Verbose}");
			return Task.CompletedTask;
		}
	}

	public class MyAppSettings
	{
		public string Version { get; set; }
		public string AppName { get; set; }
		public bool Verbose { get; set; }
	}
}
