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

            {
                Console.WriteLine("Howdy Y'all!!");
                Console.WriteLine("Good Morning");
                Console.WriteLine("Good Morning Don't ya know");
            }

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                if ( animal ==  "Triceratops" || animal == "Gorilla")
                {
                Console.WriteLine(animal);
                }
            }


            
                Console.ReadKey(); // What happens if you run the app without this line? // this makes you enter a key
        }
    }
}