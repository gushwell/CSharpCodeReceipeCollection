using System;
using System.Linq;

var list = new[] 
{
    new Player { Name = "武田", Attempts = 19, Success = 10 },
    new Player { Name = "町田", Attempts = 17, Success = 11 },
    new Player { Name = "文挾", Attempts = 22, Success = 18 },
    new Player { Name = "高山", Attempts = 21, Success = 12 },
};
var task = new MyTask();
list.AsParallel()
    .ForAll(o => task.Execute(o));

foreach (var p in list) 
{
    Console.WriteLine($"{p.SuccessRate:#.00}");
}
Console.WriteLine($"Max = {task.MaxRate:#.00}");

// Playerクラス　MyTaskクラスで利用
class Player 
{
    public string Name { get; set; }
    public int Attempts { get; set; }
    public int Success { get; set; }
    public double SuccessRate { get; set; }
}

// MyTaskクラス
class MyTask 
{
    private static object _lockobj = new Object();

    public double MaxRate { get; set; } = -1;

    // Executeは同時に並列で実行されるため、
    // MaxRateを更新する際は、lock構文で排他処理をする
    public void Execute(Player player) 
    {
        player.SuccessRate = (player.Success * 100.0) / player.Attempts;
        lock (_lockobj) 
        {
            if (MaxRate < player.SuccessRate)
                MaxRate = player.SuccessRate;
        }
    }
}