using System;
using System.Linq;


var list = new[] {
    new { Name = "武田", Attempts = 20, Success = 10 },
    new { Name = "町田", Attempts = 17, Success = 11 },
    new { Name = "文挾", Attempts = 22, Success = 18 },
    new { Name = "高山", Attempts = 21, Success = 12 },
};
var query = list.AsParallel()
    .AsOrdered()
    .WithDegreeOfParallelism(4)
    .Select(x => new
    {
        x.Name,
        SuccessRate = (x.Success * 100.0) / x.Attempts
    });
foreach (var item in query)
{
    Console.WriteLine($"{item.Name}: {item.SuccessRate:0.0}%");
}

