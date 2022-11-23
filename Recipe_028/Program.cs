using System;

static string ToBinary(int n) 
{
    return Convert.ToString(n, 2).PadLeft(16, '0');
}

ushort num = 0b_0000_0011_0001_1000;

// 下位から6ビット目をOn （0ビット目から数える)
var n = 6;
var biton = num | 1 << n;
Console.WriteLine($"{n}ビット目をOn\t{ToBinary(biton)}");

// 下位から4ビット目をOff （0ビット目から数える)
var n2 = 4;
var bitoff = num & ~(1 << n2);
Console.WriteLine($"{n2}ビット目をOff\t{ToBinary(bitoff)}");
