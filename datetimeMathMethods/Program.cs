using System;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(DateTime.Now.DayOfYear);

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        //Datetime 
        Console.WriteLine(DateTime.Now.ToString("dd"));
        Console.WriteLine(DateTime.Now.ToString("ddd"));
        Console.WriteLine(DateTime.Now.ToString("dddd"));

        Console.WriteLine(DateTime.Now.ToString("MM"));
        Console.WriteLine(DateTime.Now.ToString("MMM"));
        Console.WriteLine(DateTime.Now.ToString("MMMM"));

        Console.WriteLine(DateTime.Now.ToString("yy"));
        Console.WriteLine(DateTime.Now.ToString("yyyy"));
        
        //Math 
        Console.WriteLine(Math.Abs(-5));;
        Console.WriteLine(Math.Sin(30));
        Console.WriteLine(Math.Cos(30));
        Console.WriteLine(Math.Tan(30));

        Console.WriteLine(Math.Ceiling(20.3)); 
        Console.WriteLine(Math.Round(24.3));
        Console.WriteLine(Math.Round(27.7));
        Console.WriteLine(Math.Floor(25.7));

        Console.WriteLine(Math.Max(5,6));
        Console.WriteLine(Math.Min(7,6));

        Console.WriteLine(Math.Pow(9,4)); 
        Console.WriteLine(Math.Sqrt(8)); 
        Console.WriteLine(Math.Log(8)); 
        Console.WriteLine(Math.Exp(4)); 
        Console.WriteLine(Math.Log10(1000)); 
        }
    }
}