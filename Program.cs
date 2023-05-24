using System;
using System.ComponentModel.Design;

namespace Basic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("The sum of {0} and {1} is: {2}", num1, num2, sum);

            Console.WriteLine("Enter the first number");
            int no1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int no2 = Convert.ToInt32(Console.ReadLine());

            int difference = no1 - no2;
            Console.WriteLine("The difference of {0} and {1} is: {2}", no1, no2, difference);

            Console.WriteLine("Enter the dividend:");
            double dividend = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the divisor:");
            double divisor = Convert.ToDouble(Console.ReadLine());

            if (divisor != 0)
            {
                double result = dividend / divisor;
                Console.WriteLine("The result of division is: " + result);
            }
            else
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }

            Console.WriteLine("Enter the number multiplied:");
            double multiplied = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the multiple:");
            double multiple = Convert.ToDouble(Console.ReadLine());

            if (multiple != 0)
            {
                double result = multiplied * multiple;
                Console.WriteLine("The result of multiple is: " + result);
            }
            else
            {
                Console.WriteLine("Error: Multiply by zero is not allowed.");
            }
        }
    }
}
