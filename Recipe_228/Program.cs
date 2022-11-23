using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

ConcurrentDictionary<string, Lake> Cities = new();

var lakes = new Lake[]
{
    new Lake { Name = "サロマ湖", Place = "北海道", Area = 151.59 },
    new Lake { Name = "猪苗代湖", Place = "福島県", Area = 103.24 },
    new Lake { Name = "霞ヶ浦", Place = "茨城県", Area = 168.10 },
    new Lake { Name = "浜名湖", Place = "静岡県", Area = 64.91 },
    new Lake { Name = "琵琶湖", Place = "滋賀県", Area = 669.26 },
    new Lake { Name = "宍道湖", Place = "島根県", Area = 79.24 },
    new Lake { Name = "池田湖", Place = "鹿児島県", Area = 10.91 },
};

await Task.WhenAll(
    Task.Run(() => TryAddLakes(lakes, 1)),
    Task.Run(() => TryAddLakes(lakes, 2))
);

void TryAddLakes(Lake[] lakes, int id)
{
    foreach (var lake in lakes)
    {
        if (Cities.TryAdd(lake.Name, lake))
        {
            Console.WriteLine($"TaskId={id}, 成功 {lake.Name}.");
        }
        else
        {
            Console.WriteLine($"TaskId={id}, 失敗 {lake.Name}, すでに追加済み");
        }
    }
}

class Lake
{
    public string Name { get; init; }
    public string Place { get; init; }
    public double Area { get; init; }
}
