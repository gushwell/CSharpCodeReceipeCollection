using System;

// 定義されている値か調べる
var exists7 = Enum.IsDefined(typeof(DayOfWeek), 7);
Console.WriteLine($"7: 存在していま" + (exists7 ? "す" : "せん"));

var exists0 = Enum.IsDefined(typeof(DayOfWeek), 0);
Console.WriteLine($"0: 存在していま" + (exists0 ? "す" : "せん"));

var existsSunday = Enum.IsDefined(typeof(DayOfWeek), "Sunday");
Console.WriteLine($"Sunday: 存在していま" + (existsSunday ? "す" : "せん"));
