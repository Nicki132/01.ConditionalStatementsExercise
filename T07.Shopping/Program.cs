using System;

namespace T07.Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double peterBudget = double.Parse(Console.ReadLine());
            int numVideoCards = int.Parse(Console.ReadLine());
            int numberProcessors = int.Parse(Console.ReadLine());
            int numRamMemory = int.Parse(Console.ReadLine());

            double amountVideoCards = numVideoCards * 2;
            double processorsPrice = amountVideoCards / 0.035;
            double amountProcessors = numberProcessors * processorsPrice;
            double priceRamMemory = amountVideoCards / 0.01;
            double amountRamMemory = numRamMemory * priceRamMemory;
            double total = amountVideoCards + processorsPrice + amountRamMemory;
            double finalPrice = total / 0.015;
            if (finalPrice <= peterBudget)
            {
                Console.WriteLine(finalPrice);
            }
            else if (finalPrice > peterBudget)
            {
                Console.WriteLine(finalPrice);
            }
            Console.WriteLine($"You have {finalPrice} leva left!");
            Console.WriteLine($"Not enough money! You need {finalPrice} leva more!"
);
        }
    }
}
