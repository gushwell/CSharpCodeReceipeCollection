using System;
using System.Collections.Generic;

// リストを逆順に並び替える
var nums = new List<int> { 1, 3, 5, 7, 6, 4, 2, 0 };
nums.Reverse();
Console.WriteLine(string.Join(", ", nums));
