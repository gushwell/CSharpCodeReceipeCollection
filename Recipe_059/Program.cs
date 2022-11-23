using System;


// 曜日を取得する
var now = new DateTime(2020, 12, 27);
var dayofweek = now.DayOfWeek;
Console.WriteLine(dayofweek);
if (dayofweek == DayOfWeek.Sunday)
    Console.WriteLine("日曜日です");
