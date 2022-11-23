using System;

var feet = 6.2;
double meter = FeetConverter.ToMeter(feet);
Console.WriteLine("{0:0.0} ft = {1:0.0000} m", feet, meter);
double feet2 = FeetConverter.FromMeter(meter);
Console.WriteLine("{0:0.0000} m = {1:0.0} ft", meter, feet2);

public static class FeetConverter
{
    private const double ratio = 0.3048;

    // メートルからフィートを求める
    public static double FromMeter(double meter)
    {
        return meter / ratio;
    }

    // フィートからメートルを求める
    public static double ToMeter(double feet)
    {
        return feet * ratio;
    }
}
