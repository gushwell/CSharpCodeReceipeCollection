using System;

var s1 = "The quick brown fox jumps over a lazy dog. ";
var s2 = "The quick onyx goblin jumps over the lazy dwarf.";
if (string.Compare(s1, 0, s2, 0, 10) == 0)
    Console.WriteLine("先頭10文字目までは一致しています");
    