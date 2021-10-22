using System;
using System.Collections;
using System.Collections.Generic;

namespace PasswordGenerator
{

    class Program
    {
            static void Main(string[] args)
        {
            PasswordGenerator p = new PasswordGenerator();
            Console.WriteLine("Welcome to  Damians 12Char Password Generator!");

            int num;
            string userChoice;

            do
            {
               
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Select the number of your choice: ");
                Console.WriteLine("1: Generate Password");
                Console.WriteLine("2: Quit");
                Console.WriteLine("----------------------------------");

                userChoice = Console.ReadLine();

                if (!Int32.TryParse(userChoice, out num)) continue;

                if (userChoice == "2")
                {
                    Environment.Exit(0);
                }

                if (userChoice == "1")
                {
                    Console.WriteLine("----------------------------------");
                    p.genPass();
                }
                else
                {
                    Console.WriteLine("Well done you found the Easter Egg!");
                    Environment.Exit(0);
                }

            } while (true);
        }
    }
}


