using System;
using System.IO.Compression;

// Zip アーカイブからファイル一覧を得る
var zipfile = "./archives/myarchive.zip";
using (var archive = ZipFile.OpenRead(zipfile))
{
    // EntriesプロパティからEntryを取り出す
    foreach (var entry in archive.Entries)
    {
        Console.WriteLine(entry.FullName);
    }
}

