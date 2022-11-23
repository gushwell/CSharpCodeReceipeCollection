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
    new { Title = "微分・積分", TeacherId = 26 },
    new { Title = "幾何学Ⅰ", TeacherId = 14 },
    new { Title = "幾何学Ⅱ", TeacherId = 14 },
};
// GroupJoinの第4引数で、一人の先生(Teacher)と複数の講座(Courses)の
// プロパティを持つ匿名オブジェクトを生成している。
// この匿名シーケンスがGroupJoinの戻り値となる。
var query = teachers.GroupJoin(courses,
    t => t.Id,
    c => c.TeacherId,
    (t, cs) => new { Teacher = t, Courses = cs });
foreach (var group in query)
{
    Console.WriteLine(group.Teacher.Name);
    foreach (var c in group.Courses)
    {
        Console.WriteLine($"  {c.Title}");
    }
}