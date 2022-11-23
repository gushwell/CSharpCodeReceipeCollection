using System.IO;
using System.IO.Compression;

var zipfile = "./archives/myarchive.zip";
var file = "./readme.md";
using (var archive = ZipFile.Open(zipfile, ZipArchiveMode.Update))
{
    var entry = archive.CreateEntry(Path.GetFileName(file));
    using (var writer = entry.Open())
    using (var reader = File.Open(file, FileMode.Open))
    {
        reader.CopyTo(writer);
    }
}