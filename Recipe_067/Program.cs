using System;

// 日付文字列をDateTime型に変換する
var s1 = "2020/05/01";
if (DateTime.TryParse(s1, out var date1)) 
{
    Console.WriteLine(date1);
}

var s2 = "2020/08/25 23:05:40";
if (DateTime.TryParse(s2, out var date2)) 
{
    Console.WriteLine(date2);
}

var s3 = "令和3年12月18日";
if (DateTime.TryParse(s3, out var date3)) 
{
    Console.WriteLine(date3);
}
