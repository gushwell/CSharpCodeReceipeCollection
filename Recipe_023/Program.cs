using System;

var nums = new double[] { 2.13, 2.14, 2.15, 2.16, 
                          2.23, 2.24, 2.25, 2.26 };
foreach (var n in nums) 
{
    var round1 = Math.Round(n, 1, MidpointRounding.AwayFromZero);
    var round2 = Math.Round(n, 1, MidpointRounding.ToEven);
    Console.WriteLine($"{n:#.#0} : {round1:#.0},  {round2:#.0}");
}
