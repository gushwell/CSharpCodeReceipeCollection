using System;

// 利用例
var person = new GreatPerson("アンダース・ヘルスバーグ", new DateTime(1960, 12, 2));
Console.WriteLine(person.Name);
Console.WriteLine($"{person.Birthdate:yyyy年MM月dd日}");

// 定義例
public class GreatPerson 
{
    public string Name { get; }
    public DateTime Birthdate { get; }
    
    // コンストラクタの定義 (クラス名と同じ名前にする)
    public GreatPerson(string name, DateTime birthdate) 
    {
        Name = name;
        Birthdate = birthdate;
    }
}
