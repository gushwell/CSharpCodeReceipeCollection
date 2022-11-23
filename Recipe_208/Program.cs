using System;

var obj = new SampleClass();
obj.Label = null;
Console.WriteLine(obj.Label);

public class SampleClass
{
    private string _label;

    public string Label
    {
        get => _label;
        set => _label = value ?? "Default label";
    }
}
