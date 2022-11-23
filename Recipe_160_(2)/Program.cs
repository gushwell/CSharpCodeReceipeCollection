using System;
using System.Linq;

var fruits = new string[]
{
    "apple", "apricot", "banana", "blueberry", "grape",
    "grapefruit", "lemon", "mango", "melon", "peach", "pear",
};
var concatstr = fruits.Aggregate((t, f) => 
    (f.Length == 5) ? $"{f}|{t}" : t);
Console.WriteLine(concatstr);

