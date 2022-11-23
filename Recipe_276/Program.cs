using System.IO.Compression;

var src = "./source/example";
var dest = "./archives/myarchive.zip";
ZipFile.CreateFromDirectory(src, dest);