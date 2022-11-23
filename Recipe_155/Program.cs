using System;
using System.Linq;

var names1 = new [] { "Apple", "Microsoft", "Google" };
var names2 = new [] { "Oracle", "Facebook", "Adobe", "Amazon" };

var names = names1.Concat(names2);
Console.WriteLine(string.Join(",", names));
