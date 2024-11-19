using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    public class Account
    {
        public double Balance {  get; set; }
        Account() { }
        public Account(double balance=0) {
            Balance = balance; 
        }

        public void Deposit(double amount)
        {
            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Amount must be Positive");
                }
                Balance = +amount;
                Console.WriteLine($"Deposited: {amount}. Current balance: {Balance}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error : {e.Message}");
            }
            catch (Exception e) {
                Console.WriteLine($"Error : {e.Message}");
            }
        }
        public void Wirthdraw(double amount)
        {
            try
            {

                if (amount <= 0)
                {
                    throw new ArgumentException("Amount must be Positive");
                }
                if (amount > Balance)
                {
                    throw new InvalidOperationException("Insufficient funds.");
                }
                Balance -= amount;
                Console.WriteLine($"Deposited: {amount}. Current balance: {Balance}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Error : {e.Message}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Error : {e.Message}");
            }
            catch (Exception e) { 
                Console.WriteLine($"Error : {e.Message}");
            }
        }
        public double GetBalance()
        {
            return Balance;
        }
    }
}
