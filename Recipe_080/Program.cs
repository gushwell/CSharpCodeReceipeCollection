using System;

// var jaggedArray = new int[3][];
// jaggedArray[0] = new int[3] {1, 2, 3};
// jaggedArray[1] = new int[4] {4, 5, 6, 7};
// jaggedArray[2] = new int[2] {8, 9};

var jaggedArray = new int[][]
{
   new [] { 1, 2, 3 },
   new [] { 4, 5, 6, 7 },
   new [] { 8, 9 },
};

// インデックスを指定して要素にアクセスする
Console.WriteLine(jaggedArray[0][2]);
Console.WriteLine(jaggedArray[1][1]);
Console.WriteLine(jaggedArray[2][0]);

// for文ですべての要素を取得する
for (var i = 0; i < jaggedArray.Length; i++)
{
    var array = jaggedArray[i];
    for (var j = 0; j < array.Length; j++)
    {
        Console.Write($"{array[j]} ");
    }
    Console.WriteLine();
}

// foreach文ですべての要素を取得する
foreach (var array in jaggedArray)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}
