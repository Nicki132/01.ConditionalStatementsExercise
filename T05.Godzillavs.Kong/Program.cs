using System;

namespace T05.Godzillavs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetMovie = double.Parse(Console.ReadLine());
            int numberExtras = int.Parse(Console.ReadLine());
            double priceClothing = double.Parse(Console.ReadLine());

            double amountDecor = budgetMovie * 0.10;
            double amounthClothing = numberExtras * priceClothing;

            if (numberExtras > 150)
            {
               amounthClothing = amounthClothing - amounthClothing * 0.1;
            }
           
            double neededMoney = amounthClothing + amountDecor;
            double difference = budgetMovie - neededMoney;

            if (difference >= 0)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");
            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {difference:F2} leva more.");
            }
        }
    }
}
