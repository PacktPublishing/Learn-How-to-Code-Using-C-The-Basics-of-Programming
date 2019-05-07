using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExercise2
{
    class SavingsAccount : Account
    {
        public override void Deposit(double depositAmount)
        {
            double depositBonus = Math.Floor(depositAmount / 100);
            if (depositBonus > 0)
                Console.WriteLine($"You have earned ${depositBonus} of bonus bucks!");
            base.Deposit(depositAmount + depositBonus);
        }
    }
}
