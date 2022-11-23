using System;
using System.Text.RegularExpressions;

var text = "The quick onyx goblin jumps over the lazy dwarf.";

// ５文字からなる単語をすべて取得する
var matches1 = Regex.Matches(text, @"\b(\w{5})\b");
foreach (Match m in matches1)
{
    Console.WriteLine(m.Value);
}
Console.WriteLine("---");

// 単語The/theの後に続く単語をすべて取得する
var matches2 = Regex.Matches(text, @"\b[Tt]he\s+(\w+)\b");
foreach (Match m in matches2)
{
    Console.WriteLine(m.Groups[1].Value);
}