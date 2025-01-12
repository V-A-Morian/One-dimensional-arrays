using System;

class Program
{
    static void Main()
    {
        // Инициализация генератора случайных чисел
        Random random = new Random();

        // Создание исходного массива X
        int[] X = new int[36];
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = random.Next(-50, 51); // Генерация случайных чисел от -50 до 50
        }

        // Вывод исходного массива X
        Console.WriteLine("ИСХОДНЫЙ МАССИВ X:");
        foreach (var item in X)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Создание массива Y для положительных элементов
        int[] Y = new int[X.Length];
        int countY = 0; // Счетчик положительных элементов

        // Переписывание положительных элементов в массив Y
        for (int i = 0; i < X.Length; i++)
        {
            if (X[i] > 0)
            {
                Y[countY] = X[i];
                countY++;
            }
        }

        // Создание нового массива Y с правильным размером
        Array.Resize(ref Y, countY);

        // Подсчет четных элементов в массиве Y
        int evenCount = 0;
        foreach (var item in Y)
        {
            if (item % 2 == 0)
            {
                evenCount++;
            }
        }

        // Вывод полученного массива Y
        Console.WriteLine("ПОЛУЧЕННЫЙ МАССИВ Y:");
        foreach (var item in Y)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Вывод результатов обработки массива
        Console.WriteLine("РЕЗУЛЬТАТЫ ОБРАБОТКИ:");
        Console.WriteLine($"Количество четных элементов в массиве Y: {evenCount}");
    }
}