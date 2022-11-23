using System;
using System.Linq;

var dateStrs = new [] 
{ 
    "1868/10/23", "1912/7/30", "1926/12/25", "1989/1/8" 
};
var list = dateStrs.Select(x => DateTime.Parse(x)).ToList();
// List<T>なのでAddメソッドが使える
list.Add(new DateTime(2019, 5, 1));
// List<T>なのでCountプロパティが使える
Console.WriteLine($"要素数: {list.Count}");
