using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _01_Question_Array_Tasks
{
    public class MyPractise
    {
        public void PrintArray(int[] array)
        {
            int count = 0;

            foreach (int n in array)
            {
                Console.WriteLine($"Index {count} ===> {n}");
                count++;
            }
        }

        public void PrintArrayAverage(int[] array)
        {
            int sum = 0;
            int count = 0;

            foreach (int n in array)
            {
                sum += n;
                count++;
            }

            Console.WriteLine($"Average is: {(float)sum / count}");
        }

        public static int ArrayMax(int[] array)
        {
            int max = int.MinValue;

            foreach (int n in array)
            {
                if (n > max)
                {
                    max = n;
                }
            }

            return max;
        }

        public static int ArrayMin(int[] array)
        {
            int min = int.MaxValue;

            foreach (int n in array)
            {
                if (n < min)
                {
                    min = n;
                }
            }

            return min;
        }

        public static int ArraySecondLargest(int[] array)
        {
            int max = int.MinValue;
            int secondMax = int.MinValue;

            foreach (int n in array)
            {
                if (n > max)
                {
                    secondMax = max;
                    max = n;
                }
                else if (n > secondMax && n != max)
                {
                    secondMax = n;
                }
            }

            return secondMax;
        }

        public static int ArraySecondMinimum(int[] array)
        {
            int min = int.MaxValue;
            int secondMin = int.MaxValue;

            foreach (int n in array)
            {
                if (n < min)
                {
                    secondMin = min;
                    min = n;
                }
                else if (n < secondMin && n != min)
                {
                    secondMin = n;
                }
            }

            return secondMin;
        }

        public int MaxProduct(int n)
        {
            int[] separatedDigits = n.ToString().Select(s => s - '0').ToArray();//convert digit to array
            int max = ArrayMax(separatedDigits);
            int secondMax = ArraySecondLargest(separatedDigits);
            return max * secondMax;
        }
        public int[] TwoSum(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return new int[] { };

        }

    }
}
