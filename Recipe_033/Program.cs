using System;

// String.Formatの例
var num1 = 123456;
var num2 = 9876.5;
var str1 = string.Format("{0,10:#,0}", num1);
Console.WriteLine(str1);
var str2 = string.Format("{0,10:#,0.00}", num2);
Console.WriteLine(str2);

// 文字列補間の例
var str3 = $"{num1,10:#,0}";
Console.WriteLine(str1);
var str4 = $"{num2,10:#,0.00}";
Console.WriteLine(str4);
