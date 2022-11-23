using System;
using System.IO;

using (var obj = new DisposableType())
{
    // ここでobjを使った処理を記述
}


// IDisposableインターフェイスの実装例
public class DisposableType : IDisposable
{
    private bool _disposed;  // 破棄済みかどうかを示す
    private Stream _stream;

    public DisposableType()
    {
        _stream = new FileStream(@"example.txt", FileMode.Open);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (_disposed)
            return;
        if (disposing)
            _stream.Dispose();
        _disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~DisposableType() => Dispose(false);
}

// 以下、発展で示したコード
public class DelivedType : DisposableType
{
    bool _disposed = false;
    private Stream _stream;
    public DelivedType(string path)
    {
        _stream = File.Open(path, FileMode.Open);
    }

    ~DelivedType() => Dispose(false);

    // Disposeメソッドをオーバーライドする
    protected override void Dispose(bool disposing)
    {
        if (_disposed)
            return;
        if (disposing)
            _stream.Dispose();
        _disposed = true;
        base.Dispose(disposing);  // 基底クラスのリソースを破棄する
    }
}

