using System;
using System.Collections.Generic;

var fruits = new List<string>
{
    "apple", "orange", "banana", "cherry", "blueberry"
};
fruits.AddRange(new[] { "kiwi", "orange", "peach" });
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}
