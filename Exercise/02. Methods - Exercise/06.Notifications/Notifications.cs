namespace Notifications
{
    using System;

    public class Notifications
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine();

                if (result == "success")
                {
                    ShowSuccess();
                }
                else if (result == "error")
                {
                    ShowError();
                }
                else
                {
                    n++;
                }
            }
        }

        public static void ShowSuccess()
        {
            string operation = Console.ReadLine();
            string message = Console.ReadLine();

            Console.WriteLine($"Successfully executed {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Message: {message}.");
        }

        public static void ShowError()
        {
            var reason = string.Empty;

            string operation = Console.ReadLine();
            int code = int.Parse(Console.ReadLine());

            if (code < 0)
            {
                reason = "Internal System Failure";
            }
            else if (code > 0)
            {
                reason = "Invalid Client Data";
            }

            Console.WriteLine($"Error: Failed to execute {operation}.");
            Console.WriteLine("==============================");
            Console.WriteLine($"Error Code: {code}.");
            Console.WriteLine($"Reason: {reason}.");
        }
    }
}