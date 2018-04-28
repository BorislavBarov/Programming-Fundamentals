namespace SoftuniCoffeeOrders
{
    using System;
    using System.Globalization;

    public class SoftuniCoffeeOrders
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var totalPrice = 0m;

            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var capsulesCount = int.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                var price = (daysInMonth * (long)capsulesCount) * pricePerCapsule;
                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}