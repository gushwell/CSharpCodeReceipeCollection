using System;

static void DynamicSample(dynamic obj)
{
    obj.Execute("Hello");
}

DynamicSample(new ExampleClass1());
DynamicSample(new ExampleClass2());

class ExampleClass1
{
    public void Execute(string msg) => Console.WriteLine($"<{msg}>");
}

class ExampleClass2
{
    public void Execute(string msg) => Console.WriteLine($"[{msg}]");
}
