using System;
using System.Collections.Generic;

// 利用例
var list = new TodoList();
var todo = new Todo 
{ 
    Title = "技術評論社との打ち合わせの日程調整",
    Deadline = new DateTime(2020, 11, 30)
};
list.Add(todo);
list.Add("JSON読み取り時のバグ調査", DateTime.Today.AddDays(1));
list.PrintAll();

// 以下、定義例
public class Todo 
{
    public string Title { get; set; }
    public bool Finished { get; set; } = false;
    public DateTime Deadline { get; set; }
}

public class TodoList 
{
    private List<Todo> _list = new List<Todo>();

    // Addメソッド
    public void Add(Todo item) 
    {
        _list.Add(item);
    }

    // もうひとつAddメソッド
    public void Add(string title, DateTime deadline) 
    {
        var todo = new Todo 
        {
            Title = title,
            Deadline = deadline
        };
        _list.Add(todo);
    }
    public void PrintAll() 
    {
        foreach (var item in _list)
            Console.WriteLine($"{item.Title} {item.Deadline:d} {item.Finished} ");
    }
}
