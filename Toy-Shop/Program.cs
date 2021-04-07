using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            int numPuzzles = int.Parse(Console.ReadLine());
            int numDolls = int.Parse(Console.ReadLine());
            int numBears = int.Parse(Console.ReadLine());
            int numMinions = int.Parse(Console.ReadLine());
            int numTrucks = int.Parse(Console.ReadLine());

            double totalProfit = numPuzzles * 2.60 + numDolls * 3 + numBears * 4.10 + numMinions * 8.20 + numTrucks * 2;
            int totalNumSold = numPuzzles + numDolls + numBears + numMinions + numTrucks;

            double totalAfterDiscount = 0;

            if(totalNumSold >= 50)
            {
                totalAfterDiscount = totalProfit * 0.75; 
            }
            else
            {
                totalAfterDiscount = totalProfit;
            }

            double totalAfterRent = totalAfterDiscount * 0.90;
            double diff = Math.Abs(totalAfterRent - priceTrip);

            if(totalAfterRent>=priceTrip)
            {
                Console.WriteLine($"Yes! {diff:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {diff:f2} lv needed.");
            }
        }
    }
}
