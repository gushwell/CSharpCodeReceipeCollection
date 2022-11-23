using System;
using System.Linq;

var array = new [] 
{
    new { Name = "Strawberries", Color = "Red" },
    new { Name = "Lemons", Color = "Yellow" },
    new { Name = "Avocados", Color = "Green" },
    new { Name = "Blueberries", Color = "Purple" },
    new { Name = "Oranges", Color = "Orange" },
};
var item = array.FirstOrDefault(x => x.Color == "White");
// itemがnullで無いなら、item.Colorがcolorに代入される 
// itemがnullならnullがcolorに代入される
var color = item?.Color;
Console.WriteLine($"[{color}]");


