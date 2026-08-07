using System;
using System.Collections.Generic;

class Program
{

    static List<int> RemoveDuplicates(List<int> list)
    {
        List<int> result = new List<int>();
        foreach (int n in list)
        {
            if (!result.Contains(n))
                result.Add(n);
        }
        return result;
    }

    static List<int> Merge(List<int> list1, List<int> list2)
    {
        List<int> merged = new List<int>();
        int i = 0, j = 0;

        while (i < list1.Count) merged.Add(list1[i++]);
        while (j < list2.Count) merged.Add(list2[j++]);

        return merged;
    }
    static int SecondLargest(List<int> list)
    {
        int max = int.MinValue, secondMax = int.MinValue;
        foreach (int n in list)
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

    static int CountOccurrences(List<int> list, int target)
    {
        int count = 0;
        foreach (int n in list)
        {
            if (n == target)
                count++;
        }
        return count;
    }

    static void Main()
    {
        List<int> nums = new List<int> { 5, 2, 8, 2, 5, 9, 1, 8 };

        Console.WriteLine("Original List: " + string.Join(", ", nums));

        List<int> unique = RemoveDuplicates(nums);
        Console.WriteLine("Without Duplicates: " + string.Join(", ", unique));

        List<int> sortedA = new List<int> { 1, 3, 5, 7 };
        List<int> sortedB = new List<int> { 2, 4, 6, 8 };
        List<int> merged = Merge(sortedA, sortedB);
        Console.WriteLine("Merged Sorted Lists: " + string.Join(", ", merged));

        Console.WriteLine("Second Largest in original list: " + SecondLargest(nums));

        Console.WriteLine("Occurrences of 8: " + CountOccurrences(nums, 8));//count occurance of target in list
    }
}