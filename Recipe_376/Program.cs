using System;
using System.Threading;

Console.WriteLine($"{DateTime.Now.ToLongTimeString()}にアプリケーション開始");
// タイマーを1秒後に開始。2秒間隔でDoSomethingを呼び出す
using var timer = new Timer(DoSomething, null, 1000, 2000);
Console.WriteLine("Enterキーを押すとアプリケーションが終了します\n");
Console.ReadLine();
// タイマーを停止
timer.Change(Timeout.Infinite, Timeout.Infinite);
Console.WriteLine("アプリケーションが終了しました。");

static void DoSomething(object arg) =>
    Console.WriteLine(DateTime.Now.ToLongTimeString());
