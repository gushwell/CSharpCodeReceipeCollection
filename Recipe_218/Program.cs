using System;
using System.Threading.Tasks;
using System.Threading;

using (var tokenSource = new CancellationTokenSource())
{
    var task = DoWork(tokenSource.Token);
    while (!task.IsCompleted)
    {
        if (Console.KeyAvailable)
        {
            // 何かのキーが押されたらキャンセルする
            tokenSource.Cancel(true);
            break;
        }
        Thread.Sleep(100);
    }
    try 
    {
        await task;
    } 
    catch (OperationCanceledException e) 
    {
        // キャンセルされた
        Console.WriteLine("キャンセルしました");
    }
}

// Taskを起動する
static Task DoWork(CancellationToken cancelToken)
{
    return Task.Run(() =>
    {
        // 100回繰り返すか、キャンセルされるまでループ。
        for (int i = 0; i < 100; i++)
        {
            if (cancelToken.IsCancellationRequested)
                cancelToken.ThrowIfCancellationRequested();
            Console.Write(".");
            System.Threading.Thread.Sleep(200);
        }
    }, cancelToken);
}