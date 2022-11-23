using System;
using System.Threading;
using System.Threading.Tasks;

var worker = new Worker();
var task = Task.Run(() => worker.DoWork());
Console.WriteLine("メインスレッド: Taskを開始");

while (task.Status != TaskStatus.Running)
    ;

Thread.Sleep(500);
worker.RequestStop();

task.Wait();
Console.WriteLine("メインスレッド: Taskが終了");

public class Worker
{
    private volatile bool _shouldStop;

    public void DoWork()
    {
        bool work = false;
        while (!_shouldStop)
        {
            // _shouldStopがtrueになるまで、ここでなんらかの処理
            work = !work;
        }
        Console.WriteLine("DoWork 正常に終了します");
    }

    public void RequestStop() => _shouldStop = true;
}