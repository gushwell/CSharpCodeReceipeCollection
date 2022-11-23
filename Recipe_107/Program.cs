using System;

var time1 = new Time(DateTime.Now);
var time2 = new Time(10, 6, 48);

public readonly struct Time
{
    public int Hour { get; }
    public int Minute { get; }
    public int Second { get; }

    // コンストラクター (1)
    public Time(int hour = 0, int minute = 0, int second = 0)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    // コンストラクター (2)
    // this キーワードを使い引数3つのコンストラクターを呼び出す
    public Time(DateTime time)
        : this(time.Hour, time.Minute, time.Second) { }
}
