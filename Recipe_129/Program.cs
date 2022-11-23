using System;
using System.Linq;

{
    var names = new[] 
    {
        "Apple", "Microsoft", "Google", "Oracle",
        "Facebook", "Adobe", "Amazon"
    };
    var name = names.First();
    Console.WriteLine(name);
    var name2 = names.FirstOrDefault();
    Console.WriteLine(name2 ?? "<Not Found>");
}

// 以降、発展で示したコード
{
    var names = new [] 
    {
        "Apple", "Microsoft", "Google", "Oracle",
        "Facebook", "Adobe", "Amazon"
    };
    var name = names.First(n => n.Length > 8);
    Console.WriteLine(name);
    var name2 = names.FirstOrDefault(n => n.Length > 10);
    Console.WriteLine(name2 ?? "<Not Found>");
}

