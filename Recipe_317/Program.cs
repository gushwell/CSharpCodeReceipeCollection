using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Gihyo
{
	class Program
	{
		static readonly HttpClient _client = new HttpClient();
		static async Task Main(string[] args)
		{
			_client.DefaultRequestHeaders.Accept.Add(
				new MediaTypeWithQualityHeaderValue("application/json"));
			var url = "http://echo.jsontest.com/key/123/value/Hello";
			var result = await _client.GetStringAsync(url);
			Console.WriteLine(result);
		}
	}
}
