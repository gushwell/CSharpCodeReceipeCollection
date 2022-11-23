using System;
using Moq;

namespace Gihyo
{
	class Program
	{
		static void Main()
		{
			// 1. 特定の引数にのみに対応するメソッド
			var mock1 = new Mock<IFizzBuzz>();
			mock1.Setup(m => m.GetText(3))
				 .Returns("Fizz");
			Console.WriteLine(mock1.Object.GetText(3));
			Console.WriteLine("---");

			// 2. ある条件に一致する引数に対応するメソッド
			var mock2 = new Mock<IFizzBuzz>();
			mock2.Setup(m => m.GetText(It.Is<int>(n => n % 5 == 0 && n % 15 != 0)))
				 .Returns<int>(n => "Buzz");
			Console.WriteLine(mock2.Object.GetText(5));
			Console.WriteLine(mock2.Object.GetText(10));
			// 指定した条件以外の引数が与えられた時は、default値(参照型でははnull)が返る。
			Console.WriteLine(mock2.Object.GetText(15));
			Console.WriteLine(mock2.Object.GetText(20));
			Console.WriteLine("---");

			// 3. 任意の引数に対応するメソッド
			var mock3 = new Mock<IFizzBuzz>();
			mock3.Setup(m => m.GetText(It.IsAny<int>()))
				.Returns<int>(n =>
				{
					if (n % 15 == 0) return "FizzBuzz";
					if (n % 5 == 0) return "Buzz";
					if (n % 3 == 0) return "Fizz";
					return n.ToString();
				});
			for (int i = 1; i <= 15; i += 2)
			{
				Console.WriteLine($"{i}: {mock3.Object.GetText(i)}");
			}
		}
	}

	public interface IFizzBuzz
	{
		string GetText(int n);
	}
}
