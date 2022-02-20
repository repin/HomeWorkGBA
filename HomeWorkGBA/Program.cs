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
                        var obj = asm.CreateInstance(type.FullName);
                        string lessonID = type.GetProperty("lessonID").GetValue(obj, null).ToString();
                        string discriprions = type.GetProperty("discriprions").GetValue(obj, null).ToString();
                        Console.WriteLine($"ID: {lessonID}; Название: {discriprions}");
                    }
            }
            string input = null;
            // Работа с вводом, ищем в методах свойство ссответствующее введенному заданию, запускаем метод из библиотеки.
            while (input != "exit")
            {
                Console.WriteLine("Введите ID задания для продолжения или \"exit\" для выхода.");
                input = Console.ReadLine();
                foreach (var type in types)
                {
                    if (type.IsInterface)
                    {
                        continue;
                    }
                    foreach (var metod in type.GetMethods())
                    {
                        if (metod.ToString() == "Void Demo()")
                        {
                            var obj = Activator.CreateInstance(type);
                            string lessonID = type.GetProperty("lessonID").GetValue(obj, null).ToString();
                            if (lessonID == input)
                            {
                                metod.Invoke(obj, null);
                            }
                        }
                    }
                }
            }
        }
    }
}

