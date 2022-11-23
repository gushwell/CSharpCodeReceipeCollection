using System;
using System.Collections.Generic;

// 利用例
var list = new TodoList();
var todo1 = new Todo("技術評論社との打ち合わせの日程調整");
var todo2 = new Todo("JSON読み取り時のバグ調査");
list.Add(todo1);
list.Add(todo2);
list.PrintAll();
var count = list.CountFinished();
Console.WriteLine($"終了した数:{count}");


/*
できるだけ実際に利用されるコードに近づけるために、少々長いコードになっています。この Todoクラスは他のセクションでも利用しています。またTodoListクラスは、他のセクションでさらにメソッドを追加していきます。
*/
// 定義例
public class Todo 
{
    public Todo(string title) 
    {
        Title = title;
    }
    public string Title { get; set; }
    public bool Finished { get; set; }
    //public DateTime Deadline { get; set; }
}

public class TodoList 
{
    private List<Todo> _list = new List<Todo>();

    // 戻り値のないメソッド　(TodoLisr.Addメソッド)
    public void Add(Todo item) 
    {
        _list.Add(item);
    }

    // 戻り値のないメソッド　(TodoLisr.PrintAllメソッド)
    public void PrintAll()
    {
        foreach (var item in _list)
        {
            Console.WriteLine($"{item.Title} {item.Finished} ");
        }
    }

    // int型を返すメソッド
    public int CountFinished() 
    {
        var count = 0;
        foreach (var todo in _list)
        {
            count += todo.Finished ? 1 : 0;
        }
        return count;
    }
}


