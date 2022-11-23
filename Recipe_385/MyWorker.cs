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
			var value1 = _configuration["BaseUrl"];
			Console.WriteLine(value1);
			var value2 = _configuration["Message"];
			Console.WriteLine(value2);
			return Task.CompletedTask;
		}
	}

	public class MyAppSettings
	{
		public string Version { get; set; }
		public string TempDir { get; set; }
		public bool Verbose { get; set; }
	}
}

