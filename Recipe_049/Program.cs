using System;
using System.Text;

var sb = new StringBuilder();
string[] strs =
{
    "色は匂へど 散りぬるを",
    "我が世誰ぞ 常ならむ",
    "有為の奥山 今日越えて",
    "浅き夢見じ 酔ひもせず"
};
foreach (var s in strs)
{
    sb.AppendLine(s);
}
var text = sb.ToString();
Console.Write(text);