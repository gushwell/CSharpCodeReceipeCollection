using System;

// ループ処理を記述する (for)
{
    var sum = 0;
    for (var n = 1; n <= 100; n++)
    {
        sum += n;
    }
    Console.WriteLine(sum);
}

// ループ処理を記述する (while)
{
    var sum = 0;
    var n = 0;
    while (n <= 100)
    {
        sum += n;
        n++;
    }
    Console.WriteLine(sum);
}

// ループ処理を記述する (do-while)
{
    var sum = 0;
    var n = 0;
    do
    {
        sum += n;
        n++;
    } while (n <= 100);
    Console.WriteLine(sum);
}
