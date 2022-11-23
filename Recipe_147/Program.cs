using System;
using System.Linq;

var books = new[] 
{
    new { Title = "マネジメント", Category = "Business" },
    new { Title = "ファウスト", Category = "Novel"},
    new { Title = "生命とは何か", Category = "Science"},
    new { Title = "相対論の意味", Category = "Science"},
    new { Title = "レ・ミゼラブル", Category = "Novel"},
    new { Title = "タイムマシン", Category = "Novel"},
};
var lookup = books.ToLookup(x => x.Category, x => x.Title);
foreach (var g in lookup) 
{
    Console.WriteLine($"#{g.Key}");
    foreach (var title in g) 
    {
        Console.WriteLine($" {title}");
    }
}
