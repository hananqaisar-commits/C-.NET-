using System;


namespace _01_Question_Array_Tasks
{
    public class Program
    {
        public static void Main(string[] args)
        {


            MyPractise PrintArray = new MyPractise();

            Console.Write("Enter nth for array lenght: ");
            bool sucess = int.TryParse(Console.ReadLine(), out int n);
            if (!sucess)// If the user input is not a valid integer, print an error message and exit the program
            {
                Console.WriteLine("Invalid input!");
                return;
            }
            int[] array = new int[n];
            for (int i = 0; i < n; i++)// It will loop through the array and ask user to input element for each index.
            {
                Console.WriteLine($"Enter element at index {i}: ");
                array[i] = int.Parse(Console.ReadLine()!);

            }
            Console.WriteLine("=====================================");
            PrintArray.printArray(array);// It will call the printArray method to print the array elements.
            Console.WriteLine("=====================================");
            PrintArray.arrayMax(array);// It will call the arrayMax method to find the maximum element in the array.
            PrintArray.arrayMin(array);// It will call the arrayMin method to find the minimum element in the array.
            PrintArray.array_2ndLargest(array);// It will call the array_2ndLargest
            PrintArray.arraySecondMin(array);// It will call the array_2ndMinimuim
            PrintArray.printArrayAvg(array);// It will call the printArrayAvg method to calculate and print the average of the array elements.
        }
    }
}