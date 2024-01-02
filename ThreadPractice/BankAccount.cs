using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadPractice
{
    class BankAccount
    {
        private Object acctLock = new Object();
        double Balance { get; set; }
        string Name { get; set; }

        public BankAccount(double balance=0, string name= "No Name")
        {           
            Balance = balance;
            Name = name;
        }

        public double Withdraw(double amount)
        {
            if (Balance < amount)
            {
                Console.WriteLine($"Sorry, ${Balance} in account");
                return Balance;
            }
            else
            {
                lock (acctLock)
                {
                    Balance -= amount;
                    Console.WriteLine($"Removed ${amount}, new balance is ${Balance}");
                    return Balance;
                }
            }
        }
    }
}
