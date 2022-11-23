using System;

{
    var temperature = 28.6;
    var month = 7;
    var text = $"{month}月の平均気温は、{temperature}度でした。";
    Console.WriteLine(text);
}

// 補足のコード
{
    var temperature = 28.6;
    var month = 7;
    var text = string.Format("{0}月の平均気温は、{1}度でした。", month, temperature);
    Console.WriteLine(text);
}

