using System;
using System.Transactions;

namespace VirtualPet
{
    public class Program
    {
        static void Main(string[] args)
        {

            Pet Pet = new Pet();

            Console.WriteLine("Hello! Welcome to Virtual Pets.\n");

            Console.WriteLine("What's the name of your new pet?");
            Pet.SetName(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("What's the species of your new pet?");
            Pet.SetSpecies(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine($"\n{Pet.GetName()} the {Pet.GetSpecies()} is here!");

            bool gamePlay = true;
            do
            {
                ;
                Console.WriteLine($"Hunger is {Pet.GetHunger()}.");
                Console.WriteLine($"Boredom is {Pet.GetBoredom()}.");
                Console.WriteLine($"Health is {Pet.GetHealth()}."); 
                Pet.Tick();
                Console.WriteLine("\nWhat would you like to do with your pet?\n");

                Console.WriteLine("Play with my pet - press 1");
                Console.WriteLine("\nFeed my pet - press 2");
                Console.WriteLine("\nTake my pet to the doctor - press 3");
                Console.WriteLine("\nQuit - press 4");

                string inPlay = Console.ReadLine();
                Console.Clear();

                switch (inPlay)

                {
                    case "1":
                        Pet.Play();
                        break;

                    case "2":
                        Pet.Feed();
                        break;

                    case "3":
                        Pet.SeeDoctor();
                        break;

                    case "4":
                        Console.WriteLine("Thanks for playing!");
                            break;

                    default:
                        Console.WriteLine("Enter a number.");
                        break;

                }


            } while (gamePlay);

        }
    }
}
