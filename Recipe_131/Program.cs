using System;
using System.Linq;

var names = new [] 
{
    "Apple", "Microsoft", "Google", "Oracle", "Facebook"
};
var name = names.OrderBy(n => n.Length)
                .ElementAt(1);
Console.WriteLine(name);
