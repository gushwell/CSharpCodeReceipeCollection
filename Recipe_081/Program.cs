using System;
using System.Collections.Generic;

var fruits = new List<string>();
fruits.Add("apple");
fruits.Add("banana");
fruits.Add("blueberry");
fruits.Add("lemon");

// 要素数を取得
Console.WriteLine(fruits.Count);

// 挿入
fruits.Insert(3, "cherry");

// 末尾に追加
fruits.Add("orange");

// 削除
fruits.Remove("banana");

// 取得
var item = fruits[1];
Console.WriteLine(item);

// 置き換え
fruits[1] = "avocado";  // blueberryをavocadoに置き換え

// リストの要素を順に取り出し処理をする
foreach (var fruit in fruits)
{
    Console.Write($"{fruit} ");
}
Console.WriteLine();
