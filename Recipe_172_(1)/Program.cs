using System;

Execute();

// 条件演算子でthrow式
static void ExampleMethod1(string[] args)
{
    var arg = (args != null && args.Length >= 1)
                ? args[0] : throw new ArgumentException();
    // ...
}

static void Execute()
{
    try
    {
        ExampleMethod1(new string[] { });
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    Console.WriteLine("-----");
    try
    {
        ExampleMethod1(new string[] { null });
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}

