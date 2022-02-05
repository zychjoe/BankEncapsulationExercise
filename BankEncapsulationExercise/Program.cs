using System;

namespace BankEncapsulationExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount BA = new BankAccount();

            void UserPrompt()
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("Type \"B\" to check balance");
                Console.WriteLine("Type \"D\" to make a deposit");
                Console.WriteLine("Type \"Q\" to quit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "B":
                        Console.WriteLine("********************************************");
                        Console.WriteLine($"Your current balance is: ${BA.GetBalance()}");
                        Console.WriteLine("********************************************");
                        UserPrompt();
                        return;
                    case "D":
                        Console.WriteLine($"How much?");
                        string amtString = Console.ReadLine();
                        double amt;
                        if(Double.TryParse(amtString, out amt))
                        {
                            BA.Deposit(amt);
                            Console.WriteLine("********************************************");
                            Console.WriteLine($"Your new balance is: ${BA.GetBalance()}");
                            Console.WriteLine("********************************************");
                        }
                        else
                        {
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                            Console.WriteLine("I'm afraid I can't do that, Dave.");
                            Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        }
                        UserPrompt();
                        return;
                    case "Q":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        Console.WriteLine("Please try again...");
                        Console.WriteLine("!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        UserPrompt();
                        return;
                }
            }

            Console.WriteLine("Welcome to the bank!");
            UserPrompt();
        }
    }
}
