using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите значение N: ");
        int n = int.Parse(Console.ReadLine());

        PrintNumbersFromNTo1(n);
    }

    static void PrintNumbersFromNTo1(int n)
    {
        if (n == 0)
        {
            return;
        }

        Console.Write(n + " ");

        PrintNumbersFromNTo1(n - 1);
    }
}
