using System;

PrintValue();
PrintValue(new DateTime(2021, 5, 18));

static void PrintValue(DateTime dt = default) 
{
    Console.WriteLine(dt.ToString("yyyy/MM/dd"));
}
