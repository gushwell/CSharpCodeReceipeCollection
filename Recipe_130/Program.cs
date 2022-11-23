using System;
using System.Linq;

{
    var names = new[] 
    {
        "Apple", "Microsoft", "Google", "Oracle", 
        "Facebook", "Adobe", "Amazon" 
    };
    var name = names.Last();
    Console.WriteLine(name);
    var name2 = names.LastOrDefault();
    Console.WriteLine(name2 ?? "<Not Found>");
}

// 以降、発展で示したコード
{
    var names = new[]
    {
        "Apple", "Microsoft", "Google", "Oracle",
        "Facebook", "Adobe", "Amazon"
    };
    var name = names.Last(n => n.Length >= 8);
    Console.WriteLine(name);
    var name2 = names.LastOrDefault(n => n.Length > 10);
    Console.WriteLine(name2 ?? "<Not Found>");
}

