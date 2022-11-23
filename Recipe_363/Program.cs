using System;
using Moq;

namespace Gihyo
{
	class Program
	{
		static void Main()
		{
			var mock = new Mock<IFizzBuzz>();
			// 引数が0以下なら、例外を発生させる。
			mock.Setup(m => m.GetText(It.Is<int>(n => n <= 0)))
				.Throws<ArgumentOutOfRangeException>();
			// 引数が3なら、"Fizz"を返す
			mock.Setup(m => m.GetText(3))
				.Returns("Fizz");

			try
			{
				Console.WriteLine(mock.Object.GetText(3));
				// 次のコードで例外発生
				Console.WriteLine(mock.Object.GetText(0));
			}
			catch (ArgumentOutOfRangeException e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}

	public interface IFizzBuzz
	{
		string GetText(int n);
	}
}
