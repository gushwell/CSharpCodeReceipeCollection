using System;

var type = typeof(DateTime);
var argTypes = new Type[] { typeof(int), typeof(int), typeof(int) };
var ctor = type.GetConstructor(argTypes);
var instance = ctor.Invoke(new object[] { 2020, 11, 23 });
Console.WriteLine(instance);
