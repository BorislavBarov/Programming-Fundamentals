namespace LineNumbers
{
    using System;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            var input = File.ReadAllLines("Input.txt");

            for (int i = 0; i < input.Length; i++)
            {
                File.AppendAllText("Output.txt", (i + 1) + ". " + input[i] + Environment.NewLine);
            }
        }
    }
}