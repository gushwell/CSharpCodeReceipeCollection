using System;
using System.Collections.Generic;

// 利用例
var list = new List<Time> 
{
    new Time(13, 34, 0),
    new Time(21, 51, 5), 
    new Time(8, 16, 21), 
    new Time(8, 23, 59), 
};
list.Sort();
foreach (var tm in list)  
{
    Console.WriteLine($"{tm.Hour}:{tm.Minute}:{tm.Second}");
}

// IComparable<T>を実装したクラス
public readonly struct Time: IComparable<Time>
{
    public int Hour { get; }
    public int Minute { get; }
    public int Second { get; }

    public Time(int hour, int minute = 0, int second = 0)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    private int ToInt32() => Hour * 10000 + Minute * 100 + Second;

    // IComparableの実装 
    // 通常はジェネリック型ではない IComparable.CompareToも実装する
    public int CompareTo(object obj)
    {
        if (obj is Time tm)
            return this.CompareTo(tm);
        else
            throw new ArgumentException("引数はTime型ではありません");
    }

    // IComparable<T>の実装
    public int CompareTo(Time obj) => 
        this.ToInt32().CompareTo(obj.ToInt32());
}