using System;
using System.Text.RegularExpressions;

{
    // 正規表現を使い文字列の置換処理を行う

    var text = "The quick onyx goblin jumps over the lazy dwarf.";
    var result = Regex.Replace(text, @"(\b)(\w{5})(\b)", @"$1[$2]$3");
    Console.WriteLine(result);
}


// 以降は、発展で示したコード
{

    var text = "The quick onyx goblin jumps over the lazy dwarf.";
    var result2 = Regex.Replace(text, @"\b\w+\b",
        (Match m) =>
            m.Value.Length > 1
                ? Char.ToUpper(m.Value[0]) + m.Value[1..^0]
                : m.Value.ToUpper()
    );
    Console.WriteLine(result2);
}
