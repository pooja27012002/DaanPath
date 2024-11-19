using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApplication
{
    internal class main
    {
        static void Main(string[] args) {
            try
            {
                Customer customer = new Customer("Ajeet", 1000);
                customer.DisplayCustomerInfo();
                customer.CustomerAccount.Deposit(200);
                customer.CustomerAccount.Wirthdraw(100);
                customer.CustomerAccount.GetBalance();
                customer.CustomerAccount.Wirthdraw(1500);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}
