using System;

namespace AckermannFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задаем значения m и n
            int m = 3;
            int n = 2;

            // Вычисляем значение функции Аккермана
            int result = Ackermann(m, n);

            // Выводим результат на экран
            Console.WriteLine($"A(m,n) = {result}");
        }

        static int Ackermann(int m, int n)
        {
            // Если m равен 0, возвращаем n + 1
            if (m == 0)
            {
                return n + 1;
            }

            // Если n равен 0, вызываем функцию рекурсивно для m - 1 и 1
            if (n == 0)
            {
                return Ackermann(m - 1, 1);
            }

            // Вызываем функцию рекурсивно для m - 1 и Ackermann(m, n - 1)
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}