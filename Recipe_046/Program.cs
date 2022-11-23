using System;

// 文字列の中の各文字を一文字ずつ操作する  
var s = "Hello world!";
foreach (var ch in s) 
{
    Console.Write($"{ch}_");
}
Console.WriteLine();
