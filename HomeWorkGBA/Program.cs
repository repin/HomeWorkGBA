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
                    Lesson1.Lesson1_1();
                    break;
                case "1-3":
                    Lesson1.Lesson1_3();
                    break;
            }

        }
    }
}
