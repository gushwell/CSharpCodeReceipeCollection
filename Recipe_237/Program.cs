using System;
using System.Reflection;
using System.Linq;

var type = typeof(System.Exception);
var constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
foreach (var c in constructors)
{
    // コンストラクタのパラメータを得る
    var parameters = c.GetParameters()
        .Select(x => x.ParameterType.Name).ToArray();
    var argstr = string.Join(",", parameters);
    Console.WriteLine($"{c.Name} {argstr}");
}

