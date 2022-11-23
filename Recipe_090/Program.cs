using System;
using System.Collections.Generic;

{
    var fruits = new List<string>
    {
        "Apple", "Orange", "Banana", "Blueberry"
    };
    var readonlylist = fruits.AsReadOnly();
    // 以下のコードはコンパイルエラー
    // readonlylist.Add("Grape");
}

// 以下は、発展で示したコード
{
    var fruits = new List<string>
    {
        "Apple", "Orange", "Banana", "Blueberry"
    };
    var readonlylist = fruits.AsReadOnly();
    fruits[0] = "Avocado";
    Console.WriteLine(string.Join(", ", readonlylist));
}