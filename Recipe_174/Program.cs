using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (var reader = new StreamReader("example.txt"))
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                Console.WriteLine(line);
            }
        }

        // これは補足で示したコードと同じ
        static void Sample()
        {
            var reader = new StreamReader("example.txt");
            try
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    Console.WriteLine(line);
                }
            }
            finally
            {
                reader.Dispose();
            }
        }
    }
}
