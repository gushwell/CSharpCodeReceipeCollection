﻿using System;

var bytes = new byte[] {
	0x4a, 0x30, 0x6f, 0x30, 0x88, 0x30, 0x46, 0x30, 0x54, 0x30,
	0x56, 0x30, 0x44, 0x30, 0x7e, 0x30, 0x59, 0x30, 0x02, 0x30 
};
var n = 0;
foreach (var b in bytes)
{
	Console.Write($"{b:x2} ");
	if (++n == 16)
	{
		Console.WriteLine();
		n = 0;
	}
}
Console.WriteLine();

