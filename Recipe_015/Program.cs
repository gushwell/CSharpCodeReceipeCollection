using System;

while (true) 
{
    var s = Console.ReadLine();
    if (string.IsNullOrEmpty(s))
    {
        // 空行を入れるとループを中断します
        Console.WriteLine("ループを中断します");
        break;
    }
    Console.WriteLine(s);
}

