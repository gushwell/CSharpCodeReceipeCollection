using System;
using Moq;

namespace Gihyo
{
	class Program
	{
		static void Main()
		{
			var mock = new Mock<IFizzBuzz>();
			// GetTextメソッドが呼び出された際にに実行するコードを
			// Callbackで指定している。ただし、引数が3で割り切れた時のみ
			// 戻り値はReturnsで指定する。
			mock.Setup(m => m.GetText(It.Is<int>(n => n % 3 == 0)))
				.Callback<int>(n => { Console.WriteLine($"引数は{n}です"); })
				.Returns<int>(n => "Fizz");
			Console.WriteLine(mock.Object.GetText(6));
		}
	}

	public interface IFizzBuzz
	{
		string GetText(int n);
	}
}
