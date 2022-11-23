using System;

 var num = -14;
var isEvenAndMinus = (num % 2 == 0) && num < 0;
if (isEvenAndMinus)
{
    Console.WriteLine($"{num}は偶数かつマイナスです");
}
var weather = "曇り";
if (weather == "曇り" || weather == "晴れ")
{
    Console.WriteLine("買い物に行きます");
}
