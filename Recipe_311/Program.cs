using System;
using System.Net;

var param = "ASP.NET Core + C#で開発する";

// URLエンコード
var encoded = Uri.EscapeDataString(param);
Console.WriteLine(encoded);

// URLデコード
var decoded = WebUtility.UrlDecode(encoded);
Console.WriteLine(decoded);

