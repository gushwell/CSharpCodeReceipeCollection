using System;

var time = new Time(13, 14, 5);
// TimeオブジェクトからTimeSpanオブジェクトへ型変換
var timeSpan = (TimeSpan)time;
Console.WriteLine($"{timeSpan.GetType().Name} {timeSpan}");
// TimeSpanオブジェクトからTimeオブジェクトへ型変換
var time2 = (Time)timeSpan;
Console.WriteLine($"{time2.GetType().Name} {time2.Hour}:{time2.Minute}:{time2.Second}");

// キャスト式による型変換を可能にする例
public readonly struct Time
{
    public int Hour { get; }
    public int Minute { get; }
    public int Second { get; }

    public Time(int hour, int minute = 0, int second = 0)
    {
        Hour = hour;
        Minute = minute;
        Second = second;
    }

    // (TimeSpan)による型変換を可能にする
    public static explicit operator TimeSpan(Time time)
        => new TimeSpan(time.Hour, time.Minute, time.Second);

    // (Time)による型変換を可能にする
    public static explicit operator Time(TimeSpan time)
        => new Time(time.Hours, time.Minutes, time.Seconds);
}