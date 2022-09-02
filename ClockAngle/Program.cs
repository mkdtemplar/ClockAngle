using System.ComponentModel;

namespace ClockAngle;
using static Console;

internal static class Program
{
    static double CalculateAngle(int h, int m)
    {
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

       
        double hourAngle = (0.5 * (h * 60 + m));

        double minuteAngle = 6 * m;

        double angle = Math.Abs(hourAngle - minuteAngle);

        angle = Math.Min(360 - angle, angle);

        return angle;
    }

    public static void Main()
    {
        int hours;
        int minute;

        Write("Enter hour: ");
        string input = Console.ReadLine() ?? throw new InvalidOperationException();
        
        bool intResultHour = int.TryParse(input, out hours);


        while (intResultHour == false)
        {
            WriteLine("Input for hours is not in integer format!");
            Write("Enter hour: ");
            input = ReadLine() ?? throw new InvalidOperationException();
            intResultHour = int.TryParse(input, out hours);
        }

        while ((hours is < 0 or > 12) || intResultHour == false)
        {
            if (hours is < 0 or > 12)
            {
                WriteLine("Hours must be greater than 0 and less or equal than 12!");
            }

            if (intResultHour == false)
            {
                WriteLine("Input for hours is not in integer format!");
            }

            Write("Enter hour: ");
            input = ReadLine() ?? throw new InvalidOperationException();
            intResultHour = int.TryParse(input, out hours);
        }

        Write("Enter minutes: ");
        input = ReadLine() ?? throw new InvalidOperationException();

        bool intResultMinute = int.TryParse(input, out minute);

        while (intResultMinute == false)
        {
            WriteLine("Input for minutes is not in integer format");
            Write("Enter minutes: ");
            input = ReadLine() ?? throw new InvalidOperationException();
            intResultMinute = int.TryParse(input, out minute);
        }

        while ((minute is < 0 or > 60) || intResultMinute == false)
        {
            if (minute is < 0 or > 60)
            {
                WriteLine("Minutes must be greater than 0 and less or equal to 60!");
            }

            if (intResultMinute == false)
            {
                WriteLine("Input for minutes is not in integer format");
            }

            Write("Enter minutes: ");
            input = ReadLine() ?? throw new InvalidOperationException();
            intResultMinute = int.TryParse(input, out minute);
        }

        WriteLine(CalculateAngle(hours, minute));
    }
}