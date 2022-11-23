using System;
using System.Globalization;

var cultureInfo = new CultureInfo("ja-JP");
cultureInfo.DateTimeFormat.Calendar = new JapaneseCalendar();

var date = new DateTime(2019, 5, 1, 18, 5, 6, 140);
var str1 = date.ToString("ggy年M月d日", cultureInfo);
Console.WriteLine(str1);

var date2 = new DateTime(2021, 3, 23);
var str2 = date2.ToString("ggyy年MM月dd日", cultureInfo);
Console.WriteLine(str2);
