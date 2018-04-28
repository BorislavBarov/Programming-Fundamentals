namespace Animals
{
    using System;
    using System.Collections.Generic;

    public class Animals
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var dogs = new List<Dog>();
            var cats = new List<Cat>();
            var snakes = new List<Snake>();
            var sounds = new List<string>();

            while (input != "I'm your Huckleberry")
            {
                var inputParts = input.Split(' ');

                if (inputParts[0] == "talk")
                {
                    var talk = string.Empty;
                    
                    foreach (var item in dogs)
                    {
                        if (inputParts[1] == item.Name)
                        {
                            talk = "I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.";
                            sounds.Add(talk);
                        }
                    }

                    foreach (var item in cats)
                    {
                        if (inputParts[1] == item.Name)
                        {
                            talk = "I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.";
                            sounds.Add(talk);
                        }
                    }

                    foreach (var item in snakes)
                    {
                        if (inputParts[1] == item.Name)
                        {
                            talk = "I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.";
                            sounds.Add(talk);
                        }
                    }

                    input = Console.ReadLine();
                    continue;
                }

                var className = inputParts[0];
                var name = inputParts[1];
                var age = int.Parse(inputParts[2]);
                var parameter = int.Parse(inputParts[3]);

                switch (className)
                {
                    case "Dog":
                        var dog = new Dog
                        {
                            Name = name,
                            Age = age,
                            NumberOfLegs = parameter
                        };
                        dogs.Add(dog);
                        break;

                    case "Cat":
                        var cat = new Cat
                        {
                            Name = name,
                            Age = age,
                            IntelligenceQuotient = parameter
                        };
                        cats.Add(cat);
                        break;

                    case "Snake":
                        var snake = new Snake
                        {
                            Name = name,
                            Age = age,
                            CrueltyCoefficient = parameter
                        };
                        snakes.Add(snake);
                        break;
                }

                input = Console.ReadLine();
            }

            foreach (var item in sounds)
            {
                Console.WriteLine(item);
            }

            foreach (var item in dogs)
            {
                Console.WriteLine($"Dog: {item.Name}, Age: {item.Age}, Number Of Legs: {item.NumberOfLegs}");
            }

            foreach (var item in cats)
            {
                Console.WriteLine($"Cat: {item.Name}, Age: {item.Age}, IQ: {item.IntelligenceQuotient}");
            }

            foreach (var item in snakes)
            {
                Console.WriteLine($"Snake: {item.Name}, Age: {item.Age}, Cruelty: {item.CrueltyCoefficient}");
            }
        }
    }
}
