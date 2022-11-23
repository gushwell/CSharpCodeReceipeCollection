using System;


var fruits = new string[] 
{
    "apple", "orange", "banana", "cherry", "blueberry"
};
foreach (var item in fruits) 
{
    Console.Write($"{item} ");
}
Console.WriteLine();

// 以下、補足で示したコード
for (var i = 0; i < fruits.Length; i++) 
{
    var item = fruits[i];
    Console.Write($"{item} ");
}
Console.WriteLine();

