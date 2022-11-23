using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

Type type = typeof(Product);
PrintDisplayName(type, nameof(Product.ProductName));
PrintDisplayName(type, nameof(Product.UnitPrice));

// Display属性のNameプロパティの値をプリントする
static void PrintDisplayName(Type type, string name)
{
    var prop = type.GetProperty(name);
    var attr = prop.GetCustomAttribute<DisplayAttribute>();
    if (attr != null)
    {
        Console.WriteLine($"{name} = {attr.Name}");
    }
}

public class Product
{
    [Display(Name = "商品名")]
    public string ProductName { get; set; }

    [Display(Name = "商品単価")]
    public int UnitPrice { get; set; }
}
