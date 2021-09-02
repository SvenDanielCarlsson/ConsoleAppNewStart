using System;

namespace ConsoleAppNewStart
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Clear();
                Console.WriteLine("( - - - M E N U - - - )"
                                    + "\n1. Age Limited Store"
                                    );


                int selection = AskUserForNumber("your selection");
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        AgeLimitStore();
                        break;

                    default:
                        Console.WriteLine("\nIncorrect selection");
                        break;
                }

                Console.WriteLine("Press any key to continue");
                Console.ReadKey(true);
            }
        }


        static void AgeLimitStore()
        {
            Console.WriteLine("~ Age Limited Store ~");

            int userAge = AskUserForNumber("your age");
            Console.WriteLine("\nYou proclaimed " + userAge + " as your age");

            if (userAge >= 18)
            {
                Console.WriteLine("Welcome to the bar, please enjoy\n");
            }
            else
            {
                Console.WriteLine("Sorry, try again when you're welcome by default of age\n");
            }
        }


        static string AskUserFor(string what)
        {
            Console.Write("Please enter " + what + ": ");

            string userInput = Console.ReadLine();

            return userInput;
        }


        static int AskUserForNumber(string what)
        {
            bool wasNotNumber = true;
            int result = 0;
            string testInput;

            do
            {
                testInput = AskUserFor(what);
                wasNotNumber = !int.TryParse(testInput, out result);

                if (wasNotNumber == true)
                {
                    Console.WriteLine("\nType using numbers");
                    Console.WriteLine("'" + testInput + "' is an invalid input\n");
                }

            } while (wasNotNumber);


            return result;

            /*
            string userAgeString = AskUserFor("your age");
            
            while (!int.TryParse(userAgeString, out int result))
            {
                Console.WriteLine("'" + userAgeString + "' is an invalid input");
                userAgeString = AskUserFor("your age");
                Console.Clear();
            }
            */
        }
    }
}
