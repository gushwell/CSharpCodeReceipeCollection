using System;
using System.Reflection;

// プロパティの一覧を得る
var type = typeof(System.DateTime);
var properties = type.GetProperties(BindingFlags.Instance | BindingFlags.Public);
foreach (var p in properties)
{
    Console.WriteLine($"{p.Name}, {p.CanWrite}, {p.PropertyType}");
}
