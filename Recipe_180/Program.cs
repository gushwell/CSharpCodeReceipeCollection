using System;
using System.Collections.Generic;
using System.Linq;

var drinks = new[] {
    "wine", "sake", "beer", "whisky", "liqueur", 
    "cocktail", "champagne"
};
// 長さが 8 以上の要素が含まれているか
var contains = drinks.Contains(x => x.Length >= 8);
Console.WriteLine(contains);
var nums = new[] { 1, 3, 5, 7, 9, 11 };
// 3で割り切れる要素が含まれているか。
var contains2 = nums.Contains(x => x % 3 == 0);
Console.WriteLine(contains2);

// LINQ to Objectを拡張するクラス
public static class EnumerableExtensions
{
    public static bool Contains<T>(
            this IEnumerable<T> source, Predicate<T> predicate)
    {
        foreach (var element in source)
            if (predicate(element) == true)
                return true;
        return false;
    }
}

