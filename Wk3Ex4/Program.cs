using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates the initial balance of 1000.
            double Balance = 1000;

            //Sets the varaible deposit to 0 for future use
            double deposit = 0;

            //Sets withdraw to 0 for future use
            double withdraw = 0;

            //Sets the bool notFinished to true, that way I can keep the program switch case looping until number 4 (quit) is selected
            bool notFinished = true;

            //Creates the atm variable to indicate the value selected for the 1 - 4
            int atm = 0;

            //Creates the while loop using a boolean to continue the program until the quit option is selected.
            while (notFinished)
            {
                //The following lines create the menu gui so the user can understand what they are selecting.
                Console.WriteLine("ATM: Menu: ");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");

                //Prompts user to select one of the options
                Console.WriteLine("Choose an option: ");

                //Converts the user's input to an int and allows it to be used in the switch case
                atm = Convert.ToInt32(Console.ReadLine());

                //sets up the switch case using the condition of atm for its choices.
                switch (atm)
                {
                    //The first case, "Check Balance"
                    case 1:
                        //This lists the current balance
                        Console.WriteLine("Your balance is: " + Balance);

                        //allows the program to continue even after this selection has been made
                        continue;

                    //The second case, "Deposit"
                    case 2:
                        //Prompts user to enter the amount of money deposited
                        Console.WriteLine("Enter Deposit amount: ");

                        //Converts the entered number into an int to be used for calculations
                        deposit = Convert.ToInt32(Console.ReadLine());

                        //Adjusts the current balance to match what was there added to what was entered
                        Balance = Balance + deposit;

                        //Gives the user confirmation the operation was successful
                        Console.WriteLine("Deposit Successful");
                        //continues the program so it can reset and allow the user to choose a different option
                        continue;

                    //Case 3, "Withdrawl." Allows user to remove money from the account.
                    case 3:
                        //Prompts the user to enter the amount they wish to withdrawl.
                        Console.WriteLine("How much would you like to withdraw?");

                        //sets the withdraw as the number added and converts it to an int to be used in operations
                        withdraw = Convert.ToInt32(Console.ReadLine());

                        //subtracts the amount entered from the current balance
                        Balance = Balance - withdraw;

                        //Lets the user know the operation was successful
                        Console.WriteLine("WithDrawl successful.");

                        //Continues program so the user can select another option
                        continue;

                    //Case 4, "Quit." Allows the user to exit the program
                    case 4:
                        //Gives indication the user has exited the program
                        Console.WriteLine("Goodbye!");
                        //Sets the conditional "notFinished" to false so the loop ends
                        notFinished = false;
                        //breaks the code and allows it to exit
                        break;
                    //sets the default in case the user enters anything other than 1-4
                    default:
                        Console.WriteLine("Please enter a valid number between 1-4");
                        continue;
                }
                
            }
        }
    }
}
