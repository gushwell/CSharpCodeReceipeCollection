using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using System.Net;
using System.Net.Http.Headers;

namespace Gihyo
{
	class Program
	{
		static readonly HttpClient _client = new HttpClient();

		static async Task Main(string[] args)
		{
			_client.DefaultRequestHeaders.Accept.Clear();
			_client.DefaultRequestHeaders.Accept.Add(
				new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
			_client.DefaultRequestHeaders.Add("User-Agent", "gushwell-example");
			var url = "https://api.github.com/orgs/dotnet/repos";
			// HTTP GET でAPIを呼び出す
			var request = new HttpRequestMessage(HttpMethod.Get, url);
			var response = await _client.SendAsync(request);
			if (response.StatusCode == HttpStatusCode.OK)
			{
				// レスポンスからStreamを得る
				var stream = await response.Content.ReadAsStreamAsync();
				// StreamをJSONデシリアライズする
				var repositories = await JsonSerializer.DeserializeAsync<List<Repository>>(stream);
				//　GitHubのリポジトリ名にaspnetを含むものを取り出す
				foreach (var repo in repositories.Where(x => x.Name.Contains("aspnet")))
				{
					Console.WriteLine($"Name:{repo.Name}");
					Console.WriteLine($"GitHubHomeUrl:{repo.GitHubHomeUrl}");
					Console.WriteLine($"Homepage:{repo.Homepage}");
					Console.WriteLine($"Watchers:{repo.Watchers}");
				}
			}
		}
	}

	public class Repository
	{
		[JsonPropertyName("name")]
		public string Name { get; set; }

		[JsonPropertyName("description")]
		public string Description { get; set; }

		[JsonPropertyName("html_url")]
		public Uri GitHubHomeUrl { get; set; }

		[JsonPropertyName("homepage")]
		public Uri Homepage { get; set; }

		[JsonPropertyName("watchers")]
		public int Watchers { get; set; }
	}
}