using System;
using System.Threading.Tasks;

Console.WriteLine(DateTime.Now);
await Task.Delay(1000);
Console.WriteLine(DateTime.Now);

// 以下　補足で示したコード
await Task.Delay(TimeSpan.FromSeconds(1));
Console.WriteLine(DateTime.Now);
