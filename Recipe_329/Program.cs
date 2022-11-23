using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

// keyとivはハードコードせずにファイルなどから読み込むことが望ましい
var key = "PxQjDSdidyGZH3bUpqs71z2GKv7jLrxNZt0df45sDoo=";
var iv = "srBv3Zq+3Go1P1SUF2OJ8g==";
var encripted = "Ij8MS/RlykAK6zFPEwIcshVfzlTsJUCmX+BOKi4yN0rSE4V5fTwmkgxbjT1+xGtUHMuhg81cxLAi6l4akWIpR/qFTegfqtUxqNV0wPY7B+o=";
var sc = new StringEncrypter(Convert.FromBase64String(key), Convert.FromBase64String(iv));
var text = sc.Decrypt(encripted);
Console.WriteLine(text);


// 文字列を暗号化/復号するクラス
class StringEncrypter
{
	// コンストラクター
	public StringEncrypter(byte[] key = null, byte[] iv = null)
	{
		using (var aes = new AesManaged())
		{
			Key = key;
			if (key == null)
			{
				aes.GenerateKey();
				Key = aes.Key;
			}
			IV = iv;
			if (iv == null)
			{
				aes.GenerateIV();
				IV = aes.IV;
			}
		}
	}

	public byte[] Key { get; private set; }
	public byte[] IV { get; private set; }

	// 復号する
	public string Decrypt(string encrypted)
	{
		var bytes = Convert.FromBase64String(encrypted);
		// MemoryStreamに暗号化されたデータが入っている
		using (var memStream = new MemoryStream(bytes))
		{
			// AesManagedアルゴリズムでCryptoStreamオブジェクトを生成する
			using (var aes = new AesManaged())
			using (var cryptoStream = new CryptoStream(memStream,
				aes.CreateDecryptor(Key, IV),
				CryptoStreamMode.Read))
			// cryptoStreamからデータを読み込むことで、復号されたデータが得られる。
			using (var reader = new StreamReader(cryptoStream))
			{
				return reader.ReadToEnd();
			}
		}
	}

	// 暗号化する
	public string Encrypt(string text)
	{
		// MemoryStreamに暗号化したデータが出力される
		var memStream = new MemoryStream();
		// AesManagedアルゴリズムで、CryptoStreamを生成する
		using (var aes = new AesManaged())
		using (var cryptoStream = new CryptoStream(memStream,
			aes.CreateEncryptor(Key, IV),
			CryptoStreamMode.Write))
		// cryptoStreamに文字列を書い出すとMemoryStreamに暗号化されたデータが出力される
		using (var writer = new StreamWriter(cryptoStream, Encoding.UTF8))
		{
			writer.Write(text);
		}
		memStream.Dispose();
		// ToArrayは、Disposeした後に利用する
		var encrypted = memStream.ToArray();
		return Convert.ToBase64String(encrypted);
	}
}

