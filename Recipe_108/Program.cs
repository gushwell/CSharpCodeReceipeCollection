using System;

// 利用例
var employee = new Employee 
{
    Name = "町田浩輔",
    Birthdate = new DateTime(1997, 11, 28),
    HireDate = new DateTime(2019, 4, 1),
    Department = "ソフトウェア開発部"
};
Console.WriteLine($"{employee.Name} {employee.HireDate.Year}年入社");

// 既定クラスの定義例
public class Person 
{
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }
}

// 派生クラスの定義例
public class Employee : Person 
{
    public string Department { get; set; }
    public DateTime HireDate { get; set; }
}
