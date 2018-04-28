namespace SweetDessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            var amountOfCash = decimal.Parse(Console.ReadLine());
            var numberOfGuests = int.Parse(Console.ReadLine());
            var priceOfBananas = decimal.Parse(Console.ReadLine());
            var priceOfEggs = decimal.Parse(Console.ReadLine());
            var priceOfBerries = decimal.Parse(Console.ReadLine());

            var neededSets = Math.Ceiling((decimal)numberOfGuests / 6);

            var totalPriceOfBananas = (2 * priceOfBananas) * neededSets;
            var totalPriceOfEggs = (4 * priceOfEggs) * neededSets;
            var totalPriceOfBerries = ((decimal)0.2 * priceOfBerries) * neededSets;

            var totalPrice = totalPriceOfBananas + totalPriceOfEggs + totalPriceOfBerries;

            if (amountOfCash >= totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                var neededMoney = totalPrice - amountOfCash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {neededMoney:f2}lv more.");
            }
        }
    }
}
