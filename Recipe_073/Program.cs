using System;
{
    var fruits = new string[5];
    fruits[0] = "apple";
    fruits[1] = "orange";
    fruits[2] = "banana";
    fruits[3] = "cherry";
    fruits[4] = "blueberry";
    Console.WriteLine(fruits[0]);
    Console.WriteLine(fruits[2]);
    Console.WriteLine(fruits[4]);
}

// 以下発展で示したコード
{
    var fruits = new string[] {
        "apple", "orange", "banana", "cherry", "blueberry"
    };
}
{
    var fruits = new[] {
        "apple", "orange", "banana", "cherry", "blueberry"
    };
}
