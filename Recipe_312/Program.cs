using System;
using System.Text.Unicode;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Encodings.Web;

var todo = new Todo
{
	Title = "第3章の原稿を仕上げる",
	Deadline = new DateTime(2020, 12, 8),
	Done = false
};
var options = new JsonSerializerOptions
{
	Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
	PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
	WriteIndented = true
};

// JSONシリアライズ
string jsonString = JsonSerializer.Serialize(todo, options);
Console.WriteLine(jsonString);

// JSONデシリアライズ
var todo2 = JsonSerializer.Deserialize<Todo>(jsonString, options);
Console.WriteLine($"{todo2.Title} {todo2.Deadline} {todo2.Done}");

public class Todo
{
	public string Title { get; set; }
	public DateTime Deadline { get; set; }
	public bool Done { get; set; }
	[JsonIgnore]
	public string Description { get; set; }
}
