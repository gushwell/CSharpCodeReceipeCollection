using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string> 
{
    "apple", "avocado", "banana", "blueberry", "cherry", "grape"
};
var head = fruits.Take(4);
Console.WriteLine(string.Join(',', head));
var head2 = fruits.TakeWhile(x => x.StartsWith("a"));
Console.WriteLine(string.Join(',', head2));