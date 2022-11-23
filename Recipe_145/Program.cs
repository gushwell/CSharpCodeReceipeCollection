using System;
using System.Linq;

var list = new [] 
{
    new  { Extension = "bat", Description = "バッチファイル" },
    new  { Extension = "docx", Description = "Wordファイル" },
    new  { Extension = "exe", Description = "実行ファイル" },
    new  { Extension = "txt", Description = "テキストファイル" },
    new  { Extension = "md", Description = "Markdownファイル" },
};

// KeyとValueを指定してDictionaryを作成する
// ひとつ目の引数がキー、ふたつ目の引数がValueとなる
var dict = list.ToDictionary(k => k.Extension, v => v.Description);
foreach (var item in dict) 
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
