using System;
using Xunit;
using Xunit.Abstractions;

namespace Gihyo
{
	public class TestClass
	{
		private readonly ITestOutputHelper _logger;

		public TestClass(ITestOutputHelper output)
		{
			_logger = output;
		}

		[Theory]
		[InlineData(10, 16, -6)]
		[InlineData(10, 20, -10)]
		public void TestAdd(int expected, int x, int y)
		{
			_logger.WriteLine($"{x} {y}");
			var obj = new MySampleClass();
			var val = obj.Add(x, y);
			Assert.Equal(expected, val);
		}
	}

	// テスト対象のクラス
	public class MySampleClass
	{
		// このメソッドをテストしたい
		public int Add(int x, int y)
		{
			return x + y;
		}
	}
}
