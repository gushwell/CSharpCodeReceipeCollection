using System;
using System.Collections.Generic;
using Xunit;

public class StackTests : IDisposable
{
	private Stack<int> _stack;

	public StackTests()
	{
		_stack = new Stack<int>();
	}

	public void Dispose()
	{
		// 必要ならここで後処理を書く。
	}

	[Fact]
	public void Test1()
	{
		_stack.Push(42);
		var count = _stack.Count;
		Assert.Equal(1, count);
	}

	[Fact]
	public void Test2()
	{
		_stack.Push(11);
		var val = _stack.Pop();
		var count = _stack.Count;
		Assert.Equal(11, val);
		Assert.Equal(0, count);
	}
}
