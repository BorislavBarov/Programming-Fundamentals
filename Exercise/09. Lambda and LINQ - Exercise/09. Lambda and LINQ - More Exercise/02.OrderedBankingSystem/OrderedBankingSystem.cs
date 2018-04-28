namespace OrderedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderedBankingSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dictionary = new Dictionary<string, Dictionary<string, decimal>>();

            while (input != "end")
            {
                var tokens = input.Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var bank = tokens[0];
                var account = tokens[1];
                var balance = decimal.Parse(tokens[2]);

                if (!dictionary.ContainsKey(bank))
                {
                    dictionary[bank] = new Dictionary<string, decimal>();
                }

                if (!dictionary[bank].ContainsKey(account))
                {
                    dictionary[bank][account] = 0;
                }

                dictionary[bank][account] += balance;

                input = Console.ReadLine();
            }

            dictionary = dictionary
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var entry in dictionary)
            {
                var bankName = entry.Key;
                var accountInfo = entry.Value
                    .OrderByDescending(x => x.Value);

                foreach (var name in accountInfo)
                {
                    Console.WriteLine($"{name.Key} -> {name.Value} ({bankName})");
                }
            }
        }
    }
}
