using System;

var cust = new SampleCustomer();
cust.Grade = 2;
cust.JoinDate = new DateTime(2013, 6, 9);
var price = 10000 * (1 - cust.DiscountRate());
Console.WriteLine(price);

public interface ICustomer 
{
    string Name { get; }
    int Grade { get; set; }
    // 既定の動作
    public decimal DiscountRate() => DefaultDiscountRate(this);

	// DefaultDiscountRateをpublicにしないためのテクニック
	protected static decimal DefaultDiscountRate(ICustomer c) 
    {
        return c.Grade switch 
        {
            2 => 0.05m,
            3 => 0.1m,
            _ => 0.0m
        };
    }
}

public class SampleCustomer : ICustomer
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public DateTime JoinDate { get; set; }

    // 既定の動作を上書きする
    public decimal DiscountRate()
    {
        if (JoinDate.AddYears(3) < DateTime.Today)
            return 0.1m;
        return ICustomer.DefaultDiscountRate(this);
    }
}