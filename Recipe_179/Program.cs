using System;
using System.Text;
using System.Threading;

// 拡張メソッドの利用例
var name = "hello";
Console.WriteLine(name.ToTitleCase());
Console.WriteLine("world".ToTitleCase());
Console.WriteLine("ｗｏｒｌｄ".ToTitleCase());

var base64str = "C# Programming".ToBase64String();
Console.WriteLine(base64str);
var original = base64str.FromBase64String();
Console.WriteLine(original);

// 拡張メソッドの定義例
static class StringExtensions
{
    public static string ToTitleCase(this string str)
    {
        var cultureInfo = Thread.CurrentThread.CurrentCulture;
        var textInfo = cultureInfo.TextInfo;
        return textInfo.ToTitleCase(str);
    }

    public static string ToBase64String(this string str, Encoding encoding = null)
    {
        var bytes = (encoding ?? Encoding.UTF32).GetBytes(str);
        return Convert.ToBase64String(bytes);
    }

    public static string FromBase64String(this string base64String, Encoding encoding = null)
    {
        var bytes = Convert.FromBase64String(base64String);
        return (encoding ?? Encoding.UTF32).GetString(bytes);
    }
}
