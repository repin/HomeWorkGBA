using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGBA.lesson1
{
    class Lesson1_3:ILesson
    {
        public string lessonID => "1-3";

        public string discriprions => "Рассчет фибоначи через рекурсию и цикл";

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
        public  void Demo()
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

    }
}
