using System;

// タプルを受け取る
var tuple = GetItem();
Console.WriteLine($"{tuple.name} {tuple.color}");

// タプルを分解して受け取る
var (name, color) = GetItem();
Console.WriteLine($"{name} {color}");

// タプルを返すメソッド
static (string name, string color) GetItem()
{
    var named = ("Banana", "Yellow");
    return named;
    // もちろん return ("Banana", "Yellow"); でもOKOK
}
