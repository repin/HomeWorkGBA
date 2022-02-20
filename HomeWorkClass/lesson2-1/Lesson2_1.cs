using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGBA.lesson2_1
{
    class Lesson2_1 : ILesson
    {
        public string lessonID => "2-1";

        public string discriprions => "Создание и работа с двухсвязным списком";

        public void Demo()
        {
            Console.WriteLine("Начало ДЗ по двхсвязным спискам");
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(1);
            linkedList.AddNode(17);
            Node findNode = linkedList.FindNode(1);
            Console.WriteLine(findNode.value);
            linkedList.AddNodeAfter(findNode, 34);
            linkedList.AddNode(17483);
            int countList = linkedList.GetCount();
            Console.WriteLine(countList);
            for (int i = 100; i < 119; i++)
            {
                linkedList.AddNode(i);
            }
            findNode = linkedList.FindNode(34);
            Console.WriteLine($"Значение найденного нода = {findNode.value}");
            linkedList.RemoveNode(findNode);
            findNode = linkedList.FindNode(100);
            Console.WriteLine($"Значение найденного нода = {findNode.value}");
            linkedList.RemoveNode(findNode);
            findNode = linkedList.FindNode(113);
            Console.WriteLine($"Значение найденного нода = {findNode.value}");
            Console.WriteLine(linkedList.GetCount());
            for (int i = 3; i < 8; i++)
            {
                linkedList.RemoveNode(i);
            }
            Console.WriteLine(linkedList.GetCount());
            Console.WriteLine("Конец ДЗ по двхсвязным спискам");
        }


    }
}
