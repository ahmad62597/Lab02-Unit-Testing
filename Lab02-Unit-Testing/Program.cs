using System;

namespace Lab02_Unit_Testing
{
    class Program
    {
        public static int UserBalance = 1000;


        static void Main(string[] args)
        {   //Welcome menu
            Console.WriteLine("Hello. Welcome to your bank account. ");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            MainMenu();
            Console.ReadKey();


        }

        static void MainMenu()
        {   //Creating menu for user 
            Console.WriteLine("Select an option: 1, 2 or 3.");
            Console.WriteLine("1.View Balance");
            Console.WriteLine("2.Withdraw Money");
            Console.WriteLine("3.Add Money");

            //Test userinput via string
            string userInput = Console.ReadLine();
            Console.WriteLine("Your input was recieved." + userInput);

        }

        static void AnalyzeOptions(string userInput)
        {
            if (userInput == "1")
            {
                ViewBalance();
            }
        }


       
    }
}
