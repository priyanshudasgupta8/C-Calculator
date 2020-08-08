using System;
using Calculator;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------\n" + 
                "--------Welcome To My Calculator--------\n" +
                "----------------------------------------");

            Console.WriteLine("Input first number:");
            double fnum = double.Parse(Console.ReadLine());

            Console.WriteLine("Input second number:");
            double snum = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation: (+, -, *, /)");
            char myop = char.Parse(Console.ReadLine());
            
            calculatorMachine User = new calculatorMachine(fnum, snum, myop);
        }
    }
}


