using System;
using System.ComponentModel;

class Program
{
    static void Main()
    {
        var bw = new BackgroundWorker();
        bw.WorkerSupportsCancellation = true;
        bw.WorkerReportsProgress = true;
        bw.DoWork += DoWork;
        bw.ProgressChanged += ProgressChanged;
        bw.RunWorkerCompleted += WorkerCompleted;
        bw.RunWorkerAsync();
        while (bw.IsBusy)
        {
            if (Console.KeyAvailable)
            {
                bw.CancelAsync();
                break;
            }
            Console.Write("F");
            System.Threading.Thread.Sleep(600);
        }
        // 確実にWorkerCompletedが呼ばれるように少し待つ。
        // コンソールアプリなので、そうしないとその前にプログラムが終了してしまう。
        System.Threading.Thread.Sleep(500);
        Console.WriteLine("end");
    }

    private static void DoWork(object sender, DoWorkEventArgs e)
    {
        var bw = sender as BackgroundWorker;
        for (int i = 1; i <= 20; i++)
        {
            if (bw.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
            System.Threading.Thread.Sleep(350);
            // ProgressChangedイベントを発生させる
            bw.ReportProgress(i, null);
        }
    }

    private static void WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        if (e.Cancelled)
            Console.WriteLine("\nCaneled");
        else
            Console.WriteLine("\nComplete");
    }

    private static void ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
        Console.Write("b");
    }
}