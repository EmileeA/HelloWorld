using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var greetingType = args[0]; 

             //if (greetingType == "Southern" || greetingType == "Northern" || greetingType == "Mid-West")

                switch (greetingType)
                {
                    case "Southern":
                        Console.WriteLine("Howdy Y'all!!");
                        break;
                    case "Northern":
                        Console.WriteLine("Good Morning");
                        break;
                    case "Mid-West":
                        Console.WriteLine("Good Morning Don't ya know");
                        break;
                    default:
                        Console.WriteLine("Not from here");
                        break;
                }

            // What is your name
                Console.ReadLine();
                Console.WriteLine("What is your name?");
                var name = Console.ReadLine();
                Console.WriteLine($"Welcome to the animal section, {name}. What's your favorite color?");
                string colorChoice = Console.ReadLine();

                Random rnd = new Random();
                int randomNumber = rnd.Next(0, 5);

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };
            var randomAnimal = animals[randomNumber];
            Console.WriteLine($"{colorChoice} is an excellent choice. Would you like to have a {colorChoice} {randomAnimal}?");
            Console.ReadLine();

            foreach (var animal in animals)
            {
                var counter = 0;
                foreach (var currentCharacter in animal)
                {
                    if (currentCharacter == 'a' || currentCharacter == 'e' || currentCharacter == 'i' || currentCharacter == 'o' || currentCharacter == 'u' || currentCharacter == 'y')
                    {
                        counter++;
                    }
                }
                if (counter >= 2)
                {
                    Console.WriteLine(animal);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("too few syllables");
                    Console.ReadLine();
                }
            }

        }
    }
}



