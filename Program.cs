using System;

class Program
{
    static void Main()
    {
        int M = 1; // Начальное значение промежутка
        int N = 10; // Конечное значение промежутка

        PrintNaturalNumbers(M, N);
    }

    static void PrintNaturalNumbers(int start, int end)
    {
        // Базовый случай: если начальное значение больше конечного, завершаем рекурсию
        if (start > end)
            return;

        // Выводим текущее значение
        Console.WriteLine(start);

        // Рекурсивно вызываем функцию для следующего значения
        PrintNaturalNumbers(start + 1, end);
    }
}
