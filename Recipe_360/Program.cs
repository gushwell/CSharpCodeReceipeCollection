using System;
using Moq;

namespace Gihyo
{
	class Program
	{
		static void Main()
		{
			// Mockオブジェクトを生成する
			var mock = new Mock<IProduct>();
			// 以降の処理で、mockにプロパティやメソッドを定義していく
			// ...
		}
	}

	public interface IProduct
	{
		// ...
	}
}
