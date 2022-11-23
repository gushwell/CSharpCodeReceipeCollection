using System;
using System.Linq;

{
    var list = new[] 
    {
        // { 選手の名前, 試投数, 成功数 }のリスト（匿名オブジェクトを利用）
        new { Name = "武田", Attempts = 20, Success = 10 },
        new { Name = "町田", Attempts = 17, Success = 11 },
        new { Name = "文挾", Attempts = 22, Success = 18 },
        new { Name = "高山", Attempts = 21, Success = 12 },
    };

    var max = list.Max(x => x.Success);
    Console.WriteLine(max);

    var min = list.Min(x => x.Success);
    Console.WriteLine(min);
}


// 以下、発展で示したコード
{
    var list = new[]
    {
        // { 選手の名前, 試投数, 成功数 }のリスト（匿名オブジェクトを利用）
        new { Name = "武田", Attempts = 20, Success = 10 },
        new { Name = "町田", Attempts = 17, Success = 11 },
        new { Name = "文挾", Attempts = 22, Success = 18 },
        new { Name = "高山", Attempts = 21, Success = 12 },
    };

    var max = list.Max(x => (double)x.Success / x.Attempts);
    Console.WriteLine(max);

    var min = list.Min(x => (double)x.Success / x.Attempts);
    Console.WriteLine(min);
}