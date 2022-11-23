using System.IO.Compression;

// Zip アーカイブの内容をディレクトリに抽出する
var path = "./archives/myarchive.zip";
ZipFile.ExtractToDirectory(path, "./extract");
