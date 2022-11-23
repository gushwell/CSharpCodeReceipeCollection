using System;

// 閏年かを調べる
var isLeapYear = DateTime.IsLeapYear(2020);
Console.WriteLine(isLeapYear ? "うるう年です" : "うるう年ではありません");
