using System;
// using System.ComponentModel.DataAnnotations;

namespace _01_Question_Array_Tasks
{
    public class Program
    {
        public static void Main(string[] args)
        {


            MyPractise PrintArray = new MyPractise();

            Console.Write("Enter nth for array lenght: ");
            bool sucess = int.TryParse(Console.ReadLine(), out int n);
            if (!sucess)
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter element at index {i}: ");
                array[i] = int.Parse(Console.ReadLine()!);

            }
            PrintArray.print_array(array);

        }
    }
}