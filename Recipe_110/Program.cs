using System;

// 利用例
var point = new Point(10, 20);
Console.WriteLine(point.ToString());


// 構造体の定義例
public readonly struct Point
{
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public int X { get; }
    public int Y { get; }

    public override string ToString()
    {
        return $"({X},{Y})";
    }
}
