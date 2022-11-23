using System;

// 名前付き引数を利用しメソッドを呼び出す例
ExampleMethod(5, optionalInt: 20);
ExampleMethod(optionalStr: "hello", required: 10);

// メソッドの定義例
static void ExampleMethod(
        int required,
        string optionalStr = "default string",
        int optionalInt = 10)
{
    Console.Write($"required={required}, ");
    Console.Write($"optionalStr={optionalStr}, ");
    Console.WriteLine($"optionalInt={optionalInt}");
}
