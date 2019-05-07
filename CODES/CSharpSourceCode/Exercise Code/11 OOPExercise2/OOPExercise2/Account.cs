using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise2
{
    abstract class Account
    {
        private double balance;

        public Account()
        {
            balance = 0.00;
        }

        public virtual void Deposit(double depositAmount)
        {
            balance += depositAmount;
            Console.WriteLine($"A total of ${depositAmount.ToString("F")} has been deposited to your account.");
            GetBalance();
        }

        public void Withdraw(double withdrawalAmount)
        {
            if (balance >= (withdrawalAmount))
            {
                balance -= withdrawalAmount;
                Console.WriteLine($"A total of ${withdrawalAmount.ToString("F")} has been withdrawn from your account.");
            }
            else
            {
                Console.WriteLine("You don't have enough funds to withdraw that amount!");
            }
            GetBalance();
        }

        public void GetBalance()
        {
            Console.WriteLine($"Your current balance is ${balance.ToString("F")}.");
        }
    }
}
