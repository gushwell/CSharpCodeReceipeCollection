using System;
using System.Text;


var text = "おはようございます.";
var encoding = Encoding.Unicode;

// 文字列をBase64文字列へエンコード
var bytes = encoding.GetBytes(text);
var base64str = Convert.ToBase64String(bytes);
Console.WriteLine(base64str);

// Base64文字列から元の文字列をへデコード
var bytes2 = Convert.FromBase64String(base64str);
var text2 = encoding.GetString(bytes2);
Console.WriteLine(text2);
