using System;
using System.Collections.Generic;

// C# 6.0 で導入された機能
// ディクショナリーのインスタンスを生成し初期値を設定する
var flowerDict = new Dictionary<string, int>()
{
    ["sunflower"] = 400,
    ["pansy"] = 300,
    ["tulip"] = 350,
    ["rose"] = 500,
    ["dahlia"] = 450,
};

// ディクショナリーに追加する （["violet"] に600が追加される）
flowerDict["violet"] = 600;
// ディクショナリーに追加する （「["violet"]の要素は変更されない）
flowerDict.TryAdd("violet", 400);

// ディクショナリから要素を取り出す
int roseprice = flowerDict["rose"];
Console.WriteLine(roseprice);

// ディクショナリに指定したキーが存在するかを確かめる
var key = "pansy";
if (flowerDict.ContainsKey(key))
{
    var pansyprice = flowerDict[key];
    Console.WriteLine(pansyprice);
}

// 要素をひとつずつ取り出す
foreach (var item in flowerDict)
{
    Console.WriteLine($"{item.Key} = {item.Value}");
}
