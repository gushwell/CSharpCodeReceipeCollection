using System;
using System.Linq;

var array = new[]
{
    new { Name = "武田",
          FavoriteFood = new [] { "カレー", "寿司" } },
    new { Name = "斎藤",
          FavoriteFood = new [] { "寿司", "餃子", "唐揚げ" } },
    new { Name = "町田",
          FavoriteFood = new [] { "ラーメン", "天ぷら" } },
    new { Name = "文挾",
          FavoriteFood = new [] { "餃子", "焼肉", "寿司" } },
};
var foods = array.SelectMany(x => x.FavoriteFood)
                 .Distinct();
Console.WriteLine(string.Join(',', foods));

// 以下、発展で示したコード
var query = array.SelectMany(x => x.FavoriteFood,
    (o, food) => new { o.Name, Food = food }
);
foreach (var item in query)
{
    Console.WriteLine($"{item.Name} {item.Food}");
}
