using System;
using System.Text;
using System.Security.Cryptography;

var message = "これは貴方だけに話す秘密のお話です";
var publicKey = @"<RSAKeyValue><Modulus>tPzEpYykLkTd31c1cxh8hP1iB+9igecJi14UdONYNXXqIDOCC5PCOkVTfjbQKiixbSqhqXLnR9UWqmf3xytYB3zdHBInTAqUeMMJdVOK1FNvJyFFCBGZixfwSZp1u5fAX2X8dQU680i4qi6zFvpWKaz8LX35MGfujVvxmLKYM70=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
var rsa = new RSACryptoServiceProvider();

// 公開キーを使ってRSAオブジェクトを初期化
rsa.FromXmlString(publicKey);
var bytes = Encoding.UTF8.GetBytes(message);

// 暗号化する
var output = rsa.Encrypt(bytes, true);
var outputStr = Convert.ToBase64String(output);

// 暗号化した結果をBase64文字列にして表示する
Console.WriteLine(outputStr);
