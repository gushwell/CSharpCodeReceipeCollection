using System;
using System.Text.RegularExpressions;

var lines = "武田 24\n文挾 28\n町田 21\n高橋 31";
var ms = Regex.Matches(lines, @"(\d+)$", RegexOptions.Multiline);
foreach (Match m in ms)
{
    Console.Write($"{m.Groups[1]} ");
}
Console.WriteLine();
