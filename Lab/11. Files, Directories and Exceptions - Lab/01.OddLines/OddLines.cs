namespace OddLines
{
    using System;
    using System.IO;

    public class OddLines
    {
        public static void Main()
        {
            var input = File.ReadAllLines("Input.txt");
            
            for (int i = 1; i < input.Length; i+= 2)
            {
                File.AppendAllText("Output.txt", input[i] + Environment.NewLine);
            }
        }
    }
}