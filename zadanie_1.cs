using System;

class Program
{
    static void PrintNumbers(int M, int N)
    {
        if (M > N)
        {
            return;
        }
        Console.Write(M + " ");
        PrintNumbers(M + 1, N);
    }

    static void Main()
    {
        int M = 3;
        int N = 10;
        PrintNumbers(M, N);
    }
}