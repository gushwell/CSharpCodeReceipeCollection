using System;


// 日付、時刻を様々な書式で文字列化する
var date = new DateTime(2020, 5, 1, 18, 5, 6, 140);
string[] standardFmts = {
    "d", "D", "f", "F", "g", "G", "m", "o",
    "R", "s", "t", "T", "u", "U", "y"  };
foreach (string standardFmt in standardFmts)
{
    Console.WriteLine("\"{0}\": {1}",
        standardFmt, date.ToString(standardFmt));
}
Console.WriteLine();

string[] customFmts = {
    "tt h時mm分", "h時mm分ss秒.ff", "HH:mm:ss.f",
    "yyyy年M月d日", "yyyy年MM月dd日(ddd)", "yyyy年MM月dd日(dddd)" };
foreach (string customFmt in customFmts)
{
    Console.WriteLine("\"{0}\": {1}",
        customFmt, date.ToString(customFmt));
}