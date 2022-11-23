using System;

var quote = "Peace begins with a smile.";
var word = "smile";
var contains = quote.Contains(word);
Console.WriteLine($"'{word}'を含んでいま" + (contains ? "す" : "せん"));