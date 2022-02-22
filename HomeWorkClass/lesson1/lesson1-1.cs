using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGBA.lesson1
{
    class Lesson1_1 : ILesson
    {
        public string lessonID => "1-1";

        public string discriprions => "Проверка, является ли число простым";


        /// <summary>
        /// Функция запрашивает данные у пользователя и запускает алгоритм. По окончанию выводит результат в консоль.
        /// </summary>
        public void Demo()
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
