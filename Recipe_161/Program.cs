using System;
using System.Linq;

var list = new[]
{
    new { Name = "武田", Attempts = 20, Success = 10 },
    new { Name = "町田", Attempts = 17, Success = 11 },
    new { Name = "文挾", Attempts = 22, Success = 16 },
	new { Name = "高山", Attempts = 21, Success = 12 },
	new { Name = "古澤", Attempts = 20, Success = 15 },
};
var top2 = list.Where(x => x.Attempts >= 20)
            .Select(x => new
            {
                x.Name,
                Rate = (double)x.Success / x.Attempts
            })
            .OrderByDescending(x => x.Rate)
            .Take(2);
foreach (var item in top2)
{
    Console.WriteLine($"{item.Name} {item.Rate:0.00}");
}