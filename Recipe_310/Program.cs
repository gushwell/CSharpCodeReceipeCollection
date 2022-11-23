using System;
using System.Net;

// HTMLエンコード
var param = "<p>Hello .NET&C# world</p>";
var encoded = WebUtility.HtmlEncode(param);
Console.WriteLine(encoded);

// HTMLデコード
var decoded = WebUtility.HtmlDecode(encoded);
Console.WriteLine(decoded);
