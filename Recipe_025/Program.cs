using System;

var d = 0.0;
for (int i = 0; i < 100; i++) 
{
    d += 0.01;
}
// == で比較
Console.WriteLine(d == 1.0 ? "等しい" : "等しくない");

// 作成したメソッドで比較
Console.WriteLine(DoubleEquals(d, 1.0) ? "等しい" : "等しくない");

// ふたつのdoubleが等しいかを調べるメソッド
static bool DoubleEquals(double a, double b) 
{
    var difference = a * 1.0E-14;
    return Math.Abs(a - b) <= difference;
}

