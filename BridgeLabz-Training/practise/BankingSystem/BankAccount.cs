using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Training.practise.BankingSystem
{
    internal class BankAccount
    {

        float balance = 0;

        public BankAccount(float initialAmount)
        {
            if (initialAmount < 0)
            {
                try
                {
                    throw new ArgumentNullException("Negative values not allowed");
                }catch(ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                balance += initialAmount;
            }
        }

        public void Deposit(float amount)
        {
            if (amount < 0)
            {
                throw new ArgumentNullException("Negative values not allowed");
            }
            else
            {
                balance += amount;
                Console.WriteLine("Amount deposit new balance is " + balance);
            }
        }

        public void Withdraw(float amount)
        {
            try
            {
                if (amount < 0)
                {
                    throw new ArgumentNullException("Negative values not allowed");
                }
                else if (amount > balance)
                {
                    throw new ArgumentOutOfRangeException("Low balance");
                }
                else
                {
                    balance -= amount;
                    Console.WriteLine("Amount withdrawn new balance is " + balance);
                }
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Low balance", e.Message);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount(2000);
            account1.Deposit(20);
            account1.Withdraw(-10);
        }

    }

    
}
