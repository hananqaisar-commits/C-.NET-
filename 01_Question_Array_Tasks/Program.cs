using System;
using System.ComponentModel.DataAnnotations;

namespace _01_Question_Array_Tasks
{
    public class Program
    {
        public static void Main(string[] args)
        {


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

            print_array(array);
            array_max(array);
            array_2ndLargest(array);
            array_min(array);
            array_2ndMinimuim(array);
            print_arrayAverage(array);
        }
        static void print_array(int[] array)
        {
            int count = 0;
            foreach (int n in array)
            {
                Console.WriteLine($"Index {count} ===> {n}");
                ++count;
            }
        }
        static void print_arrayAverage(int[] array)
        {

            float average = 0;
            int count = 0;
            foreach (int n in array)
            {
                average += n;
                count++;
            }
            Console.WriteLine($"Average is: {(float)average / count}");
        }
        static void array_max(int[] array)
        {
            int max = int.MinValue;
            foreach (int n in array)
            {
                if (n > max)
                {
                    max = n;
                }

            }
            Console.WriteLine($"Max element is: {max}");
        }
        static void array_min(int[] array)
        {
            int min = int.MaxValue;
            foreach (int n in array)
            {
                if (n < min)
                {
                    min = n;
                }

            }
            Console.WriteLine($"Min element is: {min}");
        }

        static void array_2ndLargest(int[] array)
        {
            int max = int.MinValue;
            int second_max = int.MinValue;
            foreach (int n in array)
            {
                if (n > max)
                {
                    second_max = max;
                    max = n;
                }
                else if (n > second_max && n != max)
                {
                    second_max = n;
                }

            }
            Console.WriteLine($"Second Max element is: {second_max}");
        }
        static void array_2ndMinimuim(int[] array)
        {
            int min = int.MaxValue;
            int second_min = int.MaxValue;
            foreach (int n in array)
            {
                if (n < min)
                {
                    second_min = min;
                    min = n;
                }
                else if (n < second_min && n != min)
                {
                    second_min = n;
                }

            }
            Console.WriteLine($"Second Min element is: {second_min}");
        }
    }


}