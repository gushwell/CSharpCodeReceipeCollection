using System;
using System.Runtime.CompilerServices;

class Program
{
	static void Main()
	{
        DoSomething();
    }

	static void DoSomething(
			[CallerFilePath] string file = "",
			[CallerLineNumber] int line = 0,
			[CallerMemberName] string member = "")
	{
		Console.WriteLine(file);
		Console.WriteLine(line);
		Console.WriteLine(member);
	}
}
