using System;

var today = DateTime.Today;
var dayOfYear = today.DayOfYear;
Console.WriteLine($"今日は{today.Year}年の1月1日から数えて{dayOfYear}日目です");
