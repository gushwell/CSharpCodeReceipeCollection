using System;

var p1 = new Person("Bill", "Gates");
var p2 = new Person("Bill", "Gates");
var p3 = new Teacher("Bill", "Atkinson", "History");
Console.WriteLine(p1.ToString());
Console.WriteLine(p3.ToString());
Console.WriteLine($"p1 == p2: {p1 == p2}");
Console.WriteLine($"ReferenceEquals(p1, p2): {Object.ReferenceEquals(p1, p2)}");
Console.WriteLine($"p1.GetHashCode(): {p1.GetHashCode()}");
Console.WriteLine($"p1 != p3: {p1 != p3}");
var p4 = p1;
Console.WriteLine($"p1 == p4: {p1 == p4}");
Console.WriteLine($"ReferenceEquals(p1, p4): {Object.ReferenceEquals(p1, p4)}");

public record Person(string FirstName, string LastName);

public record Teacher(string FirstName, string LastName, string Subject)
    : Person(FirstName, LastName);

