using System;

// checkedブロック
{
    try 
    {
        var num = int.MaxValue - 5;
        checked 
        {
            num += 6;
        }
        Console.WriteLine (num);
    } 
    catch (OverflowException e) 
    {
        Console.WriteLine (e.Message);
    }
}

// checked式
{
    try 
    {
        var num = int.MaxValue - 5;
        num = checked (num + 6);
        Console.WriteLine (num);
    } 
    catch (OverflowException e) 
    {
        Console.WriteLine (e.Message);
    }
}
