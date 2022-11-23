using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Gihyo
{

    public class MyWorker : IConsoleWorker
    {
        private readonly ILogger _logger;
        public MyWorker(ILogger<MyWorker> logger)
        {
            _logger = logger;
        }

        public Task Run()
        {
            var title = "吾輩は猫である";
            var author = "夏目漱石";
            _logger.LogTrace("Create Book {BookTitle} {BookAuthor}", title, author);
            return Task.CompletedTask;
        }
    }
}