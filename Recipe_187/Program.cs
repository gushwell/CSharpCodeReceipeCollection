using System;

var obj = new SampleClass();
obj.Repeat("+", 5);
Console.WriteLine(obj.RepeatCount);

// インターフェイスの定義
public interface IRepeatable
{
    void Repeat(object item, int num);
    int RepeatCount { get; }
}

// インターフェイスの実装
public class SampleClass : IRepeatable
{
    public void Repeat(object item, int num)
    {
        for (var i = 0; i < num; i++)
            Console.Write(item.ToString());
        Console.WriteLine();
        RepeatCount = num;
    }
    public int RepeatCount { get; private set; }
}
