using System;

try 
{
    var totalValue = 0;
    var value = 132;
    var rate = (value / totalValue) * 100;
    // 上の行で例外が発生するため、次の行は実行されない。
    Console.WriteLine(rate);
} 
catch (DivideByZeroException e) 
{
    // ここに例外発生時の処理を書く。
}
