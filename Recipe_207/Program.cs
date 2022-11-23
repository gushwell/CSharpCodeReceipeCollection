using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var words = new[]
        {
            "StringBuilder", "ToSnakeCase", "IsLetter", "ToLower"
        };
        foreach (var word in words)
        {
            var snakecase = ToSnakeCase(word);
            Console.WriteLine(snakecase);
        }

        // ローカル関数 (メソッドの中に定義できる)
        string ToSnakeCase(string value)
        {
            var seq = value.Select((x, i) => i > 0 && char.IsUpper(x)
                ? "_" + x.ToString() : x.ToString());
            return string.Concat(seq).ToLower();
        }
    }
}