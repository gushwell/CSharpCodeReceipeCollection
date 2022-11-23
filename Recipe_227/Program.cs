using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

var workers = new[] { new Worker(), new Worker(), new Worker() };
var tasks = workers.Select(x => Task.Run(() => x.DoWork()))
                   .ToArray();
Task.WaitAll(tasks);
Console.WriteLine(Worker.Result);

public class Worker
{
    private const int _maxloop = 100;
    public static int Result = 0;

    public void DoWork()
    {
        for (int i = 0; i < _maxloop; i++)
        {
            UseResource();
            Thread.Sleep(5);
        }
    }

    // ここで複数のTaskが同じフィールドにアクセス
    private void UseResource()
    {
        // Result += 10を排他的に実行
        Interlocked.Add(ref Result, 10);
    }
}