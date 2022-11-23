using System;
using System.Diagnostics;

// 処理開始
var stopWatch =  Stopwatch.StartNew();
// ここで何らかの処理
Console.WriteLine($"stopWatch.IsRunning: {stopWatch.IsRunning}");
System.Threading.Thread.Sleep(1000);  
// 処理終了
stopWatch.Stop();
Console.WriteLine($"stopWatch.IsRunning: {stopWatch.IsRunning}");
TimeSpan elapsedTime = stopWatch.Elapsed;
Console.WriteLine(@"{0:G}", elapsedTime);
System.Threading.Thread.Sleep(5000);  
// 再帰動
stopWatch.Start();
Console.WriteLine($"stopWatch.IsRunning: {stopWatch.IsRunning}");
System.Threading.Thread.Sleep(2000);  
// 処理終了
stopWatch.Stop();
Console.WriteLine($"stopWatch.IsRunning: {stopWatch.IsRunning}");
TimeSpan elapsedTime2 = stopWatch.Elapsed;
Console.WriteLine(@"{0:G}", elapsedTime2);
