using System;

namespace ConsoleAppNewStart
{
    class Program
    {
        static void Main(string[] args)
        {

            string userAgeString = AskUserFor("your age");
            Console.Clear();

            while (!int.TryParse(userAgeString, out int result))
            {                
                Console.WriteLine("'"+ userAgeString + "' is an unvalid input");                                
                userAgeString = AskUserFor("your age");
                Console.Clear();
            }


            Console.WriteLine("You typed in '" + userAgeString + "' as your age");
            
            int userAge = Convert.ToInt32(userAgeString);
            if (userAge >= 18)
            {
                Console.WriteLine("Welcome to the bar, please enjoy");
            }
            else
            {
                Console.WriteLine("Sorry, try again when you're welcome by default of age");
            }
        }

        static string AskUserFor(string what)
        {
            Console.Write("Please enter " + what + ": ");

            string userInput = Console.ReadLine();

            return userInput;
        }
    }
}
