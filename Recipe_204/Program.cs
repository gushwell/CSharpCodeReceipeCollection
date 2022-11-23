using System;
using System.IO;

var driveType = DriveType.Network;
var drivetext = driveType switch
{
    DriveType.Fixed => "固定ディスク",
    DriveType.Network => "ネットワークドライブ",
    DriveType.Removable => "リムーバブルディスク",
    DriveType.CDRom => "光ディスクドライブ",
    _ => "その他のドライブ"
};
Console.WriteLine(drivetext);

// これは発展で示したコード
var num = 10;
var str = num switch
{
    < 0 => "マイナス",
    0 => "ゼロ",
    > 0 => "プラス"
};
Console.WriteLine(str);
