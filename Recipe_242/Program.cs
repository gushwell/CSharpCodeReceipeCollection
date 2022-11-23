using System;
using System.Reflection;
using System.Diagnostics;

Type type = typeof(MySample);
var method = type.GetMethod(nameof(MySample.Output));
var attrs = method.GetCustomAttributes();
foreach (var attr in attrs)
    Console.WriteLine(attr);

public class MySample
{
    [DebuggerStepThrough()]
    [Conditional("ShowTrace")]
    public void Output(double num)
    {
        Console.Write($"num = {num}");
    }
}