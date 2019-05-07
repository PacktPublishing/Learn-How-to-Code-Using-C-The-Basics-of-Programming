using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckingAccount myCheckingAccount = new CheckingAccount();
            SavingsAccount mySavingsAccount = new SavingsAccount();

            byte accountSelection;
            byte actionSelection;

            do
            {
                Console.WriteLine("Welcome! Please make a selection");
                Console.WriteLine("1 - Checking Account");
                Console.WriteLine("2 - Savings Account");
                Console.WriteLine("3 - Exit");
                accountSelection = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();

                if (accountSelection != 3)
                {
                    do
                    {
                        Console.WriteLine("1 - Deposit");
                        Console.WriteLine("2 - Withdraw");
                        Console.WriteLine("3 - Check Balance");
                        Console.WriteLine("4 - Exit");
                        actionSelection = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine();

                        if (actionSelection == 1)
                        {
                            Console.Write("Enter the amount to deposit: ");
                            if (accountSelection == 1)
                                myCheckingAccount.Deposit(Convert.ToDouble(Console.ReadLine()));
                            else if (accountSelection == 2)
                                mySavingsAccount.Deposit(Convert.ToDouble(Console.ReadLine()));
                            Console.WriteLine();
                        }
                        else if (actionSelection == 2)
                        {
                            Console.Write("Enter the amount to withdraw: ");
                            if (accountSelection == 1)
                                myCheckingAccount.Withdraw(Convert.ToDouble(Console.ReadLine()));
                            else if (accountSelection == 2)
                                mySavingsAccount.Withdraw(Convert.ToDouble(Console.ReadLine()));
                            Console.WriteLine();
                        }
                        else if (actionSelection == 3)
                        {
                            if (accountSelection == 1)
                                myCheckingAccount.GetBalance();
                            else if (accountSelection == 2)
                                mySavingsAccount.GetBalance();
                            Console.WriteLine();
                        }
                    } while (actionSelection != 4);
                }

            } while (accountSelection != 3);
        }
    }
}
