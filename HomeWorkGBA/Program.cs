using System;
using System.Collections.Generic;

namespace HomeWorkGBA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ILesson> lessonList = new List<ILesson>
            {
                {new lesson1.Lesson1_1()},
                {new lesson1.Lesson1_3()},
                {new lesson2_1.Lesson2_1()},
                {new lesson3_1.Lesson3_1()},
                {new lesson4_1.Lesson4_1()},
                {new lesson5_1.Lesson5_1()}
            };
            Console.WriteLine("Список заданий:");
            foreach (ILesson lesson in lessonList)
            {
                Console.WriteLine($"ID: {lesson.lessonID}; Название: {lesson.discriprions}");
            }
            string input = null;
            while (input != "exit")
            {
                Console.WriteLine("Введите ID задания для продолжения или \"exit\" для выхода.");
                input = Console.ReadLine();
                foreach (ILesson lesson in lessonList)
                {
                    if (lesson.lessonID == input)
                    {
                        lesson.Demo();
                    }
                }
            }


        }
    }
}
