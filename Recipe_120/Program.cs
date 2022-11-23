using System;

{
    string encoding = null;
    var text2 = "エンコーディング: " + (encoding ?? "UTF-8");
    Console.WriteLine(text2);
}

// 以降は、補足で示したコード
{
    string encoding = null;
    var text = "エンコーディング: ";
    if (encoding == null)
        text += "UTF-8";
    else
        text += encoding;
    Console.WriteLine(text);
}
