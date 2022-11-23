using System;
using System.Globalization;

var s1 = "Ｗｉｎｄｏｗｓ";
var s2 = "Windows";

Console.WriteLine(s1 == s2);
Console.WriteLine(s1.Equals(s2));
Console.WriteLine(String.Compare(s1, s2));
Console.WriteLine(String.Compare(s1, s2, StringComparison.Ordinal));
Console.WriteLine("-----");

Console.WriteLine(s1.StartsWith("Win"));
Console.WriteLine(s2.StartsWith("Win"));
Console.WriteLine("-----");

Console.WriteLine(s1.StartsWith("Win", StringComparison.Ordinal));
Console.WriteLine(s2.StartsWith("Win", StringComparison.Ordinal));

Console.WriteLine(s1.StartsWith("WIN", StringComparison.OrdinalIgnoreCase));
Console.WriteLine(s2.StartsWith("WIN", StringComparison.OrdinalIgnoreCase));
