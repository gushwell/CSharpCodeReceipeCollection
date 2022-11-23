using System;

// ToString() のコード
{
    var num1 = 1234567;
    var str1 = num1.ToString("D");               // 1234567
    var str2 = num1.ToString("E");               // 1.234567E+006
    var str3 = num1.ToString("D10");             // 0001234567
    var str4 = num1.ToString("0000000000");      // 0001234567
    var str5 = num1.ToString("#,0");             // 1,234,567

    var num2 = 123.45;
    var str6 = num2.ToString("F");               // 123.45
    var str7 = num2.ToString("E");               // 1.234500E+002
    var str8 = num2.ToString("F4");              // 123.4500
    var str9 = num2.ToString("00000.000");       // 00123.450
    var str10 = num2.ToString("#,0.0");          // 123.5

    Console.WriteLine(str1);
    Console.WriteLine(str2);
    Console.WriteLine(str3);
    Console.WriteLine(str4);
    Console.WriteLine(str5);
    Console.WriteLine("---");
    Console.WriteLine(str6);
    Console.WriteLine(str7);
    Console.WriteLine(str8);
    Console.WriteLine(str9);
    Console.WriteLine(str10);
    Console.WriteLine();
}

// string.Format() のコード
{
    var num1 = 1234567;
    var str1 = string.Format("{0:D}", num1);            // 1234567
    var str2 = string.Format("{0:E}", num1);            // 1.234567E+006
    var str3 = string.Format("{0:D10}", num1);          // 0001234567
    var str4 = string.Format("{0:0000000000}", num1);   // 0001234567
    var str5 = string.Format("{0:#,0}", num1);          // 1,234,567

    var num2 = 123.45;
    var str6 = string.Format("{0:F}", num2);            // 123.45
    var str7 = string.Format("{0:E}", num2);            // 1.234500E+002
    var str8 = string.Format("{0:F4}", num2);           // 123.4500
    var str9 = string.Format("{0:00000.000}", num2);    // 00123.450
    var str10 = string.Format("{0:#,0.00}", num2);      // 123.45

    Console.WriteLine(str1);
    Console.WriteLine(str2);
    Console.WriteLine(str3);
    Console.WriteLine(str4);
    Console.WriteLine(str5);
    Console.WriteLine("---");
    Console.WriteLine(str6);
    Console.WriteLine(str7);
    Console.WriteLine(str8);
    Console.WriteLine(str9);
    Console.WriteLine(str10);
    Console.WriteLine();
}

// 発展のコード
{
    var num = 1234567;
    var str1 = $"{num:D}";             // 1234567
    var str2 = $"{num:E}";             // 1.234567E+006
    var str3 = $"{num:D10}";           // 0001234567
    var str4 = $"{num:0000000000}";    // 0001234567
    var str5 = $"{num:#,0}";           // 1,234,567
    var num2 = 123.45;
    var str6 = $"{num2:F}";          // 123.45
    var str7 = $"{num2:E}";          // 1.234500E+002
    var str8 = $"{num2:F4}";         // 123.4500
    var str9 = $"{num2:00000.000}";  // 00123.450
    var str10 = $"{num2:#,0.00}";    // 123.45

    Console.WriteLine(str1);
    Console.WriteLine(str2);
    Console.WriteLine(str3);
    Console.WriteLine(str4);
    Console.WriteLine(str5);
    Console.WriteLine("---");
    Console.WriteLine(str6);
    Console.WriteLine(str7);
    Console.WriteLine(str8);
    Console.WriteLine(str9);
    Console.WriteLine(str10);
}


