using System;
using System.IO;

try
{
    ReadFromFile("example.txt");
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
    if (e.InnerException != null)
        Console.WriteLine(e.InnerException.GetType());
}
catch (IOException e)
{
    Console.WriteLine($"予期しないIOエラーです。 {e.Message}");
}

static void ReadFromFile(string file) 
{
    try 
    {
        var lines = File.ReadAllLines(file);
        foreach (var line in lines) 
        {
            Console.WriteLine(line);
        }
    }
    catch (FileNotFoundException e)
    {
        // 別の例外にしてスロー あまり良い例ではない。あくまでもサンプル用
        throw new ArgumentException($"'{file}'は存在しないファイルです", e);
    }
    catch (IOException e)
    {
        // 同一例外を再スロー
        throw;
    }
}
