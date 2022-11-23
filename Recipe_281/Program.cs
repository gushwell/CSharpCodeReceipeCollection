using System.IO;
using System.IO.Compression;

// Zip アーカイブ内のファイルを取得する 
var path = "./archives/myarchive.zip";
var file = "sub/0002.jpg";
var outpath = "0002.jpg";
using (var archive = ZipFile.Open(path, ZipArchiveMode.Read))
{
    var entry = archive.GetEntry(file);
    using (var reader = entry.Open())
    using (var writer = File.OpenWrite(outpath))
    {
        reader.CopyTo(writer);
    }
}
