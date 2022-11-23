using System;
using System.Security.Cryptography;

var (key, iv) = GenerateKeyAndIv();
Console.WriteLine($"{key.Length} {Convert.ToBase64String(key)}");
Console.WriteLine($"{iv.Length} {Convert.ToBase64String(iv)}");

// KeyとIVを生成する
static (byte[], byte[]) GenerateKeyAndIv() 
{
    using (var aes = new AesManaged()) 
    {
        aes.GenerateKey();
        aes.GenerateIV();
        return (aes.Key, aes.IV);
    }
}