using System;
using System.Security.Cryptography;

using var rsa = new RSACryptoServiceProvider();

// 秘密キーをXML形式で取り出す
var privateKey = rsa.ToXmlString(includePrivateParameters: true);
Console.WriteLine(privateKey);
Console.WriteLine();

// 公開キーをXML形式で取り出す
rsa.FromXmlString(privateKey);
var publicKey = rsa.ToXmlString(includePrivateParameters: false);
Console.WriteLine(publicKey);
