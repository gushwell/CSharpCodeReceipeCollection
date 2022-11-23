using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace Gihyo
{
	class Program
	{
		static readonly HttpClient _client = new HttpClient();

		static async Task Main()
		{
			var url = "https://gihyo.jp/assets/files/book/2019/978-4-297-10458-0/download/sample.zip";
			await DownloadFileAsync(url, "sample.zip");
		}
		static async Task DownloadFileAsync(string url, string downloadFilepath)
		{
			using (var outstream = File.Open(downloadFilepath, FileMode.Create, FileAccess.Write))
			using (var instream = await _client.GetStreamAsync(url))
			{
				instream.CopyTo(outstream);
			}
		}
	}
}
