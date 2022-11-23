using System;

var s = "";
if (string.IsNullOrEmpty(s))
{
    Console.WriteLine("null か 空文字列です");
}

var s2 = " ";
if (string.IsNullOrWhiteSpace(s2))
{
    Console.WriteLine("null か 空文字列 か 空白文字列です");
}