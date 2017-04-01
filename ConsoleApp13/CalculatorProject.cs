using System;

namespace CalculatorConsoleProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            decimal num01;
            decimal num02;
            int calcFunction;
            decimal result;


            Console.Write("Type your first number: ");
            num01 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Type another number: ");
            num02 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What operation do you want to perform? ");
            Console.WriteLine("1 for addition 2 for subtraction 3 for division 4 for multiplication");
            calcFunction = Convert.ToInt32(Console.ReadLine());
            switch (calcFunction)
            {
                case 1:
                    Console.WriteLine("The result is " + (num01 + num02));
                    break;
                case 2:
                    Console.WriteLine("The result is " + (num01 - num02));
                    break;
                case 3:
                    result = (num01 / num02);
                    Console.WriteLine("The result is " + (decimal)result);
                    break;
                case 4:
                    Console.WriteLine("The result is " + (num01 * num02));
                    break;

                default:
                    break;

            } 
            
            Console.ReadKey();

        }
    }
}
