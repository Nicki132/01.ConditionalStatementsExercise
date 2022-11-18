using System;

namespace T06.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSeconds = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSeconds = double.Parse(Console.ReadLine());

            double delay = distanceMeters / 15;
            delay = Math.Floor(delay);
            delay = delay * 12.5;

            double recordIvan = distanceMeters + timeSeconds + delay;
            
            if (recordIvan < recordSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {recordIvan:F2} seconds.");
            }
            else 
            {
                Console.WriteLine($"No, he failed! He was {(recordIvan - recordSeconds):F2} seconds slower.");
            }
        }
    }
}
