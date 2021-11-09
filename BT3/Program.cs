using System;

namespace BT3
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double x;
            do
            {
                Console.WriteLine("Input Number:");
                x = Convert.ToDouble(Console.ReadLine());
                if (x < 0)
                {
                    break;
                }
                sum += x;
            } while (true);

            Console.WriteLine("Sum of all number is: "+ sum);
        }
    }
}