using System;
using Xunit;

public class Program
{
	[Fact]
	public void TestException()
	{
		var obj = new MySampleClass();
		var ex = Assert.Throws<ArgumentNullException>(() =>
		{
			obj.TestMethod(null);
		});
	}
}

// テスト対象のクラス
public class MySampleClass
{
	// このメソッドをテストしたい
	public void TestMethod(object o)
	{
		if (o == null)
			throw new ArgumentNullException();
	}
}

