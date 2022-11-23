using System;
using System.Linq;

var teachers = new[]
{
    new { Id = 10, Name = "高橋先生" },
    new { Id = 14, Name = "三橋先生" },
    new { Id = 26, Name = "吉原先生" },
};
var courses = new[]
{
    new { Title = "数学原論", TeacherId = 10 },
    new { Title = "数論", TeacherId = 10 },
    new { Title = "幾何学Ⅰ", TeacherId = 14 },
    new { Title = "幾何学Ⅱ", TeacherId = 14 },
    new { Title = "微分・積分", TeacherId = 26 },
};
var query = teachers.Join(courses, 
    t => t.Id, 
    c => c.TeacherId,
    (t, c) => new { t.Id, t.Name, c.Title });
foreach (var item in query)
{
    Console.WriteLine($"{item.Id} {item.Name} {item.Title}");
}