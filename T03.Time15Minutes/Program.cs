using System;

namespace T03.Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
           
            int timeInMin = m + h * 60;
            int timeAfter15Min = timeInMin + 15; ;

            int hAfter = timeAfter15Min / 60;
            int mAfter = timeAfter15Min % 60;

            if (hAfter >= 24)
            {
                hAfter = hAfter - 24;
            }
            if (mAfter < 10)
            {
                Console.WriteLine($"{hAfter}:0{mAfter}");
            }
            else
            {
                Console.WriteLine($"{hAfter}:{mAfter}");
            }
        }
    }
}
