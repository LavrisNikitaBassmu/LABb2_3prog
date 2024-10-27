using System;

class Program
{
    static void Main()
    {
        int count = 0;
        int a = 1, b = 1;

        while (b < 10000)
        {
            if (b >= 1000)
            {
                count++;
            }

            int next = a + b;
            a = b;
            b = next;
        }

        Console.WriteLine($"Количество четырехзначных чисел в ряде Фибоначчи: {count}");
    }
}