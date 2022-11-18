using System;

namespace T01.SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdtime = int.Parse(Console.ReadLine());
           
            int totaltime = firstTime + secondTime + thirdtime;
            
            int minutes = totaltime / 60;
            int seconds = totaltime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
           
        }
    }
}
