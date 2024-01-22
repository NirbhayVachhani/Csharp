//Task 1

/*using System;

namespace NumberDifferenceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the low number: ");
            int lowNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the high number: ");
            int highNumber = int.Parse(Console.ReadLine());

            int difference = highNumber - lowNumber;
            Console.WriteLine($"The difference between {lowNumber} and {highNumber} is: {difference}");

            Console.ReadLine();
        }
    }
}
*/




//Task 2 
/*
using System;

namespace NumberDifferenceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowNumber;

            do
            {
                Console.Write("Enter a positive low number: ");
                lowNumber = int.Parse(Console.ReadLine());

                if (lowNumber <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }

            } while (lowNumber <= 0);

            int highNumber;

            do
            {
                Console.Write("Enter a high number greater than the low number: ");
                highNumber = int.Parse(Console.ReadLine());

                if (highNumber <= lowNumber)
                {
                    Console.WriteLine("Invalid input. Please enter a number greater than the low number.");
                }

            } while (highNumber <= lowNumber);

            int difference = highNumber - lowNumber;
            Console.WriteLine($"The difference between {lowNumber} and {highNumber} is: {difference}");

            Console.ReadLine();
        }
    }
}
*/

//task 3
using System;
using System.IO;

namespace NumberDifferenceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int lowNumber;

            do
            {
                Console.Write("Enter a positive low number: ");
                lowNumber = int.Parse(Console.ReadLine());

                if (lowNumber <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }

            } while (lowNumber <= 0);

            int highNumber;

            do
            {
                Console.Write("Enter a high number greater than the low number: ");
                highNumber = int.Parse(Console.ReadLine());

                if (highNumber <= lowNumber)
                {
                    Console.WriteLine("Invalid input. Please enter a number greater than the low number.");
                }

            } while (highNumber <= lowNumber);


            int[] numbersArray = new int[highNumber - lowNumber + 1];

            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = lowNumber + i;
            }

            string filePath = "E:\\sem2\\c#\\Lab0_Basics_of_C#\\Lab0_Basics_of_C#\\output.txt";

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                for (int i = numbersArray.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine(numbersArray[i]);
                }
            }

            Console.WriteLine($"Numbers have been appended to '{filePath}' in reverse order.");

            Console.ReadLine();
        }
    }
}
