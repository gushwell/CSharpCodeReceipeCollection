using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

var sc = new StringEncrypter();
var str = sc.Encrypt("これはあなたに宛てた秘密のメッセージです。");
Console.WriteLine($"Key:{Convert.ToBase64String(sc.Key)}");
Console.WriteLine($"IV:{Convert.ToBase64String(sc.IV)}");
Console.WriteLine(str);

// 文字列を暗号化するクラス
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
