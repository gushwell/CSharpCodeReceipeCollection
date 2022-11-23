using System;
using System.Linq;

var fruits1 = new[] { "apple", "banana", "blueberry", "apple" };
var fruits2 = new[] { "banana", "blueberry", "cherry" };
var set1 = fruits1.ToHashSet();
var set2 = fruits2.ToHashSet();
set1.IntersectWith(set2);
foreach (var item in set1)
{
    Console.WriteLine(item);
}