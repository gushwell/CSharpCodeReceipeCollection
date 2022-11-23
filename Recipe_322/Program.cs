using System;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Gihyo {
    class Program {
		static readonly HttpClient _client = new HttpClient();

		static async Task Main()
		{
			var param = new
			{
				totalCount = 10,
				data = new[]
				{
					new
					{
						keyword = "network",
						encode = "UTF-8",
						maxsize = "20"
					}
				}
			};
			// jsonにシリアライズして
			var json = JsonSerializer.Serialize(param);
			// jsonからContentを生成し、
			var content = new StringContent(json, Encoding.UTF8, "application/json");
			// JSONをbody にセットして送信
			var response = await _client.PostAsync("http://example.com/", content);
            // ...
        }
    }
}
