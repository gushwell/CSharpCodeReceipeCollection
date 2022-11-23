using System;

// 配列を並び替える 
var fruits = new string[]
{
    "apple", "orange", "banana", "cherry", "blueberry"
};
Array.Sort(fruits);
foreach (var fruit in fruits)
{
    Console.WriteLine(fruit);
}