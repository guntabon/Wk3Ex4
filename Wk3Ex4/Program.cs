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
            double Balance = 1000;

            double deposit = 0;

            double withdraw = 0;

            bool notFinished = true;

            int atm = 0;

            while (notFinished)
            {
                Console.WriteLine("ATM: Menu: ");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Choose an option: ");

                atm = Convert.ToInt32(Console.ReadLine());

                switch (atm)
                {
                    case 1:
                        Console.WriteLine("Your balance is: " + Balance);
                        continue;
                    case 2:
                        Console.WriteLine("Enter Deposit amount: ");
                        deposit = Convert.ToInt32(Console.ReadLine());
                        Balance = Balance + deposit;
                        Console.WriteLine("Deposit Successful");
                        continue;
                    case 3:
                        Console.WriteLine("How much would you like to withdraw?");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        Balance = Balance - withdraw;
                        Console.WriteLine("WithDrawl successful.");
                        continue;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        notFinished = false;
                        break;
                }
                
                Console.ReadLine();
            }
        }
    }
}
