using System;
using System.IO;


var lines = new string[] {
        "祇園精舎の鐘の声、諸行無常の響きあり。",
        "沙羅双樹の花の色、盛者必衰の理をあらはす。",
        "驕れる人も久しからず、ただ春の夜の夢のごとし。",
        "猛き者も遂にはほろびぬ、ひとへに風の前の塵におなじ。"
};
// 既存ファイルは上書きされる
File.WriteAllLines("平家物語.txt", lines);


// 以下のようなコードもあり
using (var writer = new StreamWriter("test.txt"))
{
    foreach (var line in lines)
    {
        writer.WriteLine(line);
    }
    writer.Close();
}
