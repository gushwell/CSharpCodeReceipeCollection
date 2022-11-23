using System;
using System.Text;

var s = "おはようございます.";

// 文字列をbyte配列に変換
var bytes = Encoding.Unicode.GetBytes(s);
foreach (var b in bytes)
{
    Console.Write("{0:x2} ", b);
}
Console.WriteLine();

// byte配列を文字列に変換
var str = Encoding.Unicode.GetString(bytes);
Console.WriteLine(str);
