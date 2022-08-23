using System;
class ClockAngle
{
    static int calculateAngle(double h, double m)
    {
        // validate the input
        if (h < 0 || m < 0 ||
            h > 12 || m > 60)
            Console.WriteLine("Wrong input");

        if (h == 12)
            h = 0;

        if (m == 60)
        {
            m = 0;
            h += 1;
            if (h > 12)
            {
                h -= 12;
            }
               
        }

       
        int hour_angle = (int)(0.5 * (h * 60 + m));
        int minute_angle = (int)(6 * m);

        int angle = Math.Abs(hour_angle - minute_angle);

        angle = Math.Min(360 - angle, angle);

        return angle;
    }

    public static void Main()
    {
        Console.WriteLine(calculateAngle(8, 23));
    }
}
