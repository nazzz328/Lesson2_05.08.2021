using System;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {

        // Task 1 //
            System.Console.WriteLine("Task 1");
            System.Console.WriteLine(" ");
            int a;
            System.Console.Write("Enter A - ");
            a = int.Parse(Console.ReadLine ());

            int b;
            System.Console.Write("Enter B - ");
            b = int.Parse(Console.ReadLine ());

            int c;

            System.Console.WriteLine(" ");

            if (a > b) 
            {
                b = a;
            }

            else if (a < b)
            {
                a = b;
            }

            else
            {
                a = 0;
                b = 0;
            }
            
            System.Console.WriteLine($"New values are: A =  {a}  B =  {b}");
            System.Console.WriteLine(" ");
            System.Console.WriteLine(" ");

        // Task 2 //

            System.Console.WriteLine("Task 2");
            System.Console.WriteLine(" ");

             double operand1;
            System.Console.Write("Enter first number - ");
            operand1 = double.Parse(Console.ReadLine ());

            double operand2;
            System.Console.Write("Enter second number - ");
            operand2 = double.Parse(Console.ReadLine ());

            string sign;
            System.Console.Write("Enter arithmetic operation sign - ");
            sign = Console.ReadLine ();

            double result;

            switch (sign)
            {
                case "+":
                result = operand1 + operand2;
                System.Console.WriteLine($"Result of operation = {result}");
                break;

                case "-":
                result = operand1 - operand2;
                System.Console.WriteLine($"Result of operation = {result}");
                break;

                case "*":
                result = operand1 * operand2;
                System.Console.WriteLine($"Result of operation = {result}");
                break;

                case "/":
                if (operand2 != 0)
                {
                result = operand1 / operand2;
                System.Console.WriteLine($"Result of operation = {result}");
                }

                else 
                System.Console.WriteLine("Error - second value cannot be 0");
                break;

                default:
                {
                    System.Console.WriteLine("Error - allowed arithmetic signs are: +, -, *, /.");
                }
                break;

                

            }

            // Task 3 //
        
            System.Console.WriteLine("Task 3");
            System.Console.WriteLine(" ");

            int value;
            System.Console.Write ("Enter a value from 0 to 100 - ");
            value = int.Parse (Console.ReadLine ());
            
            if (value >= 0 & value <= 14)
            {
                System.Console.WriteLine("The value is in the range from 0 to 14");
            }

            else if (value >= 15 & value <= 35)
            {
                System.Console.WriteLine("The value is in the range from 15 to 35"); 
            }

            else if (value >= 36 & value <= 50)
            {
                System.Console.WriteLine("The value is in the range from 36 to 50"); 
            }
            else if (value >= 51 & value <= 100)
            {
                System.Console.WriteLine("The value is in the range from 50 to 100");
            }

            else 
            {
                System.Console.WriteLine("Error - the value must be in the aforementioned range");
            }

        }
    }
}
