using System;
using System.Linq;

var books = new[] 
{
    new { Title = "マネジメント", Category = Category.Business },
    new { Title = "ファウスト", Category = Category.Novel},
    new { Title = "生命とは何か", Category = Category.Science},
    new { Title = "相対論の意味", Category = Category.Science},
    new { Title = "レ・ミゼラブル", Category = Category.Novel},
    new { Title = "タイムマシン", Category = Category.Novel},
};
// Categoryでグルーピングする
var groups = books.GroupBy(x => x.Category);
foreach (var g in groups) 
{
    Console.WriteLine($"#{g.Key}");
    foreach (var b in g) 
    {
        Console.WriteLine($" {b.Title}");
    }
}

public enum Category 
{
    Business,
    Novel,
    Science,
}