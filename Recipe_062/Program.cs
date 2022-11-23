using System;

// 日付を比較する
var date1 = new DateTime(2020, 5, 31);
var date2 = new DateTime(2020, 6, 1);
if (date1 < date2)
    Console.WriteLine("date1よりdate2が新しい日付です");

else if (date1 == date2)
    Console.WriteLine("date1とdate2は同じ日付です");
    
else if (date1 > date2)
    Console.WriteLine("date2よりdate1が新しい日付です");
