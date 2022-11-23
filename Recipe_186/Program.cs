using System;
using System.Collections.Generic;
using System.Linq;

PrintMax<int>(new[] { 1, 4, 8, 3, 10, 2, 7 });
PrintMax<DateTime>(new[] { new DateTime(2021, 3, 5), 
                           new DateTime(2021, 1, 6) });

PrintMax(new[] { 1, 4, 8, 3, 10, 2, 7 });
PrintMax(new[] { new DateTime(2021, 3, 5), 
                 new DateTime(2021, 1, 6) });

// ジェネリックメソッドの定義例
static void PrintMax<T>(IEnumerable<T> seq) where T : IComparable<T>
{
    T max = seq.First();
    foreach (var item in seq.Skip(1))
        if (item.CompareTo(max) > 0)
            max = item;
    Console.WriteLine(max);
}