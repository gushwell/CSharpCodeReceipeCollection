using System;

string msg = null;
msg ??= "Default Message";
Console.WriteLine(msg);

// 以下と同等のコード
// string msg = null;
// if (msg == null)
//     msg = "Default Message";
// Console.WriteLine(msg);
