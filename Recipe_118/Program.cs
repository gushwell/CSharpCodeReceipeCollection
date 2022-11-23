using System;

// Flags属性を付与した列挙型を定義する
var syota = Sns.Facebook | Sns.Twitter;
var seiya = Sns.None;
var ryoma = Sns.Facebook | Sns.Twitter | Sns.Instagram;
if ((syota & Sns.Twitter) == Sns.Twitter)
{
    Console.WriteLine("syotaは、Twitterを使っています");
}
if (seiya == Sns.None)
{
    Console.WriteLine("seiyaは、SNSを使っていません");
}
if ((ryoma & (Sns.Twitter | Sns.Line)) != Sns.None)
{
    Console.WriteLine("ryomaは、TwitterとLINEのどちらかを使っています");
}
if ((ryoma & (Sns.Facebook | Sns.Instagram)) == (Sns.Facebook | Sns.Instagram))
{
    Console.WriteLine("ryomaは、FacebookとInstagramの両方を使っています");
}

// これは発展で示したコード
// if (ryoma.HasFlag(Sns.Twitter) || ryoma.HasFlag(Sns.Line))
// {
//     Console.WriteLine("ryomaは、TwitterとLINEのどちらかを使っています");
// }
// if (ryoma.HasFlag(Sns.Facebook | Sns.Instagram))
// {
//     Console.WriteLine("ryomaは、FacebookとInstagramの両方を使っています");
// }

// Flags属性を付与した列挙型を定義する
[Flags]
public enum Sns
{
    None      = 0b_0000_0000,  // 0
    Line      = 0b_0000_0001,  // 1
    Twitter   = 0b_0000_0010,  // 2
    Facebook  = 0b_0000_0100,  // 4
    Instagram = 0b_0000_1000,  // 8
}

