using System;
using System.Threading.Tasks;

var collection = new int[] { 1, 2, 3, 4 };
Parallel.ForEach(collection, item => Process(item));

static void Process(int item)
{
    Console.WriteLine($"Begin: {item}");
    System.Threading.Thread.Sleep(20);
    Console.WriteLine($"{item}");
    Console.WriteLine($"End:   {item}");
}
