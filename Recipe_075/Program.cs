using System;

// 配列の要素を同じ値で埋める
var array = new int[10];
Array.Fill(array, -1);
foreach (var n in array)
{
    Console.Write($"{n} ");
}
Console.WriteLine();
