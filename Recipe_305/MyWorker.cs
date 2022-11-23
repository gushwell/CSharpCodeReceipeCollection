using System;
using System.Collections.Generic;
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
            using (var transaction = _context.Database.BeginTransaction())
            {
                try
                {
                    await InsertDataA();
                    await InsertDataB();
                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                Display();
            }
        }

        private async Task InsertDataA()
        {
            _context.Novels.AddRange(new Novel[] {
                new Novel { Title = "吾輩は猫である", Published = 1906 },
                new Novel { Title = "坊ちゃん", Published = 1907 },
                new Novel { Title = "明暗", Published = 1917 },
            });
            await _context.SaveChangesAsync();
        }

        private async Task InsertDataB()
        {
            _context.Novels.AddRange(new Novel[] {
                new Novel { Title = "星を継ぐもの", Published = 1977, Category = Category.SF },
                new Novel { Title = "夏への扉", Published = 1956, Category = Category.SF }
            });
            await _context.SaveChangesAsync();
        }

        public void Display()
        {
            foreach (var novel in _context.Novels)
            {
                Console.WriteLine($"{novel.Title} {novel.Published} {novel.Category}");
            }
        }

    }
}