using System;
using Xunit;

public class Program
{
	[Fact]
	public void TestRange()
	{
		var obj = new MySampleClass();
		for (int i = 0; i < 5; i++)
		{
			var value = obj.GetInt();
			Assert.InRange(value, 1, 7);
		}
		Assert.InRange(1, 1, 7);
	}
}

// テスト対象のクラス
public class MySampleClass
{
	private Random _rnd = new Random();
	// このメソッドをテストしたい
	public int GetInt()
	{
		return _rnd.Next(1, 8);
	}
}
