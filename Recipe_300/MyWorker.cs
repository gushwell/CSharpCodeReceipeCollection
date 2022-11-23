using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Gihyo
{

    public class MyWorker : IConsoleWorker
    {
        private readonly ExampleDbContext _context;
        public MyWorker(ExampleDbContext context)
        {
            _context = context;
        }

        public async Task Run()
        {
            // テーブルから該当する行をひとつだけ取り出す（関連データもあわせて読み込む）
            var user = await _context.Users
                .Include(n => n.Posts)
                .SingleAsync(x => x.Name == "gushwell");
            Console.WriteLine($"{user.Name}");
            foreach (var post in user.Posts)
            {
                Console.WriteLine($"  {post.Message} {post.SentTime}");
            }
        }
    }
}