using System;
using System.Linq;

var dateStrs = new [] 
{ 
    "1868/10/23", "1912/7/30", "1926/12/25", "1989/1/8" 
};
var array = dateStrs.Select(x => DateTime.Parse(x)).ToArray();
// 配列なのでインデックスでアクセスできる
Console.WriteLine($"array[0]: {array[0]}");
// 配列なのでLengthプロパティが使える
Console.WriteLine($"要素数: {array.Length}");
