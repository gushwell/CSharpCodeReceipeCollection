using Xunit;

namespace Gihyo
{
	public class MyClass
	{
		// テストコード
		[Fact]
		public void Test()
		{
			var ans = Add(2, 2);
			Assert.Equal(4, ans);
		}

		// テスト対象のメソッド
		int Add(int x, int y)
		{
			return x + y;
		}
	}
}