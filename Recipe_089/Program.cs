using System;
using System.Collections.Generic;

{
    var fruits = new List<string> 
    {
        "apple", "orange", "banana", "cherry", "blueberry"
    };
    fruits.ForEach(x => Console.WriteLine(x.ToUpper()));
}

// 以下、補足で示したコード
{
    var fruits = new [] 
    {
        "apple", "orange", "banana", "cherry", "blueberry"
    };
    Array.ForEach(fruits, x => Console.WriteLine(x.ToUpper()));
}
