using System;
using System.Threading.Tasks;
using System.Collections.Generic;
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
            // すべてのデータ(行)の読み込み
            var allPosts = await _context.Posts.ToListAsync();
            foreach (var post in allPosts)
            {
                Console.WriteLine($"{post.PostId} {post.Message} {post.SentTime}");
            }
            Console.WriteLine("---");
            // 単一のエンティティの読み込み
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Name == "gushwell");
            Console.WriteLine($"{user.UserId} {user.Name} {user.Email}");
            Console.WriteLine("---");
            // フィルター処理 （条件に一致した行を取り出す）
            var Posts = await _context.Posts.Where(x => x.UserId == 2).ToListAsync();
            foreach (var post in Posts)
            {
                Console.WriteLine($"{post.UserId} {post.Message}");
            }
        }
    }
}