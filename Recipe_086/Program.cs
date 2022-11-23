using System;
using System.Collections.Generic;

var fruits = new List<string> 
{
    "apple", "orange", "banana", "grape", "blueberry"
};
fruits.Sort();
Console.WriteLine(String.Join(", ", fruits));

