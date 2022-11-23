using System;
using System.Threading.Tasks;

// タスクをふたつ起動する
var tasks = new Task[2];
tasks[0] = Task.Run(async () =>
{
    await Task.Delay(3000);
    Console.WriteLine("Task 1");
});
tasks[1] = Task.Run(async () =>
{
    await Task.Delay(2000);
    Console.WriteLine("Task 2");
});
// ふたつのTaskが完了するまで待機する
await Task.WhenAll(tasks);
Console.WriteLine("End");
