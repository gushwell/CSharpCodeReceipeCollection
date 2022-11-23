using System;


// 現在のプロセス環境ブロックで、環境変数をセットする
var envvar = "MyEnv";
Environment.SetEnvironmentVariable(envvar, "Value1");
var envval = Environment.GetEnvironmentVariable(envvar);
Console.WriteLine($"{envvar}={envval}");

// 現在のプロセス環境ブロックで、環境変数をクリアする
Environment.SetEnvironmentVariable(envvar, null);
var envval2 = Environment.GetEnvironmentVariable(envvar);
Console.WriteLine($"{envvar}={envval2}");
