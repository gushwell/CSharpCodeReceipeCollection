using System;
using System.Text.RegularExpressions;

var text = "The quick onyx goblin jumps over the lazy dwarf.";

// ４文字からなる単語を取り出す
var m1 = Regex.Match(text, @"\b\w{4}\b");
if (m1.Success)
{
    Console.WriteLine($"{m1.Value}");
}
Console.WriteLine("-----");

// 単語theの次に来る単語を取り出す
var m2 = Regex.Match(text, @"\bthe\s+(\w+)\b");
if (m2.Success)
{
    Console.WriteLine($"{m2.Groups[1].Value}");
}
