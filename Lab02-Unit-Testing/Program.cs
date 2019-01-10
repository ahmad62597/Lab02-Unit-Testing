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
            AnalyzeOptions(userInput);

        }

        static void AnalyzeOptions(string userInput)
        {   //different user options and calling the appropriate function for the option selected
            if (userInput == "1")
            {
                ViewBalance();
            }

            if (userInput =="2")
            {
                WithdrawMoney();
            }
        }

        static void ViewBalance()
        {   //Method for showing amount of money in account
            Console.WriteLine("Your Balance is " + UserBalance);
            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadKey();
            MainMenu();

        }

        static int WithdrawMoney()
        {   //Method for withdrawing money and decreasing userBalance
            Console.WriteLine("Enter amount of money you wish to withdraw");
            //Use try and catch here


            string userInput = Console.ReadLine();
            int amount = Convert.ToInt32(userInput);
            UserBalance = UserBalance - amount;

            Console.WriteLine("Press any key to go back to main menu");
            Console.ReadKey();
            MainMenu();
            return UserBalance;
        }
       
    }
}
