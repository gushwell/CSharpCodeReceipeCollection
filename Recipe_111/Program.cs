using System;

// personは匿名型
var person = new 
{ 
    Name = "坂本龍馬", 
    Birthdate = new DateTime(1836, 1, 3) 
};
Console.WriteLine($"{person.Name} {person.Birthdate:D}生まれ");
Console.WriteLine(person);
