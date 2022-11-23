using System;
using System.Collections.Generic;
using System.Linq;

var fruits = new List<string> 
{
    "apple", "avocado", "banana", "blueberry", "cherry", "grape"
};
var reversed = fruits.Reverse<string>();
Console.WriteLine(string.Join(',', reversed));
