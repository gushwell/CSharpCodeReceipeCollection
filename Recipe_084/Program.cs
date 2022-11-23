using System;
using System.Collections.Generic;

var fruits = new List<string> {
    "apple", "apricot", "banana", "blueberry", "cherry", 
    "grape", "kiwi", "lemon", "mango", "melon", "peach", 
    "pear", "strawberry",
};
var count = fruits.RemoveAll(x => x.Length <= 5);
Console.WriteLine(String.Join(", ", fruits));
Console.WriteLine($"削除した要素の数: {count}");