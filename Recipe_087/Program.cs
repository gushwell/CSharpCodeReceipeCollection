using System;
using System.Collections.Generic;


var fruits = new List<string>
{
    "apple", "banana", "blueberry", "cherry", "grape"
};
// Lengthプロパティで比較し、文字列長が短い順に並べ替え
fruits.Sort((a, b) => a.Length.CompareTo(b.Length));
foreach (string element in fruits)
{
    Console.WriteLine(element);
}
