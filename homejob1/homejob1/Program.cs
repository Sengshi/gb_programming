using System;

class homejob1
{
    static void PrintNaturalNumbers(int M, int N)
    {
        if (M > N)
        {
            return;
        }
        Console.Write($"{M} ");
        PrintNaturalNumbers(M + 1, N);
    }

    static void Main(string[] args)
    {
        int M, N;
        Console.Write("Enter the starting number M: ");
        M = int.Parse(Console.ReadLine());
        Console.Write("Enter the ending number N: ");
        N = int.Parse(Console.ReadLine());
        PrintNaturalNumbers(M, N);
    }
}
