using System;
using System.Threading.Tasks;
using System.Net.Http;

namespace Gihyo
{

	public class MyWorker : IConsoleWorker
	{
		private readonly IHttpClientFactory _clientFactory;

		// コンストラクターの引数にIHttpClientFactoryオブジェクトが渡される
		public MyWorker(IHttpClientFactory clientFactory)
		{
			_clientFactory = clientFactory;
		}

		public async Task Run()
		{
			// IHttpClientFactoryからHttpClientオブジェクトを取得
			var client = _clientFactory.CreateClient();
			var url = "http://echo.jsontest.com/key/123/value/Hello";
			var result = await client.GetStringAsync(url);
			Console.WriteLine(result);
		}
	}
}