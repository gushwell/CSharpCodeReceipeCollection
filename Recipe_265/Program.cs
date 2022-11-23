using System;
using System.IO;

var dir = ".";
var dirs = Directory.GetDirectories(dir, "*", SearchOption.TopDirectoryOnly);
foreach (var name in dirs)
{
    Console.WriteLine(name);
}