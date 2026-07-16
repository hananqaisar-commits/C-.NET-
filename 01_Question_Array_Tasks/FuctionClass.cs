
public class MyPractise
{
    public void printArray(int[] array)// It will loop through the array and print each element along with its index.
    {
        int count = 0;
        foreach (int n in array)
        {
            Console.WriteLine($"Index {count} ===> {n}");
            ++count;
        }
    }
    public void printArrayAvg(int[] array)
    {

        float average = 0;
        int count = 0;
        foreach (int n in array)// It will loop through the array and calculate the sum of all elements and count the number of elements in the array.
        {
            average += n;
            count++;
        }
        Console.WriteLine($"Average is: {(float)average / count}");
    }
    public void arrayMax(int[] array)
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
    public void arrayMin(int[] array)// It will loop through the array and find the minimum element in the array.
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

    public void array_2ndLargest(int[] array)// It will loop through the array and find the second largest element in the array.
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
        Console.WriteLine($"Second Max element is: {secondMax}");
    }
    public void arraySecondMin(int[] array)// It will loop through the array and find the second minimum element in the array.
    {
        int min = int.MaxValue;
        int secondMinimuim = int.MaxValue;
        foreach (int n in array)
        {
            if (n < min)
            {
                secondMinimuim = min;
                min = n;
            }
            else if (n < secondMinimuim && n != min)
            {
                secondMinimuim = n;
            }

        }
        Console.WriteLine($"Second Min element is: {secondMinimuim}");
    }
}

