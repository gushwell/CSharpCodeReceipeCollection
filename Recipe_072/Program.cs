using System;
using System.Globalization;

var date = new DateTime(2020, 5, 1, 18, 5, 6, 140);
Console.WriteLine(date.ToString("g"));
Console.WriteLine(date.ToString("d"));
Console.WriteLine(date.ToString("D"));
Console.WriteLine(date.ToString("f"));
Console.WriteLine(date.ToString("m"));

var cultureInfo = new CultureInfo("en-us");
Console.WriteLine(date.ToString("g", cultureInfo));
Console.WriteLine(date.ToString("d", cultureInfo));
Console.WriteLine(date.ToString("D", cultureInfo));
Console.WriteLine(date.ToString("f", cultureInfo));
Console.WriteLine(date.ToString("m", cultureInfo));
