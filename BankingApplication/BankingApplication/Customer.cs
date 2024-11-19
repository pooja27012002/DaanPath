  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class Customer
    {
        public string Name { get; set; }
        public Account CustomerAccount { get; set; }

        public Customer(string name, double initialBalance = 0) { 
            Name = name;
            CustomerAccount = new Account(initialBalance); 
        }
        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"Customer: {Name}, Balance: {CustomerAccount.GetBalance()}");
        }
    }
}
