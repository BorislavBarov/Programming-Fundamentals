namespace VariableInHexadecimalFormat
{
    using System;

    public class VariableInHexadecimalFormat
    {
        public static void Main()
        {
            string hexadecimal = Console.ReadLine();

            int decimalFormat = Convert.ToInt32(hexadecimal, 16);

            Console.WriteLine(decimalFormat);
        }
    }
}