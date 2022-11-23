using System;
using System.Linq;

var fruits = new string[] 
{
    "apple", "apricot", "banana", "blueberry", "grape", 
    "grapefruit", "lemon", "mango", "melon", "peach", "pear",
};
// 求める結果の初期値を「cherry」にする 
// longestはその時点の求める結果
// nextには、要素が順に渡ってくる
var longestName = fruits.Aggregate("cherry",
    (longest, next) => next.Length > longest.Length ? next : longest);
Console.WriteLine(longestName);

