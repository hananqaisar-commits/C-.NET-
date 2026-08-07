
using System.Globalization;

PrintArray(new int[] { 12, 22, 19, 15, 13, 7 });
Console.WriteLine(FindSecondMax(new int[] { 10, 1, 11, 15, 13, 17 }));
Console.WriteLine(FindMax(new int[] { 12, 22, 19, 15, 13, 7 }));
PrintArrayAverage(new int[] { 12, 22, 19, 15, 13, 7 });


// reversing array

Console.WriteLine("Enter array lenght to reverse:");
int i = int.Parse(Console.ReadLine());
int[] array = new int[i];
Console.WriteLine("Enter numbers:");
int k = 0;
while (k < i)
{
    if (int.TryParse(Console.ReadLine(), out int num))
        array[k] = num;
    k++;
}


int[] reversed = ReverseArray((int[])array.Clone());//reverse array

Console.WriteLine("Array entered:");
foreach (int n in array)
    Console.Write(n + " ");
Console.WriteLine();

Console.WriteLine("Before reversing     |   After Reversing:");
for (int j = 0; j < array.Length; j++)
{
    Console.WriteLine($"Index {j,-3} ===> {array[j],-4}  |   Index {j,-3} ===> {reversed[j],-4}");
}

static int FindMax(int[] arr)
{
    int? max = int.MinValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max.Value;
}
static int FindSecondMax(int[] arr)
{
    int? max = int.MinValue;
    int? secondMax = max;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            secondMax = max;
            max = arr[i];
        }
        else if (arr[i] > secondMax)
        {
            secondMax = arr[i];
        }
    }
    return secondMax.Value;
}

static void PrintArray(int[] array)
{
    int count = 0;

    foreach (int n in array)
    {
        Console.WriteLine($"Index {count} ===> {n}");
        count++;
    }
}

static void PrintArrayAverage(int[] array)
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

static int[] ReverseArray(int[] arr)
{
    int i = 0;
    while (i < (arr.Length / 2))
    {
        int temp = arr[i];
        arr[i] = arr[arr.Length - (i + 1)];
        arr[arr.Length - (i + 1)] = temp;
        i++;
    }
    return arr;
}