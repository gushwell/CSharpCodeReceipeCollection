using System;

var objects = new object[]
{
    10,
    1.5,
    100M,
    DateTime.Now,
    "Hello",
    new System.ArgumentException(),
};
foreach (var obj in objects)
{
    // オブジェクトの型情報を得る得る
    var type = obj.GetType();
    Console.WriteLine($"{type.Namespace}, {type.Name}, {type.FullName}");
}
