using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] names = new string[7] { "Justin", "Lucas", "Aaliyah", "Jon", "Tarik", "Alex", "Josh", };
            string[] foods = new string[7] { "Baja Blast", "Sushi", "Chicken Wings", "Bacon", "Tacos", "Spaghetti", "Nalesniki" };
            string[] hometowns = new string[7] { "Wyoming", "Louisville, Kentucky", "Manchester", "Toledo, Ohio", "Queens", "Ferndale", "California" };
            bool runProgram = true;

            Console.WriteLine("Welcome to the student database!");
            Console.WriteLine("Which student would you like to learn more about?");


            while (runProgram)
            {
                Console.WriteLine();
                int choice = 0;


                while (true)
                {
                    for(int i = 0; i < names.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {names[i]}");
                    }
                    Console.WriteLine();
                    Console.WriteLine($"Please enter a number 1-{names.Length}: ");
                    string sName = Console.ReadLine();
                    if (names.Contains(sName))
                    {
                        choice = Array.IndexOf(names, sName);
                        break;
                    }
                    choice = int.Parse(sName) - 1;

                    if (choice >= 0 || choice < names.Length)
                    {
                        Console.WriteLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid input");
                    }
                }


                Console.WriteLine($"You have selected {names[choice]} ");

                while (true)
                {
                    Console.WriteLine("Would you like ot learn about the hometown or favorite food?");
                    string category = Console.ReadLine();

                    if ("hometown".Contains(category.ToLower().Trim()))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{names[choice]} is from {hometowns[choice]}");
                        break;
                    }
                    else if ("favorite food".Contains(category.ToLower().Trim()))
                    {
                        Console.WriteLine();
                        Console.WriteLine($"{names[choice]}'s favorite food is {foods[choice]}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid input.");
                    }

                }


                while (true)
                {
                    Console.WriteLine("Would you like to learn about another student? y/n");
                    string loopChoice = Console.ReadLine();

                    if (loopChoice.ToLower().Trim() == "y")
                    {
                        runProgram = true;
                        break;
                    }
                    else if (loopChoice.ToLower().Trim() == "n")
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid input");
                    }
                }

            }

        }
    }
}