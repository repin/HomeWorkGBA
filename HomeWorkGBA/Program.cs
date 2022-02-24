using System;
using System.Collections.Generic;
using System.Reflection;

namespace HomeWorkGBA
{
    class Program
    {
        static void Main(string[] args)
        {
            // Подключаем библиотеку
            List<ILesson> listLesson = new List<ILesson>();
            Assembly asm = Assembly.LoadFrom("HomeWorkClass.dll");
            Type[] types = asm.GetTypes();
            Console.WriteLine("Список заданий:");
            // Перебираем типы и выводим на экран те, в которых есть метод "Demo()" 
            foreach (var type in types)
            {
                if (type.IsInterface)
                {
                    continue;
                }
                foreach (var metod in type.GetMethods())
                    if (metod.ToString() == "Void Demo()")
                    {

                        var obj = Activator.CreateInstance(type);
                        listLesson.Add((ILesson)obj);
                    }
            }
            listLesson.Add(new Lesson7_1.Lesson7_1()) ;
            foreach (ILesson lesson in listLesson)
            {
                Console.WriteLine($"ID урока: {lesson.lessonID} Описание: {lesson.discriprions}");
            }
            string input = null;
            while (input != "exit")
            {
                Console.WriteLine("Введите ID урока, который хотите запустить.");
                input = Console.ReadLine();
                foreach (ILesson lesson in listLesson)
                {
                    if (input == lesson.lessonID)
                    {
                        lesson.Demo();
                        break;
                    }
                }
            }
        }

    }
}


