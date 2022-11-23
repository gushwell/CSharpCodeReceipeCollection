using System;
using System.Linq;
using System.Collections.Generic;

var persons = new List<Person> 
{
        new Person { Name = "坂本竜馬", SectionCode = 1 },
        new Person { Name = "吉田松陰", SectionCode = 2 },
        new Person { Name = "井伊直弼", SectionCode = 3 },
        new Person { Name = "桂小五郎", SectionCode = 1 },
        new Person { Name = "徳川慶喜", SectionCode = 2 },
        new Person { Name = "大久保利通", SectionCode = 4 },
};
var sections = new List<Section> 
{
        new Section { Code = 1, SectionName = "営業部" },
        new Section { Code = 2, SectionName = "総務部" },
        new Section { Code = 3, SectionName = "製造部" },
        new Section { Code = 0, SectionName = "企画部" },
};
var query = persons
    .GroupJoin(sections, 
        p => p.SectionCode, 
        s => s.Code,
        (p, ps) => new { p, ps })
    .SelectMany(
        x => x.ps.DefaultIfEmpty(),
        (x, s) => new
            {
                Name = x.p.Name,
                Section = s == null ? "(None)" : s.SectionName
            }
    );
foreach (var p in query)
{
    Console.WriteLine("{0} : {1}", p.Name, p.Section);
}
public class Person
{
    public string Name { get; set; }
    public int SectionCode { get; set; }
}

public class Section
{
    public int Code { get; set; }
    public string SectionName { get; set; }
}