using System;
using System.Collections.Generic;

try
{
    ThrowExceptionSample();
}
catch (Exception e)
{
    foreach (var ex in GetAllExceptions(e))
    {
        Console.WriteLine(ex.GetType());
    }
}

static IEnumerable<Exception> GetAllExceptions(Exception e)
{
    if (e == null)
    {
        yield break;
    }
    yield return e;
    foreach (var inex in GetAllExceptions(e.InnerException))
    {
        yield return inex;
    }
}

// GetAllExceptionsメソッドのテスト用の例外を発生させる
static void ThrowExceptionSample()
{
    try
    {
        try
        {
            try
            {
                throw new NullReferenceException();
            }
            catch (Exception e)
            {
                throw new NotImplementedException("未実装", e);
            }
        }
        catch (Exception e)
        {
            throw new NotSupportedException("未サポート", e);
        }
    }
    catch (Exception e)
    {
        throw new ApplicationException("アプリ例外", e);
    }
}
