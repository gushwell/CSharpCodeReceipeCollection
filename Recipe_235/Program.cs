using System;
using System.Reflection;

var type = typeof(System.Object);
var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public);
foreach (var m in methods)
{
    Console.WriteLine($"{m.Name}, {m.ReturnType}, {m.GetParameters().Length}");
}
