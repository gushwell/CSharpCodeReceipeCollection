using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

string message = "この文字列に対しデジタル署名を生成します。";

var rsa = new RSACryptoServiceProvider();
string privateKey = rsa.ToXmlString(true);
string publicKey = rsa.ToXmlString(false);

var digitalSign = MakeDigitalSign(message, privateKey);

Console.WriteLine($"digital sign: {digitalSign}");
Console.WriteLine($"publickey: {publicKey}");

static string MakeDigitalSign(string message, string privateKey)
{
	byte[] digest = CreateHash(message);
	// DSACryptoServiceProvider インスタンス生成
	var rsa = new RSACryptoServiceProvider();
	// 秘密キーをインポート   
	rsa.FromXmlString(privateKey);
	// Formatterオブジェクトを生成
	var rsaFormatter = new RSAPKCS1SignatureFormatter(rsa);
	rsaFormatter.SetHashAlgorithm("SHA256");
	// 署名を作成
	var signature = rsaFormatter.CreateSignature(digest);
	return Convert.ToBase64String(signature);
}

static byte[] CreateHash(string message)
{
	byte[] msgData = System.Text.Encoding.UTF8.GetBytes(message);
	using var sha = new SHA256Managed();
	return sha.ComputeHash(msgData);
}

