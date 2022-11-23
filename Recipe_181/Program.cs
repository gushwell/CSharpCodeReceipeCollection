using System;

// 利用例
var tm1 = new Time(13, 14, 5);
var tm2 = new Time(13, 14, 5);
var tm3 = new Time(13, 16, 21);
if (tm1 == tm2)
    Console.WriteLine("tm1 == tm2");
if (tm1 != tm3)
    Console.WriteLine("tm1 != tm3");
if (tm1 < tm3)
    Console.WriteLine("tm1 < tm3");


// 演算子をオーバーロードする例
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

    // 比較するためにintに変換
    private int ToInt32()
        => Hour * 10000 + Minute * 100 + Second;

    public override bool Equals(object obj)
        => ((Time)obj).ToInt32() == this.ToInt32();

    public override int GetHashCode()
        => ToInt32().GetHashCode();

    // オペレーターをオーバーロードをする
    public static bool operator ==(Time time1, Time time2)
        => time1.Equals(time2);

    public static bool operator !=(Time time1, Time time2)
        => !(time1 == time2);

    public static bool operator <(Time time1, Time time2)
        => time1.ToInt32() < time2.ToInt32();

    public static bool operator >(Time time1, Time time2)
        => time1.ToInt32() > time2.ToInt32();

    public static bool operator <=(Time time1, Time time2)
        => time1.ToInt32() <= time2.ToInt32();

    public static bool operator >=(Time time1, Time time2)
        => time1.ToInt32() >= time2.ToInt32();
}