using System;

var person = new GreatPerson();
person.Name = "アラン・ケイ";
person.Birthdate = new DateTime(1940, 5, 17);
Console.WriteLine($"{person.Name} {person.Birthdate:d}");

public class GreatPerson
{
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }
}
