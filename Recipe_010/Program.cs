using System;

// 条件演算子で条件に応じた値を設定する (? :)
var number = -8;
var message = number > 0 ? "0より大きな数です" : "0以下です";
Console.WriteLine(message);

var ext = "cs";
var message2 = ext == "cs" ? "C#のファイルです" : "C#以外のファイルです";
Console.WriteLine(message2);
