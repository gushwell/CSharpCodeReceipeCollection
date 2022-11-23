using System;

// ## 型名を明示したサンプルコード
{
    char ch = 'A';
    bool isEmpty = true;
    short month = 12;
    int temperature = 1;
    uint pageNumber = 100;
    long count = 500;
    double weight = 52.8;
    decimal money = 3_410_000;
    string message = "hello world.";
    DateTime birthdate = new DateTime(1998, 6, 19);
}

//varキーワード利用したサンプルコード
{
    var ch = 'A';
    var isEmpty = true;
    var month = (short)12;  // shortのサフィックスは存在しないためキャストを使う
    var temperature = 1;
    var pageNumber = 100U;
    var count = 500L;
    var weight = 52.8;
    var money = 3_410_000M;
    var message = "hello world.";
    var birthdate = new DateTime(1998, 6, 19);
}

