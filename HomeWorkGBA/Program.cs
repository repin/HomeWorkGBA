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
                case "3-1":
                    lesson3_1.Lesson3_1 lesson3_1 = new lesson3_1.Lesson3_1();
                    Console.WriteLine($"{lesson3_1.lessonID}: {lesson3_1.discriprions}");
                    lesson3_1.Demo();
                    break;
                case "4-1":
                    lesson4_1.lesson4_1 lesson4_1 = new lesson4_1.lesson4_1();
                    Console.WriteLine($"{lesson4_1.lessonID}: {lesson4_1.discriprions}");
                    lesson4_1.Demo();
                    break;
            }

        }
    }
}
