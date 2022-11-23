using System;

var base64str = "44GK44Gv44KI44GG44GU44GW44GE44G+44GZLg==";

// Base64文字列をbyte配列に変換
var bytes = Convert.FromBase64String(base64str);

// byte配列をBase64文字列に変換
var base64str2 = Convert.ToBase64String(bytes); 
Console.WriteLine(base64str2);