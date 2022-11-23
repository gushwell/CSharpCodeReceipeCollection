using System;
using System.Security.Cryptography;

// ランダムな値を使う
// Nextメソッドの例
{
    var rnd = new Random();
    for (int i = 0; i < 5; i++) 
    {
        var n = rnd.Next(0, 10);
        Console.Write($"{n}, ");
    }
    Console.WriteLine();
}

// NextDoubleの例
{
    var rnd = new Random();
    for (int i = 0; i < 5; i++) 
    {
        var n = rnd.NextDouble();
        Console.WriteLine(n);
    }
}

// 以下、発展で示したコード
{
    for (var i = 0; i < 5; i++) 
    {
        var n = RandomNumberGenerator.GetInt32(0, 10);
        Console.Write($"{n}, ");
    }
    Console.WriteLine();
}