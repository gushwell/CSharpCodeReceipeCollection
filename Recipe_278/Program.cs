using System;
using System.IO.Compression;

// Zip アーカイブからファイルを削除する
var zipfile = "./archives/myarchive.zip";
//var entry = "sub/0001.jpg";
var entry = ".DS_Store";
using (ZipArchive a = ZipFile.Open(zipfile, ZipArchiveMode.Update))
{
    ZipArchiveEntry e = a.GetEntry(entry);
    if (e == null)
    {
        //見つからなかった時
        Console.WriteLine($"{entry}が見つかりませんでした。");
    }
    else
    {
        //見つかった時は削除する
        e.Delete();
    }
}