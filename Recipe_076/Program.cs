using System;

// 配列の要素を逆順にする 
var nums = new int[] { 1, 2, 3, 4, 5, 6 };
Array.Reverse(nums);
foreach (var num in nums)
{
    Console.Write($"{num} ");
}
Console.WriteLine();

