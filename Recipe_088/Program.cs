using System;
using System.Collections.Generic;

var fruits = new List<string> 
{
    "apple", "apricot", "banana", "blueberry", "cherry", 
    "grape", "kiwi", "lemon", "mango", "melon", "peach", 
    "pear","strawberry",
};
fruits.Sort();
var index = fruits.BinarySearch("lemon");
Console.WriteLine(index < 0 ? "not found" : fruits[index]);

