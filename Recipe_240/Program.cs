using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;


Type type = typeof(Product);
var prop = type.GetProperty("Name");
var isDefined = prop.IsDefined(typeof(MaxLengthAttribute));
if (isDefined)
{
    Console.WriteLine("MaxLengthAttributeが適用されています");
}

public class Product
{
    [MaxLength(100)]
    public string Name { get; set; }
    public int UnitPrice { get; set; }
}
