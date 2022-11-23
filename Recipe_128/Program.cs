using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string> 
{
    "apple", "avocado", "banana", "blueberry", "cherry", "grape"
};
var tail = fruits.Skip(4);
Console.WriteLine(string.Join(',', tail));
var tail2 = fruits.SkipWhile(x => x.StartsWith("a"));
Console.WriteLine(string.Join(',', tail2));
