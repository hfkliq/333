using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число N (> 2): ");
        int N;
        while (!int.TryParse(Console.ReadLine(), out N) || N <= 2)
        {
            Console.WriteLine("Ошибка! Введите целое число больше 2.");
        }

        // Создаем массив для хранения чисел Фибоначчи
        int[] fibonacciArray = new int[N];
        fibonacciArray[0] = 1; // F1
        fibonacciArray[1] = 1; // F2

        // Заполняем массив числами Фибоначчи
        for (int i = 2; i < N; i++)
        {
            fibonacciArray[i] = fibonacciArray[i - 2] + fibonacciArray[i - 1];
        }

        // Выводим массив
        Console.WriteLine("Числа Фибоначчи:");
        Console.WriteLine(string.Join(", ", fibonacciArray));
    }
}
