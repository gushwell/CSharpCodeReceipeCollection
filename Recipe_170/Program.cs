using System;

try
{
    throw new MyAppException("例外が発生しました");
}
catch (MyAppException e)
{
    Console.WriteLine(e.Message);
}

public class MyAppException : Exception
{
    // パラメーターなしのコンストラクター ー 
    public MyAppException() { }

    // 文字列メッセージを受け取るコンストラクター ー 
    public MyAppException(string message)
        : base(message) { }

    // 文字列メッセージと内部例外を受け取るコンストラクター ー 
    public MyAppException(string message, Exception inner)
        : base(message, inner) { }
}

