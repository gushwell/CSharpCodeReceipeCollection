using System;
using System.IO;

var srcPath = "example.txt";
var destPath = "sub/clone.txt";
if (File.Exists(srcPath))
{
    // 既存ファイルの上書きは許可しない
    File.Copy(srcPath, destPath, overwrite: false);
    // ファイルを削除する
    File.Delete(srcPath);
}
else if (File.Exists(destPath))
{
    // カレントフォルダへ移動する
    var destPath2 = "./clone.txt";
    File.Move(destPath, destPath2);
    // ファイルをリネームする　(同一フォルダならリネームと同じ)
    File.Move(destPath2, srcPath);
}

