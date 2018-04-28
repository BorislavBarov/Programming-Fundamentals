namespace UnunionLists
{
    using System;
    using System.Linq;

    public class UnunionLists
    {
        public static void Main()
        {
            var primalList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

                for (int i2 = 0; i2 < list.Count; i2++)
                {
                    if (primalList.Contains(list[i2]))
                    {
                        primalList.RemoveAll(x => x == list[i2]);
                    }
                    else
                    {
                        primalList.Add(list[i2]);
                    }
                }
            }
            
            primalList.Sort();
            Console.WriteLine(string.Join(" ", primalList));
        }
    }
}
