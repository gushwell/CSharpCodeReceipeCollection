using System;
using System.Collections.Generic;

var flowerDict = new Dictionary<string, int>()
{
    ["sunflower"] = 400,
    ["pansy"] = 300,
    ["tulip"] = 350,
    ["rose"] = 500,
    ["dahlia"] = 450,
};
// キーをひとつずつ取り出す
foreach (var key in flowerDict.Keys)
{
    Console.WriteLine($"{key} = {flowerDict[key]}");
}