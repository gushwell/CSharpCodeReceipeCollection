using System.IO;
using System.Text;

var path = "test.dat";
var str = "The quick onyx goblin jumps over the lazy dwarf.";
var bytes = Encoding.GetEncoding("utf-8").GetBytes(str);
// FileMode.Create: 新しいファイルを作成することを指定します。 
// ファイルが既に存在する場合は上書きされます。
using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
{
    fs.Write(bytes, 0, bytes.Length);
}