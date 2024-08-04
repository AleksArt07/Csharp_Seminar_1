using System;

namespace ReverseArrayRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаем массив
            int[] array = { 1, 2, 3, 4, 5 };

            // Выводим элементы массива в обратном порядке
            PrintReverse(array, 0);
        }

        static void PrintReverse(int[] array, int index)
        {
            // Если мы достигли конца массива, завершаем рекурсию
            if (index >= array.Length)
            {
                return;
            }

            // Вызываем функцию рекурсивно для следующего элемента массива
            PrintReverse(array, index + 1);

            // Выводим текущий элемент массива на экран
            Console.Write(array[index] + " ");
        }
    }
}