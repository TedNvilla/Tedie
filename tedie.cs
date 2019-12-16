using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            double result = double.NaN; 
           
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                
                default:
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
 
            Console.WriteLine("Hi there,I am your friendly basic calculator\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Sorry, this is not valid number. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }




               Console.WriteLine("Choose an operator from the following:");
                Console.WriteLine("\t+ - Addition");
                Console.WriteLine("\t- - Subtraction");
                Console.WriteLine("\t* - Multiplication");
                Console.WriteLine("\t/ - Division");
                Console.Write("Your option? ");

                string op = Console.ReadLine();



                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Sorry,this is not valid number.Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                
                

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Sorry,this is undefined.\n");
                    }
                    else Console.WriteLine("Answer: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to compute this.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------------------------------------------------------------------\n");

                
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); 
            }
            return;
        }
    }
}