namespace CamelsBack
{
    using System;
    using System.Linq;

    public class CamelsBack
    {
        public static void Main()
        {
            var N = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var M = int.Parse(Console.ReadLine());

            var breakBool = false;

            if (M == N.Count)
            {
                Console.WriteLine("already stable: " + string.Join(" ", N));
                breakBool = true;
            }

            var rounds = 0;

            while (M != N.Count)
            {
                N.RemoveAt(0);
                N.RemoveAt(N.Count - 1);
                rounds++;
            }

            if (M == N.Count && breakBool == false)
            {
                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine("remaining: " + string.Join(" ", N));
            }
        }
    }
}
