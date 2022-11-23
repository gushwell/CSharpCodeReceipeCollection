using System;

var num = 97.7454;
var dp = 2;  // 小数点以下第2位まで求める
// 切り捨て
var floor = Math.Floor(num * Math.Pow(10, dp)) / Math.Pow(10, dp);
Console.WriteLine(floor);
// 切り上げ
var ceiling = Math.Ceiling(num * Math.Pow(10, dp)) / Math.Pow(10, dp);
Console.WriteLine(ceiling);

