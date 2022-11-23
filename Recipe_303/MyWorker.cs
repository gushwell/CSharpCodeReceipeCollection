using System;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

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
            await Display();
            // 一度には以下のどちらか片方しか実行できない
            await EntryExample();
            // await AttachExample();
        }

        private async Task EntryExample()
        {
            var user = new User
            {
                UserId = 1,
                Name = "gushwell",
                Email = "gushwell-hide@example.com"
            };
            _context.Entry(user).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            await Display();
        }

        private async Task AttachExample()
        {
            var user = new User
            {
                UserId = 1,
            };
            _context.Attach(user); 
            user.Email = "gushwell@example.jp";
            //.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            await Display();
        }

        private async Task Display()
        {
            var user = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Name == "gushwell");
            Console.WriteLine($"{user.UserId} {user.Name} {user.Email}");
        }
    }
}