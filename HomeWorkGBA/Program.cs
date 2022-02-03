using System;

namespace HomeWorkGBA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер урока и задания который хотите проверить через тире, в формате \"1-1\"");
            string lesson = Console.ReadLine();
            switch (lesson)
            {
                case "1-1":
                    Lesson1_1();
                    break;
                case "1-3":
                    Lesson1_3();
                    break;
            }

        }

        private static void Lesson1_3()
        {
            Console.WriteLine("Введите целое число для расчета ряда фибоначи");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Каким способом вычислить? Введите 1 - для рекруссивного расчета, 2 для цикла");
            string vibor = Console.ReadLine();
            switch (vibor)
            {
                case "1":
                    FibonachiR(0,1,number);
                    break;
                case "2":
                    FibinachiF(number);
                    break;
            }
        }

        private static void FibinachiF( int number)
        {
            int t = 0;
            int k = 1;
            for (int i=0; i< number; i++)
            {
                Console.Write($"{t} ");
                int m = k;
                k = t + k;
                t = m;
            }

        }

        private static void FibonachiR(int first, int second, int number)
        {
            if (number == 0) return;
            Console.Write($"{first} ");
            number--;
            FibonachiR(second, first + second, number);
        }

        /// <summary>
        /// Функция запрашивает данные у пользователя и запускает алгоритм. По окончанию выводит результат в консоль.
        /// </summary>
        static void Lesson1_1()
        {
            Console.WriteLine("Введите целое число:");
            int number = int.Parse(Console.ReadLine());
            bool isSimple = IsSimpleNumber(number);
            if (isSimple) Console.WriteLine("Число простое");
            else Console.WriteLine("Число непростое");
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
