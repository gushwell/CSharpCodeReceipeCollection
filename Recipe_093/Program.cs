using System;
using System.Collections.Generic;

// インスタンスの生成
var hashSet = new HashSet<string>();
// コレクションに値を追加する
hashSet.Add("apple");
hashSet.Add("banana");
hashSet.Add("grape");
hashSet.Add("lemon");
hashSet.Add("lemon"); // 追加に失敗する。ただし例外は出ない

// 要素数
Console.WriteLine(hashSet.Count);

// コレクションから削除する
hashSet.Remove("grape");

// コレクションに含まれているか
var contains = hashSet.Contains("grape");
Console.WriteLine(contains);

// 順に値を取り出す
foreach (var item in hashSet) 
{
    Console.Write($"{item} ");
}
Console.WriteLine();