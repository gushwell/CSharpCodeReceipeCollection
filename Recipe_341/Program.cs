using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;

var message = "この文字列に対しデジタル署名を生成します。";
// Base64形式にエンコードされたデジタル署名
var digitalSignStr = "NMdusBhkssZQA2rAVlz3M9d0LcDtvkH47v3NN0m3tQCpJtBZE9AWf0rWCwkNGfGCLaEiASXtM4VDVOw0TQYhXComfxLHttNabg8ua6kf1u/d5K2wrbgvQmgiU6wKpHT7GmStFFl9xdF04EfMGnFQ+n/JBF4nGVo7rl1oOEvCbTg=";
// 公開キー
var publicKey = "<RSAKeyValue><Modulus>u+LfJ/V6ioJT5x0VGN8kogxDgvKj6Lkzg0ZwFDde1DsYN+4HQxwrcIXZRiFKLdJpqAatRHenOPu8uxLmfjziV2Nk+mGD9nl77Dod7ILn0DXsG/VjFU7sd7uc7k2GsnUoOzz6wI8gQxFYEtLmtproyskeeAuglH7B1/pXsu4vOl0=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";
var digitalSign = Convert.FromBase64String(digitalSignStr);
var result = VerifyDigitalSign(message, digitalSign, publicKey);
if (result)
{
	Console.WriteLine("改ざんされていません");
}
else
{
	Console.WriteLine("改ざんされています");
}

static bool VerifyDigitalSign(string message,
								byte[] digitalSign, string publicKey)
{
	var rsa = new RSACryptoServiceProvider();
	// 公開キーを指定 
	rsa.FromXmlString(publicKey);
	// Formatterオブジェクトを生成
	var rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
	// Hashアルゴリズムを指定する
	rsaDeformatter.SetHashAlgorithm("SHA256");
	// ダイジェストを作成
	byte[] digest = CreateHash(message);
	return rsaDeformatter.VerifySignature(digest, digitalSign);
}

static byte[] CreateHash(string message)
{
	byte[] msgData = System.Text.Encoding.UTF8.GetBytes(message);
	using var sha = new SHA256Managed();
	return sha.ComputeHash(msgData);
}
