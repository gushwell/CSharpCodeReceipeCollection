using System;
using Xunit;
using Moq;

namespace Gihyo
{
	public class TargetClassTest
	{
		[Fact]
		public void TestGetName()
		{
			// IServiceのMockを作成
			var mock = new Mock<IService>();
			mock.Setup(m => m.CallService(It.IsAny<int>()))
				.Returns("name=HIDEYUKI");
			// TargetClassにMockを渡してGetNameをテスト
			var obj = new TargetClass(mock.Object);
			var name = obj.GetName(5);
			Assert.Equal("hideyuki", name);
		}
	}

	public class TargetClass
	{
		private readonly IService service;
		public TargetClass(IService service)
		{
			this.service = service;
		}
		public string GetName(int seed)
		{
			var name = service.CallService(seed);
			return name.Split('=')[1].ToLower();
		}
	}

	public interface IService
	{
		string CallService(int seed);
	}
}