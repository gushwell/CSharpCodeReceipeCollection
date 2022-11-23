using System;

try 
{
    var win = 0;
    var lose = 0;
    var rate = GetRate(win, lose);
} 
catch (ArgumentException ex) 
{
    Console.WriteLine(ex.Message);
}

static int GetRate(int win, int lose) 
{
    if (win + lose == 0) 
    {
        var msg = $"win+loseの値が0です。win={win} lose={lose}";
        // 例外をスローする
        throw new ArgumentException(msg);
    }
    return (win / (win + lose)) * 100;
}
