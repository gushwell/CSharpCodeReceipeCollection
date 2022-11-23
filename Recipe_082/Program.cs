using System;
using System.Collections.Generic;

var fruits = new List<string> 
{
    "apple", "banana", "blueberry", "cherry", "grape"
};
var nums = new List<int> { 1, 2, 3, 4, 5 };
Console.WriteLine(string.Join(", ", fruits));
Console.WriteLine(string.Join(", ", nums));

