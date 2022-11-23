using System;

var words = new [] 
    { "If", "you", "can", "dream", "you", "can", "do", "it" };
string last = words[^1];            // "it"
string[] candream = words[2..4];    // { "can", "dreeam" }
string[] doit = words[^2..^0];      // { "do", "it" }
string[] first4 = words[..4];       // { "If", "you", "can", "dream" }
string[] from4 = words[4..];        // { "you", "can", "do", "it" }
Range range = 3..^2;
string[] items = words[range];      // { "dream", "you", "can" }

Console.WriteLine(last);
Console.WriteLine(string.Join(",", candream));
Console.WriteLine(string.Join(",", doit));
Console.WriteLine(string.Join(",", first4));
Console.WriteLine(string.Join(",", from4));
Console.WriteLine(string.Join(",", items));
