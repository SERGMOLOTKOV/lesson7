using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 }; // Произвольный массив

        // Выводим элементы массива, начиная с конца
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        // Базовый случай: если индекс выходит за границы массива, завершаем рекурсию
        if (index < 0)
            return;

        // Выводим текущий элемент массива
        Console.WriteLine(array[index]);

        // Рекурсивно вызываем функцию для предыдущего элемента
        PrintArrayReversed(array, index - 1);
    }
}
