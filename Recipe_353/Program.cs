using System;
using Xunit;

//namespace Gihyo {
public class MyTest
{
	[Fact]
	public void TestEqual()
	{
		var name = MySampleClass.Hello("kaori");
		Assert.Equal("hello kaori", name);
	}
	
	[Fact]
	public void TestTrue()
	{
		var over100 = MySampleClass.IsOver100(101);
		Assert.True(over100);
	}

	[Fact]
	public void TestOther()
	{
		Assert.NotEqual(1, 2);
		Assert.False(1 == 2);
		Assert.Null(null);
		Assert.NotNull(new int[1]);
		var array = new int[] { 1, 2, 3 };
		var array2 = array;
		Assert.Same(array, array2);
		Assert.NotSame(array, new int[] { 1, 2, 3 });
	}
}

// テスト対象のクラス
public static class MySampleClass
{
	public static string Hello(string name) => $"hello {name}";
	public static bool IsOver100(int num) => num > 100;
}

