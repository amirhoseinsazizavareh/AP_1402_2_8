using System;

namespace امیرحسین_سازی_زواره
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[50];
            Random random = new Random();
            for (int i = 0; i < 50; i++)
            {
                numbers[i] = random.Next(1, 100);
            }
            int largest = int.MinValue;
            int smallest = int.MaxValue;
            foreach (int number in numbers)
            {
                if (number > largest)
                {
                    largest = number;
                }
                if (number < smallest)
                {
                    smallest = number;
                }
            }
            int sum = largest + smallest;
            int subtraction = largest - smallest;
            Console.WriteLine("Generated Numbers:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n\nLargest number: " + largest);
            Console.WriteLine("Smallest number: " + smallest);
            Console.WriteLine("Sum of largest and smallest: " + sum);
            Console.WriteLine("Subtraction of largest and smallest: " + subtraction);
        }
    }
}
