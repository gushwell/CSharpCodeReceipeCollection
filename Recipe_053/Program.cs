using System;
using System.Linq;

var str = "おはようございます。今日は寒いですね";
// 文字列を文字配列に変換する 
char[] array = str.ToArray();
Console.WriteLine(string.Join("_", array));
// 文字配列を文字列に変換する 
var newstr = new String(array);
Console.WriteLine(newstr);