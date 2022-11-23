using System;
using System.Linq;

string[] eweeks = { "Mon", "Tue", "Wed", "Thu", "Fri", "Sat", "Sun" };
string[] jweeks = { "月", "火", "水", "木", "金", "土", "日" };
var weeks = eweeks.Zip(jweeks)
                  .ToDictionary(x => x.Item1, x => x.Item2);
foreach (var item in weeks)
{
    Console.WriteLine($"{item.Key} : {item.Value}");
}