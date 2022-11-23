using System;
using System.ComponentModel.DataAnnotations;

// 型名を取得
var name1 = nameof(System.DateTime);
Console.WriteLine(name1);

// プロパティ名を取得
var name2 = nameof(DateTime.Year);
Console.WriteLine(name2);

// メソッド名を取得
var name3 = nameof(DateTime.AddDays);
Console.WriteLine(name3);

// 以下は発展で示したコード
public class UserInfo 
{
    [Required]
    public string Password { get; set; }

    [Required]
    [Compare(nameof(Password), ErrorMessage = "パスワードが異なります。")]
    public string ConfirmPassword { get; set; }
}
