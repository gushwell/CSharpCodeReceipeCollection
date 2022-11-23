using System;

// 利用例
var product = new Product
{
    Name = "スマートスピーカー",
    UnitPrice = 9800,
    StartDate = new DateTime(2019, 5, 10)
};
var clone = product.ShallowCopy();
Console.WriteLine(clone.Name);
Console.WriteLine(clone.UnitPrice);
Console.WriteLine(clone.StartDate);

// 定義例
class Product
{
    public string Name { get; set; }
    public int UnitPrice { get; set; }
    public DateTime StartDate { get; set; }

    public Product ShallowCopy() => (Product)this.MemberwiseClone();
}


