using System;
using Xunit;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace Gihyo
{
	public class RandomStringTest
	{
		private Mock<RandomString> _mock;
		private RandomString _obj;
		public RandomStringTest()
		{
			_mock = new Mock<RandomString> { CallBase = true };
			_obj = _mock.Object;
		}

		[Fact]
		public void TestRandomString()
		{
			var calls = 1;
			// GetLengthメソッドの戻り値を設定する
			_mock.Setup(m => m.GetLength(It.IsAny<int>(), It.IsAny<int>()))
					.Returns(5);
			// GetIndexメソッドの戻り値を設定する
			_mock.Setup(m => m.GetIndex())
					.Returns(() => calls)
					.Callback(() => calls++);
			// Nextメソッドが正しく動作しているかを確かめる
			var value = _obj.Next(3, 8);
			Assert.Equal("BCDEF", value);
		}
	}

	public class RandomString
	{
		private readonly Random _random = new Random();
		private readonly string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";

		// 生成する文字列の長さを求める
		public virtual int GetLength(int minLength, int maxLength) =>
			_random.Next(minLength, maxLength + 1);

		// 文字を決定するために、_charsのインデックスを求める
		public virtual int GetIndex() => _random.Next(_chars.Length);

		// ランダムな文字列を生成する
		public string Next(int minLength = 0, int maxLength = 10)
		{
			var length = GetLength(minLength, maxLength);
			var chars = Enumerable.Repeat(0, length)
				.Select(_ => GetIndex())
				.Select(i => _chars[i]).ToArray();
			return new string(chars);
		}
	}
}
