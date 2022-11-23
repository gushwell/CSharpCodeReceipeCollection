using System;
using System.Text;
using System.Security.Cryptography;

var text = "吾輩は猫である。名前はまだ無い。";
var messageBytes = Encoding.Unicode.GetBytes(text);
using var shHash = new SHA256Managed();
var hash = shHash.ComputeHash(messageBytes);
Console.WriteLine(Convert.ToBase64String(hash));
