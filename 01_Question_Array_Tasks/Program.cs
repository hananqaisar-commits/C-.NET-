using System;

namespace _01_Question_Array_Tasks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyPractise practice = new MyPractise();

            Console.Write("Enter number for array length: ");
            bool success = int.TryParse(Console.ReadLine(), out int n);

            if (!success || n <= 0)
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter element at index {i}: ");
                array[i] = int.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("=====================================");

            practice.PrintArray(array);

            Console.WriteLine("=====================================");

            int max = MyPractise.ArrayMax(array);
            int min = MyPractise.ArrayMin(array);
            int secondLargest = MyPractise.ArraySecondLargest(array);
            int secondMinimum = MyPractise.ArraySecondMinimum(array);

            Console.WriteLine($"Max element is: {max}");
            Console.WriteLine($"Min element is: {min}");
            Console.WriteLine($"Second Max element is: {secondLargest}");
            Console.WriteLine($"Second Min element is: {secondMinimum}");



            practice.PrintArrayAverage(array);
            Console.WriteLine($"Ans: {practice.MaxProduct(534)}");



            int[] num = practice.TwoSum(new int[] { 1, 2, 3, 4, 5 }, 6);

            Console.Write($"Target was: 6 and matching index is: {num[0]} and {num[1]}");

        }
    }
}