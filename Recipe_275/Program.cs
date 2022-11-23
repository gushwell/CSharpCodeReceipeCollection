using System;
using System.IO;
using System.Text;

var str = @"祇園精舎の鐘の声、諸行無常の響きあり。
沙羅双樹の花の色、盛者必衰の理をあらはす。
驕れる人も久しからず、ただ春の夜の夢のごとし。
猛き者も遂にはほろびぬ、ひとへに風の前の塵におなじ";

using (var reader = CreateStreamReader(str))
{
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        Console.WriteLine($"<{line}>");
    }
}

static StreamReader CreateStreamReader(string str)
{
    byte[] byteArray = Encoding.UTF8.GetBytes(str);
    var stream = new MemoryStream(byteArray);
    return new StreamReader(stream);
}

// これは補足で示したコード
Console.WriteLine();
using (var reader = new StringReader(str))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine($"<{line}>");
    }
}
