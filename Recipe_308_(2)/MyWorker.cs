using System;
using System.Collections.Generic;
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
            var user1 = new User
            {
                Name = "gushwell",
                Email = "gushwell@example.com"
            };
            _context.Users.Add(user1);
            var user2 = new User
            {
                Name = "gihyo",
                Email = "gihyo@example.com"
            };
            _context.Users.Add(user2);
            await _context.SaveChangesAsync();
            Console.WriteLine($"user1.UserId: {user1.UserId}, user2.UserId: {user2.UserId}");
            _context.Posts.Add(new Post
            {
                User = user1,
                Message = "初めまして、よろしくおねがいします",
                SentTime = DateTime.Now,
            });
            await _context.SaveChangesAsync();
            _context.Posts.Add(new Post
            {
                UserId = user2.UserId,
                Message = "こちらこそよろしく！",
                SentTime = DateTime.Now,
            });
            await _context.SaveChangesAsync();
        }
    }
}