namespace GreaterOfTwoValues
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main()
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int":
                    {
                        var intOne = int.Parse(Console.ReadLine());
                        var intTwo = int.Parse(Console.ReadLine());
                        var max = GetMax(intOne, intTwo);
                        Console.WriteLine(max);
                        break;
                    }

                case "char":
                    {
                        var charOne = char.Parse(Console.ReadLine());
                        var charTwo = char.Parse(Console.ReadLine());
                        var max = GetMax(charOne, charTwo);
                        Console.WriteLine(max);
                        break;
                    }

                case "string":
                    {
                        string stringOne = Console.ReadLine();
                        string stringTwo = Console.ReadLine();
                        var max = GetMax(stringOne, stringTwo);
                        Console.WriteLine(max);
                        break;
                    }
            }
        }

        public static int GetMax(int intOne, int intTwo)
        {
            if (intOne >= intTwo)
            {
                return intOne;
            }
            
            return intTwo;
        }

        public static char GetMax(char charOne, char charTwo)
        {
            if (charOne >= charTwo)
            {
                return charOne;
            }

            return charTwo;
        }

        public static string GetMax(string stringOne, string stringTwo)
        {
            if (stringOne.CompareTo(stringTwo) >= 0)
            {
                return stringOne;
            }
            
            return stringTwo;
        }
    }
}