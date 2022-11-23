using System;
using System.IO;

var dir = ".";
var files = Directory.GetFiles(dir, "*.exe", SearchOption.TopDirectoryOnly);
foreach (var fname in files)
{
    Console.WriteLine(fname);
}