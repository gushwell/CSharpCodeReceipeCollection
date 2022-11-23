using System;

// イベントの利用例
var obj = new EventSample();
obj.Changed += OnChangedHandler;
obj.Add(1);
obj.Add(4);
obj.Add(6);
obj.Add(7);
obj.Add(2);

// イベントハンドラ
static void OnChangedHandler(Object sender, SampleEventArgs e)
{
    Console.WriteLine($"Total= {e.Total}");
}

// これ以降が、イベントの定義例
class EventSample
{
    // イベントを定義。EventHandler<TEventArgs>型を利用
    public event EventHandler<SampleEventArgs> Changed;

    // イベントハンドラを呼び出す内部メソッド
    private void OnChanged(SampleEventArgs e)
    {
        // Invokeメソッドでイベントハンドラを呼び出す。
        Changed?.Invoke(this, e);
    }

    private int _total = 0;

    public void Add(int n)
    {
        _total += n;
        if (_total % 5 == 0)
        {
            // 5で割り切れたときだけイベントを発生させる 
            var args = new SampleEventArgs { Total = _total };
            OnChanged(args);
        }
    }
}

// イベントハンドラが受け取るパラメーターの型を定義する。
// .NETが用意する EventArgsで代用できれば定義する必要はない
class SampleEventArgs : EventArgs
{
    public int Total { get; set; }
}