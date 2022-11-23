using System;

var date = new DateTime(2020, 12, 1);

var type = date.GetType();
var methodInfo = type.GetMethod("AddDays");
var result = methodInfo.Invoke(date, new object[] { 3 });
Console.WriteLine(result);
