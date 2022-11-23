using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

string[] fruits =
{
    "apple", "apricot", "banana", "cherry", "grape", 
    "kiwi", "lemon"
};
try
{
    var fruit = FindFruit(fruits, "peach");
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
    // 例外からDataプロパティの値を取り出す。
    // data変数にvarは使えない
    foreach (DictionaryEntry data in e.Data)
    {
        // KeyもValueもobject型。
        // 場合によっては、キャストして元の型に戻す必要がある。
        Console.WriteLine($"{data.Key}: {data.Value}");
    }
}

static string FindFruit(ICollection<string> fruits, string subString)
{
    var first = fruits.FirstOrDefault(x => x.Contains(subString));
    if (first == null)
    {
        // リストに存在しない果物の名前が渡ってきたら例外発生
        // 例外オブジェクトのDataプロパティに独自のデータを追加する。
        var ex = new ArgumentException("引数subStringに誤りがあります");
        ex.Data.Add("subString", subString);
        ex.Data.Add("fruitsCount", fruits.Count);
        throw ex;
    }
    return first.ToUpper();
}