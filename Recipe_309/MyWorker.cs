using System;
using System.Linq;
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
            var users = await _context.Users
                .Where(x => x.Name == "gushwell")
                .ToListAsync();
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Name} {user.Email}");
            }
        }
    }
}