using System;
using System.Collections.Generic;
using System.Linq;

// 利用例
var books = new BookCollection();
books["978-4041099124"] = new Book("人間失格", "太宰治", "978-4041099124");
books["978-4101010137"] = new Book("こころ", "夏目漱石", "978-4101010137");
var book1 = books[0];
var book2 = books["978-4101010137"];
Console.WriteLine($"{book1.Title} {book1.ISBN}");
Console.WriteLine($"{book2.Title} {book2.ISBN}");

// インデクサの定義例
class BookCollection 
{
    private List<Book> _books = new List<Book>();
    
    // インデクサの定義。読み取りオンリー
    public Book this [int index] => _books.ElementAt(index);

    // インデクサの定義。読み書き可能 (追加はできない)
    public Book this [string isbn] 
    {
        get { return _books.First(x => x.ISBN == isbn); }
        set 
        { 
            var index = _books.FindIndex(x => x.ISBN == isbn);
            if (index < 0)
                _books.Add(value); 
            else
                _books[index] = value; 
        }
    }
}

class Book 
{
    public Book(string title, string author, string isbn) 
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }
    
    public string Title { get; set; }
    public string ISBN { get; set; }
    public string Author { get; set; }
}