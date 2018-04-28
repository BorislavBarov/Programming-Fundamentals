namespace HornetAssault
{
    using System;
    using System.Linq;

    public class HornetAssault
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

            var index = 0;

            for (int i = 0; i < beehives.Count; i++)
            {
                var powerOfHornets = hornets.Sum();
                var bees = beehives[i];

                if (bees > powerOfHornets)
                {
                    var residue = bees - powerOfHornets;
                    beehives[i] = residue;
                    hornets.RemoveAt(0);

                    if (hornets.Count == 0)
                    {
                        break;
                    }

                    index = i + 1;
                }
                else if (bees == powerOfHornets)
                {
                    hornets.RemoveAt(0);
                    beehives.RemoveAt(i);

                    if (hornets.Count == 0)
                    {
                        break;
                    }

                    if (beehives.Count == 0)
                    {
                        break;
                    }

                    i = index - 1;
                }
                else if (bees < powerOfHornets)
                {
                    beehives.RemoveAt(i);

                    if (beehives.Count == 0)
                    {
                        break;
                    }

                    i = index - 1;
                }
            }

            if (beehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", beehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
