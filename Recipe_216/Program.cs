using System;
using System.Threading.Tasks;

// 2秒かかるタスクを起動
var task = Task.Run(() =>
{
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("Task End");
});

// 最大1秒待つ
task.Wait(1000);
// taskは終わっていないので、completedはfalseになる
bool completed = task.IsCompleted;
Console.WriteLine($"IsCompleted: {completed}, Status: {task.Status}");
if (!completed)
    // タイムアウトが発生するが、タスクそのものがキャンセルされるわけではない
    Console.WriteLine("Timeout");
Console.ReadLine();
