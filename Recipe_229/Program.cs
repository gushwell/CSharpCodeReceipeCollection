using System;
using System.Threading;
using System.Threading.Tasks;

// IProgress<T> インターフェイスにしないと、利用できない
IProgress<int> p = new Progress<int>(progress => 
{
    // 通知を受け取り進捗状況を表示する
    Console.WriteLine("Step: {0}", progress);
});
var worker = new MyWorker(p);
await worker.ExecuteAsync(10);

// MyWorkerは進捗状況を通知できる
class MyWorker
{
    private IProgress<int> _progress;
    public MyWorker(IProgress<int> progress)
    {
        _progress = progress;
    }

    public async Task ExecuteAsync(int count)
    {
        await Task.Run(async () =>
        {
            for (int i = 0; i < count; i++)
            {
                await Task.Delay(100);
                // 進捗状況を通知
                _progress.Report(i);
            }
        });
    }
}