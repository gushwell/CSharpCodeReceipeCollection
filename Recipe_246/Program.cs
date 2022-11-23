using System;
using System.Reflection;

var product = new Product();
if (product.Name == null && product.Description == null && product.ImageUrl == null)
{
    Console.WriteLine("すべてがnullです");
}
NullToEmptyString(product);
if (product.Name == "" && product.Description == "" && product.ImageUrl == "")
{
    Console.WriteLine("すべてが空文字列です");
}

// String型のプロパティがnullなら空文字列に変更
static void NullToEmptyString<T>(T value)
{
    var type = value.GetType();
    var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
    foreach (var prop in props)
    {
        if (prop.PropertyType != typeof(string))
            continue;
        if (!prop.CanWrite)
            continue;
        if (prop.GetValue(value) == null)
            prop.SetValue(value, String.Empty);
    }
}

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public int UnitPrice { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
}