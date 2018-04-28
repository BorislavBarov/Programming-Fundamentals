namespace OptimizedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var listOfBankAccounts = new List<BankAccount>();

            while (input != "end")
            {
                var inputParts = input.Split(new[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                var accounts = new BankAccount
                {
                    Name = inputParts[1],
                    Bank = inputParts[0],
                    Balance = decimal.Parse(inputParts[2])
                };

                listOfBankAccounts.Add(accounts);

                input = Console.ReadLine();
            }

            listOfBankAccounts = listOfBankAccounts
                .OrderByDescending(x => x.Balance)
                .ThenBy(x => x.Bank.Length)
                .ToList();

            foreach (var entry in listOfBankAccounts)
            {
                Console.WriteLine($"{entry.Name} -> {entry.Balance} ({entry.Bank})");
            }
        }
    }
}
