using System;

var home = Environment.GetEnvironmentVariable("HOME");
Console.WriteLine(home);

var user = Environment.GetEnvironmentVariable("USER");
Console.WriteLine(user);

// 以下おまけ
var appdata = Environment.GetEnvironmentVariable("APPDATA");
var systemRoot = Environment.GetEnvironmentVariable("SystemRoot");
Console.WriteLine(appdata);
Console.WriteLine(systemRoot);
var dict = Environment.GetEnvironmentVariables();
foreach (var key in dict.Keys)
{
	Console.WriteLine($"{key} {dict[key]}");
}
