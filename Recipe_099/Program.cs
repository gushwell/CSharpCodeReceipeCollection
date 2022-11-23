using System;

var person = new GreatPerson("湯川", "秀樹", new DateTime(1907, 1, 23));
Console.WriteLine(person.Name);
Console.WriteLine(person.Birthdate);

// すべてが読み取り専用プロパティ
public class GreatPerson
{
    public string FamilyName { get; private set; }
    public string GivenName { get; private set; }

    public string Name => FamilyName + GivenName;

    // 古い形式
    // public string Name
    // {
    //     get { return FamilyName + GivenName; }
    // }

    public DateTime Birthdate { get; }

    public GreatPerson(string familyname, string givenname, DateTime birthdate)
    {
        FamilyName = familyname;
        GivenName = givenname;
        Birthdate = birthdate;
    }
}

