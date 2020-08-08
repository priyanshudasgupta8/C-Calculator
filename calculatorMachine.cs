using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class calculatorMachine
    {

        private double firstNumber;
        private double secondNumber;
        private double result;
        private char operation;

        public calculatorMachine(double first, double second, char op)
        {
            firstNumber     = first;
            secondNumber    = second;
            operation       = op;
            Switching();
        }

        private void Switching()
        {
            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    Console.WriteLine("The sum of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startOver();
                    break;

                case '-':
                    result = firstNumber - secondNumber;
                    Console.WriteLine("The difference of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startOver();
                    break;

                case '*':
                    result = firstNumber * secondNumber;
                    Console.WriteLine("The product of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startOver();
                    break;

                case '/':
                    result = firstNumber / secondNumber;
                    Console.WriteLine("The quotient of {0} and {1} is {2}", firstNumber, secondNumber, result);
                    startOver();
                    break;

                default:
                    Console.WriteLine("Invalid operation. Please enter a valid operation next time");
                    End();

                    break;
            }
        }

        private void startOver()
        {
            Console.WriteLine("You want to do more calculations?\nIf \'yes\' then press and enter (Y). \n" + 
                "Otherwise enter any other key");
            string YesOrNo = Console.ReadLine();
            bool myBool = (YesOrNo == "y" || YesOrNo == "Y");
            if (myBool == true)
            {
                repeat();
            }
            else
            {

            }
        }

        private void repeat()
        {
            firstNumber = result;

            Console.WriteLine("Input Second Number:");
            secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation: (+, -, *, /)");
            operation = char.Parse(Console.ReadLine());
            Switching();
        }

        private void End()
        {
            Console.WriteLine("Final Result is {0}", result);
            Console.WriteLine("Press any key to EXIT the calculator");
            Console.ReadKey();
        }

    }
}


