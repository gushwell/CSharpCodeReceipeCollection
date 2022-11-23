using System;
using System.IO;

var fullpath = "./example/mydoc.txt"; 
var dirname = Path.GetDirectoryName(fullpath);
var fname = Path.GetFileName(fullpath);
var fnameWithoutExtension = Path.GetFileNameWithoutExtension(fullpath);
var ext = Path.GetExtension(fullpath);

Console.WriteLine(dirname);
Console.WriteLine(fname);
Console.WriteLine(fnameWithoutExtension);
Console.WriteLine(ext);

