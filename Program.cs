using System;

namespace FirstWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter number the task`s number:\t\t For exit tap 0");
                int i = int.Parse(Console.ReadLine());
                switch (i)
                {
                    case 0:
                        return;
                    case 1:
                        buzzFizz();
                        break;
                    case 2:
                        countPercent();
                        break;
                    case 3:
                        evenInteger();
                        break;
                    default:
                        Console.WriteLine("This task isn`t complete.");
                        break;
                }
            }
        }
        static void buzzFizz()
        {
            Console.WriteLine("Enter number of 1 to 100:");
            int number;
            do
            {
                number = int.Parse(Console.ReadLine());
            } while (number < 1 || number > 100);
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz and Buzz");
            }
            else if(number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if(number % 5 == 0) 
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }
        static void countPercent()
        {
            Console.WriteLine("Enter two numbers, first - number:");
            double number, percent = 0;
            number = double.Parse(Console.ReadLine());
            Console.WriteLine("Second - percent of first");
            do
            {
                percent = double.Parse(Console.ReadLine());
            } while (percent < 1 || percent > 100);

            double result = (number * percent) / 100;
            Console.WriteLine(percent + " % of " + number + " = " + result);
        }
        static void evenInteger()
        {
            Console.WriteLine("Enter first number:");
            int first, second;
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            second = int.Parse(Console.ReadLine());
            if (first < second)
            {
                second = second + first;
                first = second - first;
                second = second - first;
            }
            for(int i = second; i <= first; ++i)
            {
                if(i % 2 == 0)
                {
                    Console.Write(i + "\t");
                }
            }
            Console.WriteLine();
        }
    }
}
