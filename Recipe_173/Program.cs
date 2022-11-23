using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("ここで何らかの処理を実行");
            return;
        }
        finally
        {
            Console.WriteLine("後処理を実行");
        }
    }
}
