using System;

var s = "DOM: Document Object Model";
var index = s.IndexOf(": ");
var left = s.Substring(0, index);   // 第2引数は取り出す文字数
var right = s.Substring(index + 2); // 指定した位置から最後までを取り出す
Console.WriteLine($"{left} - {right}");