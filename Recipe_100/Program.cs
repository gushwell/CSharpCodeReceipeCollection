using System;

var todo = new Todo();
Console.WriteLine($"Title={todo.Title}");
Console.WriteLine($"Finished={todo.Finished}");
Console.WriteLine($"CreatedAt={todo.CreatedAt:d}");
Console.WriteLine($"Deadline={todo.Deadline:d}");

// プロパティに初期値を設定する
public class Todo 
{
    public string Title { get; set; } = String.Empty;
    public bool Finished { get; set; } = false;
    public DateTime CreatedAt { get; } = DateTime.Now;
    public DateTime Deadline { get; set; } = DateTime.Now.AddDays(7);
}
