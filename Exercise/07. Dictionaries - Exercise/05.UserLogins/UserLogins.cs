namespace UserLogins
{
    using System;
    using System.Collections.Generic;

    public class UserLogins
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var result = new Dictionary<string, string>();
            var count = 0;
            bool inputIsLogin = false;

            while (input != "end")
            {
                var splitInput = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var username = string.Empty;
                var password = string.Empty;
                
                if (input != "login" && inputIsLogin == false)
                {
                    username = splitInput[0];
                    password = splitInput[splitInput.Length - 1];

                    if (!result.ContainsKey(username))
                    {
                        result[username] = string.Empty;
                    }

                    result[username] = password;
                }
                else if (input == "login")
                {
                    inputIsLogin = true;
                }
                else if (inputIsLogin == true)
                {
                    username = splitInput[0];
                    password = splitInput[splitInput.Length - 1];

                    var correctPassword = string.Empty;

                    if (result.ContainsKey(username))
                    {
                        correctPassword = result[username];
                    }

                    if (!result.ContainsKey(username) || correctPassword != password)
                    {
                        Console.WriteLine($"{username}: login failed");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
