/*
 * Programmer: James Mandouma
 * Description: C# console app to demonstrate use of methods and arrays.
 * Date: 2/13/2023
 * 
*/

using System;

namespace Deliverable_5
{
    class Program
    {
        static int[] Array_Generator(int array_length)
        {
            Random random1050 = new Random();
            int[] randomArray = new int[array_length];
            for (int i = 0; i < array_length; i++)
            {
                randomArray[i] = random1050.Next(10,50);
            }
            return randomArray;
        }

        static int Summation(int[] array)
        {
            int sum = 0;
            foreach(int item in array)
            {
                sum += item;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter an integer between 5 and 15.");
                int.TryParse(Console.ReadLine(), out int input);
                if (input < 5 || input > 15)
                {
                    Console.WriteLine("Invalid entry");
                    Console.ReadLine(); // Program automatically closes without using this for some reason?
                }
                else
                {
                    int[] userArray = Array_Generator(input);

                    Console.WriteLine("The elements in the random array are: ");
                    foreach (int element in userArray)
                    {
                        Console.WriteLine(element);
                    }

                    Console.WriteLine(" ");
                    Console.WriteLine("The sum is: " + Summation(userArray));
                    Console.ReadLine(); // Program automatically closes without using this for some reason?
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}