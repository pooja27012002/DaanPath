using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Class1
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");
            int num1;

            if (int.TryParse(Console.ReadLine(), out num1))
            {
                if (num1 % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

}
