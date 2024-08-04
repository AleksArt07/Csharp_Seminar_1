using System;

namespace NaturalNumbersRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаем значения M и N
            int m = 1;
            int n = 10;

            // Выводим все натуральные числа в промежутке от M до N
            PrintNaturalNumbers(m, n);
        }

        static void PrintNaturalNumbers(int m, int n)
        {
            // Если мы достигли конца промежутка, завершаем рекурсию
            if (m > n)
            {
                return;
            }

            // Выводим текущее число на экран
            Console.Write(m);

            // Если мы не достигли конца промежутка, выводим запятую
            if (m < n)
            {
                Console.Write(", ");
            }

            // Вызываем функцию рекурсивно для следующего числа
            PrintNaturalNumbers(m + 1, n);
        }
    }
}