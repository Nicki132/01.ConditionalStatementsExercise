using System;

namespace T04.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            
            int numberPuzzles = int.Parse(Console.ReadLine());
            int numberDolls = int.Parse(Console.ReadLine());
            int numberTeddyBears = int.Parse(Console.ReadLine());
            int numberMinions = int.Parse(Console.ReadLine());
            int numberTrucks = int.Parse(Console.ReadLine());

            int numberOfToys = numberPuzzles + numberDolls + numberTeddyBears + numberMinions + numberTrucks;

            double puzzlesPrice = numberPuzzles * 2.6;
            double dollsPrice = numberDolls * 3.0;
            double teddyBearsPrice = numberTeddyBears * 4.1;
            double minionsPrice = numberMinions * 8.2;
            double trucksPrice = numberTrucks * 2.0;

            double profit = puzzlesPrice + dollsPrice + teddyBearsPrice + minionsPrice + trucksPrice;

            if (numberOfToys >= 50)
            {
                profit = profit - profit * 0.25;
            }
            profit = profit - profit * 0.1;

            double difference = profit - priceTrip;
            if (difference >= 0)
            {
                Console.WriteLine($"Yes! {difference:F2} lv left.");
            }
            
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money! {difference:F2} lv needed.");
            }
        }
    }
}
