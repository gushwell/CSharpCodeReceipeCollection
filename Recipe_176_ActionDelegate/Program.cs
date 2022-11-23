using System;

Repeat(3, n => Console.WriteLine($"{n + 1}回目"));

// Actionデリゲートを受け取るメソッド
static void Repeat(int n, Action<int> action)
{
    for (var i = 0; i < n; i++)
        action(i);
}
