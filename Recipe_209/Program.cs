using System;

// オブジェクト初期化子での初期化はOK
var book = new Book
{
    Title = "源氏物語",
    Author = "紫式部"
};

// 以下のコードはエラー
// book.Author = "清少納言";

public class Book
{
    public string Title { get; init; }
    public string Author { get; init; }
}
