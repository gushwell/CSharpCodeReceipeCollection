using System;
using System.Text.RegularExpressions;

// 正規表現を使い文字列のが指定したパターンと一致するか調べる
var text = "The quick onyx goblin jumps over the lazy dwarf.";

var isMatch = Regex.IsMatch(text, @"^The\b.+\.$");
if (isMatch)
{
    // マッチした時の処理処理
    Console.WriteLine(isMatch);
}
