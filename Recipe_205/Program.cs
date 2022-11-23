using System;

object obj = 10;
switch (obj)
{
    case int i when i >= 1:
    case short s when s >= 1:
        Console.WriteLine("1以上の整数です");
        break;
    case double d when d >= 1.0:
    case float f when f >= 1.0:
        Console.WriteLine("1以上の浮動小数点数です");
        break;
    default:
        Console.WriteLine("それ以外の値です");
        break;
}
