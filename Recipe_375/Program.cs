using System;

var guid = Guid.NewGuid();
Console.WriteLine(guid.ToString());  // "D"形式で出力
Console.WriteLine($"D {guid.ToString("D")}");
Console.WriteLine($"N {guid.ToString("N")}");
Console.WriteLine($"B {guid.ToString("B")}");
Console.WriteLine($"P {guid.ToString("P")}");
Console.WriteLine($"X {guid.ToString("X")}");
