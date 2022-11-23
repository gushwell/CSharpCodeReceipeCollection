using System;
using System.Collections.Generic;


var obj = new { Name = "貴史", Weight = 65, Height = 174 };
var dir = ObjectToDictionary(obj);
foreach (var item in dir)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}

// プロパティ名と値を対にしたDictionaryオブジェクトを生成
static Dictionary<string, string> ObjectToDictionary<T>(T data)
{
    var dict = new Dictionary<string, string>();
    var type = typeof(T);
    foreach (var prop in type.GetProperties())
    {
        var value = prop.GetValue(data);
        dict[prop.Name] = value?.ToString() ?? "";
    }
    return dict;
}
