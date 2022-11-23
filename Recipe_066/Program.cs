using System;

{
    // ふたつの日付の差を求める
    var date1 = new DateTime(2020, 5, 1);
    var date2 = new DateTime(2020, 5, 20);
    var diff = date2 - date1;
    Console.WriteLine($"{diff} {diff.GetType()}");
}

// 以下、発展で示したコード
{
    var date1 = new DateTime(2020, 5, 1, 5, 6, 0);
    var date2 = new DateTime(2020, 5, 20, 4, 10, 0);
    var diff = date2 - date1;
    Console.WriteLine($"{diff} {diff.GetType()}");
}
{
    var date1 = new DateTime(2020, 5, 1, 5, 6, 0);
    var date2 = new DateTime(2020, 5, 20, 4, 10, 0);
    var diff = date2.Date - date1.Date;
    Console.WriteLine($"{diff} {diff.GetType()}");
}

