using System;
using System.Globalization;
using System.Collections.Generic;

var s = "𠀋𡈽𡌛𡑮𡢽𠮟𡚴";
StringInfo si = new StringInfo(s);
Console.WriteLine(si.LengthInTextElements);
foreach (var text in s.EnumTextElement()) 
{
    Console.WriteLine(text);
}

// yield returnを使ったイテレーターを定義(拡張メソッドとして定義)
public static class StringInfoExtensions 
{
    public static IEnumerable<string> EnumTextElement(this string s) 
    {
        var enumerator = StringInfo.GetTextElementEnumerator(s);
        while (enumerator.MoveNext()) 
        {
            var text = enumerator.GetTextElement();
            yield return text;
        }
    }
}
