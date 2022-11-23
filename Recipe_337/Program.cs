using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

var crypted = "izkrdQVdthIbfQHhNG10Wo/ssSpGi6Py9PXsAAIxRA+ET+pMIlrGsW4I7tL/i6Sabr/1/k/LFd//GrBy7RUpj3CUJ885gzgWBuU8YwS0Rgi/8m1aw6foYdQlc0yzQCNG8PZDcu09miQg7k+1lOCp5KDUvm+DNA61egShYfvQ5UE=";

// RSA秘密キーファイル(PKCS＃1)を読み込み前処理する
var pemstring = File.ReadAllText("privatekey.pem");
var privateKey = pemstring.Replace("-----BEGIN RSA PRIVATE KEY-----","")
                    .Replace("-----END RSA PRIVATE KEY-----","")
                    .Replace("\n","").Replace("\r","");
var privateKeyBytes = Convert.FromBase64String(privateKey);

using var rsa = new RSACryptoServiceProvider();

// 秘密キーをインポート
rsa.ImportRSAPrivateKey(privateKeyBytes, out _);

// 復号する
var bytes = Convert.FromBase64String(crypted);
var output = rsa.Decrypt(bytes, true);

// byte配列を文字列にして出力
var message = Encoding.UTF8.GetString(output);
Console.WriteLine(message);
