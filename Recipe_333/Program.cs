using System;
using System.Security.Cryptography;

// これはWindowsのみで利用できるコード

var containerName = "myContainer";
var cp = new CspParameters
{
	KeyContainerName = containerName
};
using var rsa = new RSACryptoServiceProvider(cp);
// これで、コンテナに格納される
var privateKey = rsa.ToXmlString(includePrivateParameters: true);
Console.WriteLine(privateKey);


// 以下おまけ　（こんなメソッドを定義してもよいかも）
static string CreateAndSaveInContainer(string containerName)
{
	var cp = new CspParameters
	{
		KeyContainerName = containerName
	};
	using var rsa = new RSACryptoServiceProvider(cp);
	// これで、コンテナに格納される
	return rsa.ToXmlString(includePrivateParameters: true);
}

static string GetFromContainer(string containerName)
{
	var cp = new CspParameters
	{
		KeyContainerName = containerName
	};
	// キーコンテナーMyKeyContainerNameにアクセスするRSACryptoServiceProviderの新しいインスタンスを作成します。
	using var rsa = new RSACryptoServiceProvider(cp);
	return rsa.ToXmlString(includePrivateParameters: true);
}
