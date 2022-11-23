using System;

var s1 = "Hello World.";
var s2 = "HELLO WORLD.";
if (s1.Equals(s2, StringComparison.OrdinalIgnoreCase))
    Console.WriteLine("一致しています");