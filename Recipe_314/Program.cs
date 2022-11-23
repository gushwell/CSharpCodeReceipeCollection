using System;
//using System.Net;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;

namespace Gihyo
{
	class Program
	{
		static readonly HttpClient _client = new HttpClient();
		static async Task Main()
		{
			// URLを指定しWebページ(HTML)を取得する
			var response = await _client.GetStringAsync("https://gihyo.jp/dp");
			foreach (var s in response.Split('\n').Take(10))
				Console.WriteLine(s);
		}
	}
}
