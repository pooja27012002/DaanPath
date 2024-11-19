//1.Question: Write a program that takes a number as input and prints whether the number is even or odd.
using System;
class OddEven {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a Number");
        if (Convert.ToInt32(Console.ReadLine())%2==0)
        {
            Console.WriteLine("Number is Even");
        }
        else
        {
            Console.WriteLine("Number is Odd");
        }
    }
}