using System;
class ClockAngle
{
    static double calculateAngle(int h, int m)
    {
        // validate the input
        if (h < 0 || m < 0 || h > 12 || m > 60)
        {
            Console.WriteLine("Wrong input");
        }
            

        if (h == 12)
        {
            h = 0;
        }
            

        if (m == 60)
        {
            m = 0;

            h += 1;

            if (h > 12)
            {
                h -= 12;
            }
               
        }

       
        double hour_angle = (0.5 * (h * 60 + m));

        double minute_angle = (6 * m);

        double angle = Math.Abs(hour_angle - minute_angle);

        angle = Math.Min(360 - angle, angle);

        return angle;
    }

    public static void Main()
    {
       
        int minute;

        Console.Write("Enter hour: ");
        int hours = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter minutes: ");
        minute = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(calculateAngle(hours, minute));
    }
}
