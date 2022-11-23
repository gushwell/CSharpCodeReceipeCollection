using System;
using System.IO;

// 一時ファイル名を取得する
var name = Path.GetTempFileName();
Console.WriteLine(name);

// 一時ディレクトリへのパスを取得する
var tempdir = Path.GetTempPath();
Console.WriteLine(tempdir);

