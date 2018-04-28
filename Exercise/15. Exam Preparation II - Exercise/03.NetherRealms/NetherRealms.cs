namespace NetherRealms
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main()
        {
            var demons = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(x => x).ToArray();

            foreach (var demon in demons)
            {
                var health = 0;
                var healthRegex = new Regex(@"[^-+*\/.0-9]");

                var matchesHealthSymbols = healthRegex.Matches(demon);

                foreach (Match symbol in matchesHealthSymbols)
                {
                    health += char.Parse(symbol.Value);
                }

                var damage = 0d;
                var damageRegex = new Regex(@"-?\d+\.?\d*");

                var matchesDamageSymbols = damageRegex.Matches(demon);

                foreach (Match symbol in matchesDamageSymbols)
                {
                    damage += double.Parse(symbol.Value);
                }
                
                foreach (var symbol in demon)
                {
                    if (symbol == '/')
                    {
                        damage /= 2;
                    }
                    else if (symbol == '*')
                    {
                        damage *= 2;
                    }
                }

                Console.WriteLine($"{demon} - {health} health, {damage:f2} damage");
            }
        }
    }
}
