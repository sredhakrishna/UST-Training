using System;
//dATEtIME

namespace DateTime1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime aDate = DateTime.Now;
            Console.WriteLine(  aDate.DayOfYear);
            Console.WriteLine(aDate.Month);
            Console.WriteLine(aDate.Year);
            Console.WriteLine(aDate.Hour);
            Console.WriteLine(aDate.Minute);
            Console.WriteLine(aDate.Second);
            Console.WriteLine(aDate.Millisecond);
            Console.WriteLine(aDate.ToString("MM/dd/yyyy"));
            Console.WriteLine(aDate.ToString("hh:dd/MM/yyyy:tt"));

            DateTime b = new DateTime(2000, 29, 12);
            var diff = aDate - b;
            Console.WriteLine(diff);
            Console.WriteLine(diff.Days);
            Console.WriteLine(diff.Hours);
            Console.WriteLine(diff.Minutes);
        }
    }
}
