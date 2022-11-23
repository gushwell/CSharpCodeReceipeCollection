using System;

// 列挙型から文字列へ
var name = Enum.GetName(typeof(DayOfWeek), DayOfWeek.Sunday);
Console.WriteLine(name);

// 文字列から列挙型へ
if (Enum.TryParse<DayOfWeek>(name, out var week)) 
{
    if (week == DayOfWeek.Sunday)
        Console.WriteLine("Sunday");
}

// ToStringメソッドでも文字列かできる
string text = DayOfWeek.Sunday.ToString();
Console.WriteLine(text);
