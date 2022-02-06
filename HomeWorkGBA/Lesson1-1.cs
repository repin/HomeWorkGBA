using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGBA
{
    class Lesson1
    {

        /// <summary>
        /// Вспомогательный метод для тестирования урока 1-3.
        /// </summary>
        /// <param name="z"></param>
        /// <param name="result"></param>
        private static void TestLesson1_3(long z, long result)
        {
            if (result == FibonachiR(0, 1, z)) Console.WriteLine("VALID TEST");
            else Console.WriteLine("INVALID TEST");
            if (result == FibonachiF(z)) Console.WriteLine("VALID TEST");
            else Console.WriteLine("INVALID TEST");
        }

        /// <summary>
        /// Запускаем тест урока 1_3
        /// </summary>
        public static void Lesson1_3()
        {
            try
            {
                TestLesson1_3(1, 1);
                TestLesson1_3(2, 2);
                TestLesson1_3(3, 6);
                TestLesson1_3(15, 610);
                TestLesson1_3(15, 1307674368000);
                TestLesson1_3(-1, 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        /// <summary>
        /// Вычисляем число фибоначи циклом
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        private static long FibonachiF(long number)
        {
            if (number < 0) return -1;
            long t = 0;
            long k = 1;
            for (int i = 0; i < number - 1; i++)
            {
                // Console.WriteLine(t);
                long m = k;
                k = t + k;
                t = m;
            }
            return k;
        }

        /// <summary>
        /// Вычисляем число фибоначи рекурсивным методом
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="number"></param>
        /// <returns></returns>
        private static long FibonachiR(long first, long second, long number)
        {
            if (number < 0) return -1;
            if (number == 0) return first;
            number--;
            long t = FibonachiR(second, first + second, number);
            return t;
        }

        /// <summary>
        /// Функция запрашивает данные у пользователя и запускает алгоритм. По окончанию выводит результат в консоль.
        /// </summary>
        public static void Lesson1_1()
        {
            if (IsSimpleNumber(3) == true) Console.WriteLine("VALID TEST");
            else Console.WriteLine("INVALID TEST");
            if (IsSimpleNumber(33) == false) Console.WriteLine("VALID TEST");
            else Console.WriteLine("INVALID TEST");
            if (IsSimpleNumber(168) == false) Console.WriteLine("VALID TEST");
            else Console.WriteLine("INVALID TEST");
            if (IsSimpleNumber(36) == true) Console.WriteLine("VALID TEST");
            else Console.WriteLine("INVALID TEST");
            if (IsSimpleNumber(103) == false) Console.WriteLine("VALID TEST");
            else Console.WriteLine("INVALID TEST");
            if (IsSimpleNumber(199) == false) Console.WriteLine("VALID TEST");
            else Console.WriteLine("INVALID TEST");
        }

        /// <summary>
        /// Алгоритм возвращает является ли число простым или нет.
        /// </summary>
        /// <param name="number">Проверяемое число.</param>
        /// <returns></returns>
        private static bool IsSimpleNumber(int number)
        {
            int d = 0, i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                i++;
            }
            if (d == 0) return true;
            else return false;
        }
    }
}
