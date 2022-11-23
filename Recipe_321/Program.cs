using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;

namespace Gihyo
{
	class Program
	{
		static readonly HttpClient _client = new HttpClient();

		static async Task Main()
		{
			var param = new Dictionary<string, string>
			{
				["keyword"] = "network",
				["encode"] = "UTF-8",
				["maxsize"] = "20"
			};
			using (var content = new FormUrlEncodedContent(param))
			{
				var response = await _client.PostAsync("http://example.com/", content);
				Console.WriteLine(await response.Content.ReadAsStringAsync());
				// ...
			}
		}
	}
}
