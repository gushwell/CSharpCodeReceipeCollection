using System;
using System.Linq;

var sports = new [] 
{
    "tennis", "basketball", "baseball", "skating"
};
var newseq = sports.Prepend("skiing"); 
Console.WriteLine(string.Join(", ", newseq));

var newseq2 = sports.Append("skiing"); 
Console.WriteLine(string.Join(", ", newseq2));
