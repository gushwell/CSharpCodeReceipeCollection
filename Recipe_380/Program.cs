using System;
using System.Diagnostics;
using System.Linq;

var p = new Process();
p.StartInfo.UseShellExecute = false;
p.StartInfo.RedirectStandardOutput = true;
p.StartInfo.FileName = "git";
p.StartInfo.Arguments = "config --list";
p.Start();

// 標準出力の内容を最後まで読み込みoutputに代入
string output = p.StandardOutput.ReadToEnd();
p.WaitForExit();

var lines = output.Split("\n");
foreach (var line in lines.Take(8))
    Console.WriteLine(line);

