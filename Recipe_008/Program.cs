using System;

// 式の値に応じて、処理を分岐させる (switch)
var size = "M";
string message;
switch (size)
{
    case "S":
        message = "サイズはSです";
        break;
    case "M":
        message = "サイズはMです";
        break;
    case "L":
        message = "サイズはLです";
        break;
    default:
        message = "サイズはそれ以外です";
        break;
}
Console.WriteLine(message);
