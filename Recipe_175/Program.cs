using System;
using System.IO;

class Program 
{
    static void Main() 
    {
        // using宣言
        using var reader = new StreamReader("example.txt");
        while (!reader.EndOfStream)
        {
            var line = reader.ReadLine();
            Console.WriteLine(line);
        }
    }
}
