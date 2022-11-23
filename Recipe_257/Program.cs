using System;
using System.IO;

var path = "./program.cs";
var fullpath = Path.GetFullPath(path);
Console.WriteLine(fullpath);
