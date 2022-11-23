using System;
using System.Linq;

var names = new [] 
{ 
    "Apple", "Microsoft", "Google", "Apple", "Microsoft", 
    "Adobe", "Oracle", "Facebook", "Adobe", "Amazon" 
};

var query = names.Distinct()
                 .OrderBy(x => x);
Console.WriteLine(String.Join(',', query));
