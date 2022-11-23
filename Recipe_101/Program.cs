using System;

var person = new GreatPerson();
person.Name = "フォン・ノイマン";
person.Birthdate = new DateTime(1903, 12, 28);
Console.WriteLine($"{person.Name} {person.Birthdate:d}");

class GreatPerson
{
    // バッキングフィールドルド
    private string _name;

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("nullや空文字を代入することはできません");
            _name = value;
        }
    }
    public DateTime Birthdate { get; set; }
}

