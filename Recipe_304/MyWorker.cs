using System;
using System.Threading.Tasks;
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
            var message = "明日の勉強会参加させていただきます";
            var sentTime = "2020/11/22 12:05:07";
            var userId = 1;
            _context.Database
                 .ExecuteSqlInterpolated($"INSERT INTO Posts (Message, SentTime, UserId) VALUES ({message},{sentTime},{userId})");
            var Posts = await _context.Posts
                .FromSqlInterpolated($"SELECT * FROM Posts WHERE UserId = {userId}")
                .ToListAsync();
            foreach (var post in Posts)
            {
                Console.WriteLine($"{post.UserId} {post.Message} {post.SentTime}");
            }
        }
    }
}