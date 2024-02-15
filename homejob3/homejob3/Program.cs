using System;

class Program
{
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index < 0)
        {
            return;
        }

        Console.Write($"{arr[index]} ");
        PrintArrayReverse(arr, index - 1);
    }

    static void Main(string[] args)
    {
        int[] arr = { 1, 10, 0, 5, 50 };
        int index = arr.Length - 1;

        PrintArrayReverse(arr, index);
    }
}
