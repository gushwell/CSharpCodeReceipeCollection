using System;

var p1 = new NamedPoint("A", 100, 200);
var p2 = p1 with { Name = "B", X = 50 };
Console.WriteLine($"{nameof(p1)}: {p1}");
Console.WriteLine($"{nameof(p2)}: {p2}");
public record NamedPoint(string Name, int X, int Y);
