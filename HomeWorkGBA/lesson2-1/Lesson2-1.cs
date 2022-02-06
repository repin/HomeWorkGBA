using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGBA
{
    class Lesson2_1 : ILesson
    {
        public string lessonID => "Lesson2-1";

        public string discriprions => "Создание и работа с двухсвязным списком";

        public void Demo()
        {
            Console.WriteLine("Начало ДЗ по двхсвязным спискам");
            Node firstNode = new Node() { value = 1, lastItem = null, nextItem = null };


            Console.WriteLine("Конец ДЗ по двхсвязным спискам");
        }


    }
}
