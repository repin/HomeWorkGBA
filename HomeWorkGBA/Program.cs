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
                case "2-1":
                    lesson2_1.Lesson2_1 lesson2_1 = new lesson2_1.Lesson2_1();
                    Console.WriteLine($"{lesson2_1.lessonID}: {lesson2_1.discriprions}");
                    lesson2_1.Demo();
                    break;
            }

        }
    }
}
