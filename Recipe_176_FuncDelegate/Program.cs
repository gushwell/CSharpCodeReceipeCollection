using System;
using System.Collections.Generic;

var seq = Generate(5, n => Math.Pow(2, n));
foreach (var x in seq)
{
    Console.WriteLine(x);
}

// Funcデリゲートを受け取るメソッド
static IEnumerable<T> Generate<T>(int n, Func<int, T> generator)
{
    for (int i = 0; i < n; i++)
        yield return generator(i);
}